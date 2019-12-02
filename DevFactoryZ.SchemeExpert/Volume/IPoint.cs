using System;
using System.Collections.Generic;
namespace DevFactoryZ.SchemeExpert.Volume
{
    /// <summary>
    /// Этот интерфейс описывает точку / вектор в 3-х мерном пространстве
    /// </summary>
    public interface IPoint
    {
        double X { get; set; }
        double Y { get; set; }

        event EventHandler<PointChangedEventArgs<IPoint>> OnLocationChanged;
    }

    public class PointChangedEventArgs<IPoint> : EventArgs
    {
        public IPoint OldLocation { get; set; }
        public IPoint NewLocation { get; set; }
    }
}
