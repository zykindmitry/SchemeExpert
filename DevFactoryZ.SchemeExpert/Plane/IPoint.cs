using System;

namespace DevFactoryZ.SchemeExpert._2D
{
    /// <summary>
    /// Этот интерфейс описывает точку / вектор в 3-х мерном пространстве
    /// </summary>

    public interface IPoint : ICoordinate
    {
        event EventHandler<PointChangedEventArgs> PointLocationChanged;
    }

    public class PointChangedEventArgs : EventArgs
    {
        public PointChangedEventArgs(ICoordinate previous, ICoordinate current)
        {
            Previous = previous;
            Current = current;
        }
        
        public ICoordinate Previous { get; }
        public ICoordinate Current { get; }
    }
}
