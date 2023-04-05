﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cognex.VisionPro;
using Cognex.VisionPro.PMAlign;
using Jastech.Framework.Imaging.VisionPro.VisionAlgorithms;
using Jastech.Framework.Imaging.VisionPro.VisionAlgorithms.Parameters;
using Jastech.Framework.Winform.VisionPro.Forms;
using Jastech.Framework.Winform.Forms;
using Cognex.VisionPro.Implementation;

namespace Jastech.Framework.Winform.VisionPro.Controls
{
    public partial class CogPatternMatchingParamControl : UserControl
    {

        #region 필드
        private CogPatternMatchingParam CurrentParam;
        #endregion

        #region 속성
        #endregion

        #region 이벤트
        public GetOriginImageDelegate GetOriginImageHandler;
        #endregion

        #region 델리게이트
        public delegate ICogImage GetOriginImageDelegate();
        #endregion

        #region 생성자
        #endregion

        #region 메서드
        public CogPatternMatchingParamControl()
        {
            InitializeComponent();
        }

        private void lblAddPattern_Click(object sender, EventArgs e)
        {
            if (GetOriginImage() != null)
            {
                if (CurrentParam.GetSearchRegion() == null)
                    return;

                ICogImage originImage = GetOriginImageHandler();
                
                CurrentParam.Train(originImage);
                cogPatternDisplay.Image = CurrentParam.GetTrainedPatternImage();
            }
        }

        public void UpdateData(CogPatternMatchingParam matchingParam)
        {
            nupdnMatchScore.Value = (decimal)matchingParam.Score;
            nupdnMaxAngle.Value = (decimal)matchingParam.MaxAngle;
            CurrentParam = matchingParam;

            cogPatternDisplay.InteractiveGraphics.Clear();
            cogPatternDisplay.StaticGraphics.Clear();

            if (CurrentParam.IsTrained())
            {
                cogPatternDisplay.Image = CurrentParam.GetTrainedPatternImage();
                CogPMAlignCurrentRecordConstants constants = CogPMAlignCurrentRecordConstants.TrainImage |
                                                        CogPMAlignCurrentRecordConstants.TrainImageMask;
                SetStaticGraphics("Masking", CurrentParam.CreateCurrentRecord(constants));
            }
            else
                cogPatternDisplay.Image = null;
        }

        private void SetStaticGraphics(string groupName, ICogRecord record)
        {
            foreach (CogRecord subRecord in record.SubRecords)
            {
                if (typeof(ICogGraphic).IsAssignableFrom(subRecord.ContentType))
                {
                    if (subRecord.Content != null)
                        cogPatternDisplay.StaticGraphics.Add(subRecord.Content as ICogGraphicInteractive, groupName);
                }
                else if (typeof(CogGraphicCollection).IsAssignableFrom(subRecord.ContentType))
                {
                    if (subRecord.Content != null)
                    {
                        CogGraphicCollection graphics = subRecord.Content as CogGraphicCollection;
                        foreach (ICogGraphic graphic in graphics)
                        {
                            cogPatternDisplay.StaticGraphics.Add(graphic as ICogGraphicInteractive, groupName);
                        }
                    }
                }
                else if (typeof(CogGraphicInteractiveCollection).IsAssignableFrom(subRecord.ContentType))
                {
                    if (subRecord.Content != null)
                    {
                        cogPatternDisplay.StaticGraphics.AddList(subRecord.Content as CogGraphicCollection, groupName);
                    }
                }
                SetStaticGraphics(groupName, subRecord);
            }
        }

        public CogPatternMatchingParam GetCurrentParam()
        {
            return CurrentParam;
        }

        private ICogImage GetOriginImage()
        {
            if (GetOriginImageHandler != null)
            {
                ICogImage originImage = GetOriginImageHandler();
                return originImage;
            }
            return null;
        }

        public void SetTrainImage(ICogImage image)
        {
            cogPatternDisplay.Image = image;
        }
        #endregion
        private void lblInspection_Click(object sender, EventArgs e)
        {
            
        }

        private void lblMasking_Click(object sender, EventArgs e)
        {
            if(CurrentParam.IsTrained())
            {
                if (GetOriginImage() is ICogImage orginImage)
                {
                    CogAlignMaskingForm form = new CogAlignMaskingForm();
                    form.Initialize(CurrentParam);
                    if(form.ShowDialog() == DialogResult.OK)
                    {
                        CurrentParam.TrainImageMask(form.GetCurrentParam().GetTrainImageMask());

                        UpdateData(CurrentParam);
                    }
                }
            }
            else
            {
                MessageConfirmForm form = new MessageConfirmForm();
                form.Message = "Not Trained.";
                form.ShowDialog();

            }
        }
    }
}
