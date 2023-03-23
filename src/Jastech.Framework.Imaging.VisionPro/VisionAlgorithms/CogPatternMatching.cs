﻿using Cognex.VisionPro;
using Cognex.VisionPro.PMAlign;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jastech.Framework.Imaging.VisionPro.VisionAlgorithms
{
    public class CogPatternMatching
    {
        #region 필드
        public CogPMAlignTool MatchingTool { get; set; } = new CogPMAlignTool();
        #endregion

        #region 속성
        public ICogImage TrainImage { get; set; } = null;
        #endregion

        #region 이벤트
        #endregion

        #region 델리게이트
        #endregion

        #region 생성자
        #endregion

        #region 메서드
        public CogPMAlignTool SetTrainRegion(CogRectangle roi)
        {
            if(MatchingTool.Pattern.Trained == false)
            {
                CogRectangle rect = new CogRectangle(roi);

                MatchingTool.Pattern.Origin.TranslationX = rect.CenterX;
                MatchingTool.Pattern.Origin.TranslationY = rect.CenterY;
                MatchingTool.Pattern.TrainRegion = rect;
                MatchingTool.CurrentRecordEnable = CogPMAlignCurrentRecordConstants.TrainImage |
                                                        CogPMAlignCurrentRecordConstants.TrainRegion |
                                                        CogPMAlignCurrentRecordConstants.PatternOrigin;
            }
            
            return MatchingTool;
        }

        public ICogRegion GetTrainRegion()
        {
            // 임시
            //if (_cogPMAlignTool.Pattern.Trained == false)
            //    return null;

            return MatchingTool.Pattern.TrainRegion;
        }

        public CogPMAlignTool SetSearchRegion(CogRectangle roi)
        {
            CogRectangle rect = new CogRectangle(roi);
            rect.Color = CogColorConstants.Green;
            rect.LineStyle = CogGraphicLineStyleConstants.Dot;
            MatchingTool.SearchRegion = new CogRectangle(rect);
            //_cogPMAlignTool.SearchRegion = new CogRectangle(roi);
            MatchingTool.CurrentRecordEnable = CogPMAlignCurrentRecordConstants.InputImage |
                                                  CogPMAlignCurrentRecordConstants.SearchRegion;
            //_cogPMAlignTool.SearchRegion

            
            return MatchingTool;
        }

        public ICogRegion GetSearchRegion()
        {
            return MatchingTool.SearchRegion;
        }

        public bool Train(ICogImage image)
        {
            if (image == null)
                return false;

            MatchingTool.Pattern.TrainImage = image;
            MatchingTool.Pattern.Train();

            return true;
        }

        public void Find()
        {

        }
        #endregion
    }
}