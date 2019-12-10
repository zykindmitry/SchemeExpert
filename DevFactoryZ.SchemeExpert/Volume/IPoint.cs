using System;

namespace DevFactoryZ.SchemeExpert._3D
{
    /// <summary>
    /// Этот интерфейс описывает точку / вектор в 3-х мерном пространстве.
    /// </summary>
    public interface IPoint 
    {
        /// <summary>
        /// Текущие координаты 3D-точки / вектора.
        /// </summary>
        ILocation Location { get; }

        /// <summary>
        /// Событие, наступающее при изменении любой из координат 3D-точки / вектора.
        /// </summary>
        event EventHandler<LocationChangedEventArgs> PointMoved;
    }
}
