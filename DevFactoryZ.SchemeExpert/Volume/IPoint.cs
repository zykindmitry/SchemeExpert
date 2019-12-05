using System;
using System.Collections.Generic;
namespace DevFactoryZ.SchemeExpert.Volume
{
    /// <summary>
    /// Этот интерфейс описывает точку / вектор в 3-х мерном пространстве
    /// </summary>

    public interface IPoint : ICoordinate
    {
        event EventHandler<PointChangedEventArgs> OnLocationChanged;
    }

    public class PointChangedEventArgs : EventArgs
    {
        private readonly ICoordinate coordinate;

        public PointChangedEventArgs(ICoordinate coordinate)
        {
            this.coordinate = coordinate;
        }
        
        public ICoordinate Coordinate { get; }
    }
}
