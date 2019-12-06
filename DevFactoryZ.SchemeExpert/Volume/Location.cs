using System;

namespace DevFactoryZ.SchemeExpert._3D
{
    /// <summary>
    /// Имплементация интерфейса <see cref="SchemeExpert.ILocation"/>. 
    /// Определяет координаты 3D-точки / вектора, сожержит
    /// переопределенный метод <see cref="Equals(object)"/> для сравнения текущего экземпляра <see cref="Location"/> с другим объектом,
    /// а также параметр, определяющий точность сравнения значений координат - 
    /// количество знаков после запятой, участвующих в сравнении значений двух координат.
    /// </summary>
    public class Location : SchemeExpert.ILocation
    {
        #region .ctor

        /// <summary>
        /// Создает экземпляр <see cref="Location"/> с заданными параметрами.
        /// </summary>
        /// <param name="x">Координата 3D-точки / вектора по оси <see cref="X"/>.</param>
        /// <param name="y">Координата 3D-точки / вектора по оси <see cref="Y"/>.</param>
        /// <param name="z">Координата 3D-точки / вектора по оси <see cref="Z"/>.</param>
        /// <param name="precision">Количество знаков после запятой, участвующих в сравнении значений двух координат.</param>
        public Location(double x, double y, double z, uint precision)
        {
            X = x;
            Y = y;
            Z = z;
            Precision = precision;
        }

        #endregion

        #region Координаты 3D-точки / вектора

        /// <summary>
        /// Координата 3D-точки / вектора по оси <see cref="X"/>.
        /// </summary>
        public double X { get; }

        /// <summary>
        /// Координата 3D-точки / вектора по оси <see cref="Y"/>.
        /// </summary>
        public double Y { get; }

        /// <summary>
        /// Координата 3D-точки / вектора по оси <see cref="Z"/>.
        /// </summary>
        public double Z { get; }

        #endregion

        /// <summary>
        /// Точность сравнения значений координат - 
        /// количество знаков после запятой, участвующих в сравнении значений двух координат.
        /// </summary>
        public uint Precision { get; }

        #region Переопределенные методы

        public override bool Equals(object obj)
        {
            return !(obj is Location compareWith) ? false
                : X.Equals(compareWith.X, compareWith.Precision) && Y.Equals(compareWith.Y, compareWith.Precision) && Z.Equals(compareWith.Z, compareWith.Precision);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        #endregion
    }
}
