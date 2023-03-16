﻿using Jastech.Framework.Device.Grabbers;
using Matrox.MatroxImagingLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Jastech.Framework.Device.Cameras
{
    public class CameraMil : Camera
    {

        #region 필드
        const int BufferPoolCount = 10;

        private MilSystem MilSystem { get; set; } = null;

        private uint DigitizerNum { get; set; } = 0; // 1개의 Frame Grabber에 연결된 카메라 Index

        private MIL_ID DigitizerId { get; set; }

        private GCHandle _thisHandle;

        private MIL_ID LastGrabImage = MIL.M_NULL;

        private MIL_ID[] _grabImageBuffer = new MIL_ID[BufferPoolCount];

        MIL_DIG_HOOK_FUNCTION_PTR processingFunctionPtr = null;
        #endregion

        #region 속성
        public MilSystemType MilSystemType { get; set; } = MilSystemType.Solios;

        public uint SystemNum { get; set; } = 1; // 설치된 Frame Grabber Index

        public int NumOfBand { get; set; }

        public int ImagePitch { get; set; }
        #endregion

        #region 이벤트
        #endregion

        #region 델리게이트
        #endregion

        #region 생성자
        public CameraMil(CameraInfo cameraInfo)
          : base(cameraInfo)
        {
        }
        #endregion

        #region 메서드

        public override bool Initialize()
        {
            MilSystem = GrabberMil.GetMilSystem(MilSystemType, SystemNum);

            if (MilSystem == null)
                return false;

            MilCameraInfo milCameraInfo = CameraInfo as MilCameraInfo;


            string dcfFile = GetDcfFile(milCameraInfo.CameraType);
            if (dcfFile == "")
                return false;

            if (CreateDigitizerId(dcfFile) == false)
                return false;

            //ImageWidth = (int)MIL.MdigInquire(MilDigitizerId, MIL.M_SIZE_X, MIL.M_NULL);
            //ImageHeight = (int)MIL.MdigInquire(MilDigitizerId, MIL.M_SIZE_Y, MIL.M_NULL);

            //if (IsContinuous)
            //    MIL.MappControl(MIL.M_GRAB_MODE, MIL.M_CONTIGUOUS);

            MIL.MappControl(MIL.M_ERROR, MIL.M_PRINT_ENABLE);

#if DEBUG
            MIL.MdigControl(DigitizerId, MIL.M_GRAB_TIMEOUT, MIL.M_INFINITE);
#elif RELEASE
            MIL.MdigControl(MilDigitizerId, MIL.M_GRAB_TIMEOUT, 5000);
#endif
            // MIL M_GRAB_END 콜백 등록
            //ThisHandle = GCHandle.Alloc(this);
            //MIL.MdigHookFunction(MilDigitizerId, MIL.M_GRAB_END, new MIL_DIG_HOOK_FUNCTION_PTR(HookHandlerPtr), GCHandle.ToIntPtr(ThisHandle));

            MIL_INT tempValue = 0;
            MIL_INT width = 0;
            MIL_INT height = 0;

            MIL.MdigInquire(DigitizerId, MIL.M_SIZE_X, ref width);
            MIL.MdigInquire(DigitizerId, MIL.M_SIZE_Y, ref height);

            MIL.MdigInquire(DigitizerId, MIL.M_SIZE_BAND, ref tempValue);
            NumOfBand = (int)tempValue;

            ImagePitch = (int)width * NumOfBand;

            if(NumOfBand == 1)
            {
                for (int i = 0; i < BufferPoolCount; i++)
                {
                    _grabImageBuffer[i] = MIL.MbufAlloc2d(MilSystem.SystemId, width, height, MIL.M_UNSIGNED + 8, MIL.M_IMAGE + MIL.M_PROC + MIL.M_GRAB, MIL.M_NULL);
                }
            }
            else
            {
                for (int i = 0; i < BufferPoolCount; i++)
                {
                    _grabImageBuffer[i] = MIL.MbufAllocColor(MilSystem.SystemId, 3, width, height, MIL.M_UNSIGNED + 8, MIL.M_IMAGE + MIL.M_PROC + MIL.M_GRAB, MIL.M_NULL);
                }
            }

            return true;
        }

        public override void Release()
        {
            MIL.MdigFree(DigitizerId);

            MIL.MdigFree(LastGrabImage);

            for (int i = 0; i < BufferPoolCount; i++)
            {
                MIL.MdigFree(_grabImageBuffer[i]); 
            }
        }

        private bool CreateDigitizerId(string dcfFile)
        {
            if (dcfFile == "")
                return false;

            MIL_ID milDigitizer = MIL.MdigAlloc(MilSystem.SystemId, DigitizerNum, dcfFile, MIL.M_DEFAULT, MIL.M_NULL);

            if (milDigitizer == null)
                return false;

            DigitizerId = milDigitizer;

            return true;
        }

        private string GetDcfFile(CameraType cameraType)
        {
            string dcfFile = "";
            switch (cameraType)
            {
                case CameraType.VT_6k35c_trigger:
                    dcfFile = "VT-6k3.5c_trigger.dcf";
                    break;
                default:
                    break;
            }
            return dcfFile;
        }

        public MIL_INT HookHandlerPtr(MIL_INT HookType, MIL_ID EventId, IntPtr UserDataPtr)
        {
            MIL_ID currentImageId = MIL.M_NULL;
            MIL.MdigGetHookInfo(EventId, MIL.M_MODIFIED_BUFFER + MIL.M_BUFFER_ID, ref currentImageId);

            LastGrabImage = currentImageId;

            return MIL.M_NULL;
        }

        public override byte[] GetGrabbedImage()
        {
            if (LastGrabImage != null)
            {
                IntPtr ptr = IntPtr.Zero;
                var pitch = MIL.MbufInquire(LastGrabImage, MIL.M_PITCH, ptr);

                //byte[] UserArrayPtr = new byte[CameraInfo.ImageWidth * CameraInfo.ImageHeight];
                byte[] dataArray = new byte[pitch * CameraInfo.ImageHeight];

                MIL.MbufGet(LastGrabImage, dataArray);

                return dataArray;
            }
            else
            {
                return null;
            }
        }

        public override void GrabOnce()
        {
            MIL.MdigGrab(DigitizerId, LastGrabImage);
        }

        public override void GrabMuti(int grabCount)
        {
            if (CameraInfo.TriggerMode == TriggerMode.Software)
            {
                MIL.MdigGrabContinuous(DigitizerId, LastGrabImage);
            }
            else if(grabCount < 0)
            {
                if (processingFunctionPtr != null)
                    processingFunctionPtr = new MIL_DIG_HOOK_FUNCTION_PTR(ProcessingFunction);

                // Stop 명령어 올때 까지 계속해서 Grab
                MIL.MdigProcess(DigitizerId, _grabImageBuffer, BufferPoolCount, MIL.M_START, MIL.M_DEFAULT, processingFunctionPtr, GCHandle.ToIntPtr(_thisHandle));
            }
            else
            {
                if (processingFunctionPtr != null)
                    processingFunctionPtr = new MIL_DIG_HOOK_FUNCTION_PTR(ProcessingFunction);

                // 정해진 GrabCount 만큼 영상 취득
                int count = grabCount < BufferPoolCount ? grabCount : BufferPoolCount;
                MIL.MdigProcess(DigitizerId, _grabImageBuffer, BufferPoolCount, MIL.M_SEQUENCE + MIL.M_COUNT(count), MIL.M_ASYNCHRONOUS, processingFunctionPtr, GCHandle.ToIntPtr(_thisHandle));
            }
        }

        static MIL_INT ProcessingFunction(MIL_INT HookType, MIL_ID HookId, IntPtr HookDataPtr)
        {
            if (IntPtr.Zero.Equals(HookDataPtr) == true)
                return MIL.M_NULL;

            MIL_ID currentImageId = MIL.M_NULL;
            MIL.MdigGetHookInfo(HookId, MIL.M_MODIFIED_BUFFER + MIL.M_BUFFER_ID, ref currentImageId);

            GCHandle hUserData = GCHandle.FromIntPtr(HookDataPtr);

            // get a reference to the DigHookUserData object
            CameraMil cameraMil = hUserData.Target as CameraMil;
            cameraMil.LastGrabImage = currentImageId;
            cameraMil.ImageGrabbedCallback();
            
            return MIL.M_NULL;
        }

        public override void Stop()
        {
            if (CameraInfo.TriggerMode == TriggerMode.Software)
            {
                MIL.MdigHalt(DigitizerId);
            }
            else
            {
                MIL.MdigProcess(DigitizerId, _grabImageBuffer, 2, MIL.M_STOP, MIL.M_DEFAULT, processingFunctionPtr, GCHandle.ToIntPtr(_thisHandle));
            }
            Thread.Sleep(50);
        }

        public override void SetExposureTime(double value)
        {
            // dcf 파일에서 설정함
        }

        public override double GetExposureTime()
        {
            // dcf 파일에서 설정함
            return 0.0;
        }

        public override void ReverseX(bool reverse)
        {
            // dcf 파일에서 설정함
        }

        public override void SetAnalogGain(int value)
        {
            // dcf 파일에서 설정함
        }

        public override void SetDigitalGain(double value)
        {
            // dcf 파일에서 설정함
        }

        public override void SetOffsetX(int value)
        {
            // dcf 파일에서 설정함
        }

        public override void SetImageWidth(int value)
        {
            // dcf 파일에서 설정함
        }
        #endregion
    }
}