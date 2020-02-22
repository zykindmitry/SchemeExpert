using System;

namespace DevFactoryZ.SchemeExpert._2D
{
    /// <summary>
    /// Этот интерфейс описывает точку / вектор на плоскости
    /// </summary>
    interface IPoint
    {
        /// <summary>
        /// Положение точки на плоскости
        /// </summary>
        ILocation Location { get; }

        /// <summary>
        /// Срабатывает после изменения положения точки на плоскости
        /// </summary>
        event EventHandler<LocationChangedEventArgs> LocationChanged;
    }
}
