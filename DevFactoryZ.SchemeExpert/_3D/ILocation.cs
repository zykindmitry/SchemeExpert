namespace DevFactoryZ.SchemeExpert._3D
{
    /// <summary>
    /// Определяет координаты 3D-точки / вектора,
    /// а также параметр, определяющий точность сравнения значений координат - 
    /// количество знаков после запятой, участвующих в сравнении значений двух координат.
    /// </summary>
    public interface ILocation
    {
        /// <summary>
        /// Значение координаты 3D-точки / вектора по оси <see cref="X"/>.
        /// </summary>
        double X { get; }

        /// <summary>
        /// Значение координаты 3D-точки / вектора по оси <see cref="Y"/>.
        /// </summary>
        double Y { get; }

        /// <summary>
        /// Значение координаты 3D-точки / вектора по оси <see cref="Z"/>.
        /// </summary>
        double Z { get; }

        /// <summary>
        /// Возвращает новый экземпляр <see cref="ILocation"/>, суммируя заданные значения координат вектора перемещения с координатами текущего экземпляра <see cref="ILocation"/>.
        /// Точность сравнения значений координат берется из текущего экземпляра <see cref="ILocation"/>.
        /// </summary>
        /// <param name="x">Координата вектора перемещения по оси <see cref="X"/>.</param>
        /// <param name="y">Координата вектора перемещения по оси <see cref="Y"/>.</param>
        /// <param name="z">Координата вектора перемещения по оси <see cref="Z"/>.</param>
        /// <returns>Новый экземпляр <see cref="ILocation"/>.</returns>
        ILocation CreateByAdding(double x, double y, double z);

        /// <summary>
        /// Возвращает новый экземпляр <see cref="ILocation"/>, суммируя значения координат заданного вектора перемещения с координатами текущего экземпляра <see cref="ILocation"/>.
        /// Точность сравнения значений координат берется из текущего экземпляра <see cref="ILocation"/>.
        /// </summary>
        /// <param name="vector">Вектор перемещения 3D-точки.</param>
        /// <returns>Новый экземпляр <see cref="ILocation"/>.</returns>
        ILocation CreateByAdding(ILocation vector);

        /// <summary>
        /// Возвращает новый экземпляр <see cref="ILocation"/> с заданными координатами.
        /// </summary>
        /// <param name="x">Координата 3D-точки / вектора по оси <see cref="X"/>.</param>
        /// <param name="y">Координата 3D-точки / вектора по оси <see cref="Y"/>.</param>
        /// <param name="z">Координата 3D-точки / вектора по оси <see cref="Z"/>.</param>
        /// <returns>Новый экземпляр <see cref="ILocation"/>.</returns>
        ILocation CreateNew(double x, double y, double z);

        /// <summary>
        /// Возвращает новый экземпляр <see cref="ILocation"/> с заданными координатами.
        /// </summary>
        /// <param name="location">Координаты 3D-точки / вектора.</param>
        /// <returns>Новый экземпляр <see cref="ILocation"/>.</returns>
        ILocation CreateNew(ILocation location);

    }
}
