﻿using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Jastech.Framework.Util.Helper
{
    public static class MathHelper
    {
        public static double DegToRad(double deg)
        {
            return deg * Math.PI / 180.0;
        }

        public static double RadToDeg(double rad)
        {
            return rad * 180.0 / Math.PI;
        }

        public static double GetRadian(PointF leftPoint, PointF rightPoint)
        {
            double deltaX = rightPoint.X - leftPoint.X;
            double deltaY = rightPoint.Y - leftPoint.Y;
            return Math.Atan2(deltaY, deltaX);
        }
        
        public static PointF GetCenterPoint(PointF point1, PointF point2)
        {
            PointF centerPoint = new PointF();

            double x = (point1.X + point2.X) / 2.0;
            double y = (point1.Y + point2.Y) / 2.0;

            centerPoint.X = Convert.ToSingle(x);
            centerPoint.Y = Convert.ToSingle(y);

            return centerPoint;
        }

        public static PointF GetOffset(PointF point1, PointF point2)
        {
            PointF offset = new PointF();

            offset.X = point2.X - point1.X;
            offset.Y = point2.Y - point1.Y;

            return offset;
        }

        public static PointF GetCoordinate(PointF centerPoint, double diffAngle, PointF offset, PointF inputPoint)
        {
            PointF outputPoint = new PointF();

            PointF tempPoint = new PointF();

            tempPoint.X = inputPoint.X - centerPoint.X + offset.X;
            tempPoint.Y = inputPoint.Y - centerPoint.Y + offset.Y;
            tempPoint.Y *= -1;

            //inputPoint.X += offset.X;
            //inputPoint.Y += offset.Y;

            double offsetRadian = DegToRad(diffAngle);// 센터, 옵셋, 각도, 출력

            var coordinateX = (tempPoint.X * Math.Cos(offsetRadian)) - (tempPoint.Y * Math.Sin(offsetRadian));
            var coordinateY = (tempPoint.X * Math.Sin(offsetRadian)) + (tempPoint.Y * Math.Cos(offsetRadian));

            outputPoint.X = (float)coordinateX + centerPoint.X;
            outputPoint.Y = ((float)coordinateY * -1.0F) + centerPoint.Y;

            return outputPoint;
        }

        public static double GetDistance(Point point1, Point point2)
        {
            int dx = point2.X - point1.X;
            int dy = point2.Y - point1.Y;

            return Math.Sqrt(dx * dx + dy * dy);
        }

        public static double GetDistance(PointF point1, PointF point2)
        {
            double dx = point2.X - point1.X;
            double dy = point2.Y - point1.Y;

            return Math.Sqrt(dx * dx + dy * dy);
        }

        public static double GetSlope(PointF point1, PointF point2)
        {
            double deltaX = Math.Abs(point1.X - point2.X);
            double deltaY = Math.Abs(point1.Y - point2.Y);

            return deltaY / deltaX;
        }

        public static double GetFloorDecimal(double value, int decimalPlaces)
        {
            double factor = Math.Pow(10, decimalPlaces);
            double result = (int)(value * factor) / factor;
            return result;
        }

        //public static T GetFloorDecimal<T>(T value, int decimalPlaces) where T : struct, IConvertible
        //{
        //    if (typeof(T) == typeof(double) || typeof(T) == typeof(float))
        //    {
        //        double factor = Math.Pow(10, decimalPlaces);
        //        double result = Math.Floor(Convert.ToDouble(value) * factor) / factor;
        //        return (T)Convert.ChangeType(result, typeof(T));
        //    }
        //    else
        //        throw new ArgumentException($"{typeof(T)} is not Decimal type.");
        //}

        public static double GetSampleStandardDeviation(List<double> valueList, double mean)
        {
            double squaredDifferencesSum = valueList.Sum(value => Math.Pow(value - mean, 2));
            double squaredDifferencesMean = squaredDifferencesSum / (valueList.Count - 1);
            double standardDeviation = Math.Sqrt(squaredDifferencesMean);

            return standardDeviation;
        }

        public static double GetPopulationStandardDeviation(List<double> valueList, double mean)
        {
            if (valueList.Count < 2)
                return 0;

            double squaredDifferencesSum = valueList.Sum(value => Math.Pow(value - mean, 2));
            double squaredDifferencesMean = squaredDifferencesSum / valueList.Count;
            double standardDeviation = Math.Sqrt(squaredDifferencesMean);

            return standardDeviation;
        }
    }
}
