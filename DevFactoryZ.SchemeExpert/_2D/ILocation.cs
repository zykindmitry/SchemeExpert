namespace DevFactoryZ.SchemeExpert._2D
{
    public interface ILocation
    {
        /// <summary>
        /// Значение координаты 2D-точки / вектора по оси <see cref="X"/>.
        /// </summary>
        double X { get; }

        /// <summary>
        /// Значение координаты 2D-точки / вектора по оси <see cref="Y"/>.
        /// </summary>
        double Y { get; }

        /// <summary>
        /// Возвращает новый экземпляр <see cref="ILocation"/>, суммируя заданные значения координат вектора перемещения с координатами текущего экземпляра <see cref="ILocation"/>.
        /// Точность сравнения значений координат берется из текущего экземпляра <see cref="ILocation"/>.
        /// </summary>
        /// <param name="x">Координата вектора перемещения по оси <see cref="X"/>.</param>
        /// <param name="y">Координата вектора перемещения по оси <see cref="Y"/>.</param>
        /// <returns>Новый экземпляр <see cref="ILocation"/>.</returns>
        ILocation CreateByAdding(double x, double y);

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
        /// <returns>Новый экземпляр <see cref="ILocation"/>.</returns>
        ILocation CreateNew(double x, double y);

        /// <summary>
        /// Возвращает новый экземпляр <see cref="ILocation"/> с заданными координатами.
        /// </summary>
        /// <param name="location">Координаты 3D-точки / вектора.</param>
        /// <returns>Новый экземпляр <see cref="ILocation"/>.</returns>
        ILocation CreateNew(ILocation location);
    }
}
