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
    public class Location : ILocation
    {
        #region .ctor

        /// <summary>
        /// Создает экземпляр <see cref="Location"/> с заданными параметрами.
        /// </summary>
        /// <param name="x">Координата 3D-точки / вектора по оси <see cref="X"/>.</param>
        /// <param name="y">Координата 3D-точки / вектора по оси <see cref="Y"/>.</param>
        /// <param name="z">Координата 3D-точки / вектора по оси <see cref="Z"/>.</param>
        /// <param name="precision">Точность сравнения - количество знаков после запятой, участвующих в сравнении значений двух координат.</param>
        public Location(double x, double y, double z, uint precision)
        {
            X = x;
            Y = y;
            Z = z;
            this.precision = precision;
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
        readonly uint precision;

        #region Методы изменения значений координат

        /// <summary>
        /// Возвращает новый экземпляр <see cref="ILocation"/>, суммируя заданные значения координат вектора перемещения с координатами текущего экземпляра <see cref="ILocation"/>.
        /// Точность сравнения значений координат берется из текущего экземпляра <see cref="ILocation"/>.
        /// </summary>
        /// <param name="x">Координата вектора перемещения по оси <see cref="X"/>.</param>
        /// <param name="y">Координата вектора перемещения по оси <see cref="Y"/>.</param>
        /// <param name="z">Координата вектора перемещения по оси <see cref="Z"/>.</param>
        /// <returns>Новый экземпляр <see cref="ILocation"/>.</returns>
        public ILocation CreateByAdding(double x, double y, double z)
        {
            return new Location(x + X, y + Y, z + Z, precision);
        }

        /// <summary>
        /// Возвращает новый экземпляр <see cref="ILocation"/>, суммируя значения координат заданного вектора перемещения с координатами текущего экземпляра <see cref="ILocation"/>.
        /// Точность сравнения значений координат берется из текущего экземпляра <see cref="ILocation"/>.
        /// </summary>
        /// <param name="vector">Вектор перемещения 3D-точки.</param>
        /// <returns>Новый экземпляр <see cref="ILocation"/>.</returns>
        public ILocation CreateByAdding(ILocation vector)
        {
            return CreateByAdding(vector?.X ?? 0, vector?.Y ?? 0, vector?.Z ?? 0);
        }

        /// <summary>
        /// Возвращает новый экземпляр <see cref="ILocation"/> с заданными координатами.
        /// </summary>
        /// <param name="x">Координата 3D-точки / вектора по оси <see cref="X"/>.</param>
        /// <param name="y">Координата 3D-точки / вектора по оси <see cref="Y"/>.</param>
        /// <param name="z">Координата 3D-точки / вектора по оси <see cref="Z"/>.</param>
        /// <returns>Новый экземпляр <see cref="ILocation"/>.</returns>
        public ILocation CreateNew(double x, double y, double z)
        {
            return new Location(x, y, z, precision);
        }

        /// <summary>
        /// Возвращает новый экземпляр <see cref="ILocation"/> с заданными координатами.
        /// </summary>
        /// <param name="location">Координаты 3D-точки / вектора.</param>
        /// <returns>Новый экземпляр <see cref="ILocation"/>.</returns>
        public ILocation CreateNew(ILocation location)
        {
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location), "Не заданы координаты 3D-точки / вектора.");
            }

            return CreateNew(location.X, location.Y, location.Z);
        }

        #endregion

        #region Переопределенные методы и операторы

        public override bool Equals(object obj)
        {
            return !(obj is Location compareWith) ? false
                : X.Equals(compareWith.X, precision) && Y.Equals(compareWith.Y, precision) && Z.Equals(compareWith.Z, precision);
        }

        public static bool operator ==(Location left, object right) => left.Equals(right);
        public static bool operator !=(Location left, object right) => !left.Equals(right);

        public override int GetHashCode()
        {
            var hash = 19;

            hash = hash * 37 + X.GetHashCode();
            hash = hash * 37 + Y.GetHashCode();
            hash = hash * 37 + Z.GetHashCode();

            return hash;
        }

        #endregion
    }
}
