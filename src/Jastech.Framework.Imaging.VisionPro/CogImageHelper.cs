﻿using Cognex.VisionPro;
using Cognex.VisionPro.ImageFile;
using Cognex.VisionPro.ImageProcessing;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jastech.Framework.Imaging.VisionPro
{
    public static class CogImageHelper
    {
        public static ICogImage Load(string fileName)
        {
            CogImageFile cogImageFile = new CogImageFile();

            cogImageFile.Open(fileName, CogImageFileModeConstants.Read);

            ICogImage image = cogImageFile[0];
            cogImageFile.Close();

            return image;
        }

        public static void Save(ICogImage image, string fileName)
        {
            string extension = Path.GetExtension(fileName);
            if (extension == ".bmp")
            {
                CogImageFileBMP bmp = new CogImageFileBMP();
                bmp.Open(fileName, CogImageFileModeConstants.Write);
                bmp.Append(image);
                bmp.Close();
            }
            else if(extension == ".jpg" || extension == "jpeg")
            {
                CogImageFileJPEG jpg = new CogImageFileJPEG();
                jpg.Open(fileName, CogImageFileModeConstants.Write);
                jpg.Append(image);
                jpg.Close();
            }
            else if(extension == ".png")
            {
                CogImageFilePNG png = new CogImageFilePNG();
                png.Open(fileName, CogImageFileModeConstants.Write);
                png.Append(image);
                png.Close();
            }
        }

        public static CogImage8Grey Threshold(CogImage8Grey orgImage, int threshold, int maxValue, bool isInvert = false)
        {
            CogIPOneImageTool imageTool = new CogIPOneImageTool();
            byte[] mapArray = new byte[256];

            for (int i = 0; i < mapArray.Length; i++)
            {
                byte data = mapArray[i];
                if (i >= threshold)
                    mapArray[i] = isInvert ? (byte)0 : (byte)maxValue;
                else
                    mapArray[i] = isInvert ? (byte)maxValue : (byte)0;
            }

            CogRectangle rect = new CogRectangle
            {
                X = 0,
                Y = 0,
                Width = orgImage.Width,
                Height = orgImage.Height,
            };

            CogIPOneImagePixelMap pixelMap = new CogIPOneImagePixelMap();
            pixelMap.SetMap(mapArray);

            imageTool.Operators.Add(pixelMap);
            pixelMap.Dispose();

            imageTool.InputImage = orgImage;
            imageTool.Run();

            CogImage8Grey outputImage = new CogImage8Grey((CogImage8Grey)imageTool.OutputImage);
            imageTool.Dispose();

            return outputImage;
        }

        public static CogImage8Grey Threshold(CogImage8Grey orgImage, int minThreshold, int maxThreshold, int maxValue, bool isInvert = false)
        {
            CogIPOneImageTool imageTool = new CogIPOneImageTool();
            byte[] mapArray = new byte[256];

            for (int i = 0; i < mapArray.Length; i++)
            {
                byte data = mapArray[i];
                if (i >= minThreshold && i <= maxThreshold)
                    mapArray[i] = isInvert ? (byte)0 : (byte)maxValue;
                else
                    mapArray[i] = isInvert ? (byte)maxValue : (byte)0;
            }

            CogRectangle rect = new CogRectangle
            {
                X = 0,
                Y = 0,
                Width = orgImage.Width,
                Height = orgImage.Height,
            };

            CogIPOneImagePixelMap pixelMap = new CogIPOneImagePixelMap();
            pixelMap.SetMap(mapArray);

            imageTool.Operators.Add(pixelMap);
            pixelMap.Dispose();

            imageTool.InputImage = orgImage;
            imageTool.Run();

            CogImage8Grey outputImage = new CogImage8Grey((CogImage8Grey)imageTool.OutputImage);
            imageTool.Dispose();

            return outputImage;
        }

        public static void CogCopyRegionTool(ICogImage destImage, ICogImage inputImage, CogRectangle rect)
        {
            CogCopyRegionTool regionTool = new CogCopyRegionTool();

            regionTool.DestinationImage = destImage;
            regionTool.InputImage = inputImage;
            regionTool.Region = rect;

            regionTool.RunParams.ImageAlignmentEnabled = true;
            regionTool.Run();

            regionTool.Dispose();
        }

        public static ICogImage CropImage(ICogImage sourceImage, CogRectangle rect)
        {
            CogCopyRegionTool regionTool = new CogCopyRegionTool();
            regionTool.InputImage = sourceImage;
            regionTool.Region = rect;
            regionTool.Run();
            return regionTool.OutputImage;
        }

        public static CogRectangle CreateRectangle(double centerX, double centerY, double width, double height, bool interactive = true, CogRectangleDOFConstants constants = CogRectangleDOFConstants.All)
        {
            CogRectangle roi = new CogRectangle();

            roi.SetCenterWidthHeight(centerX, centerY, width, height);
            roi.Interactive = interactive;
            roi.GraphicDOFEnable = constants;

            return roi;
        }
    }
}
