namespace DevFactoryZ.SchemeExpert._3D
{
    /// <summary>
    /// Этот интерфейс описывает точку / вектор в 3-х мерном пространстве.
    /// </summary>
    public interface IPoint
    {
        /// <summary>
        /// Текущая координата 3D-точки / вектора по оси <see cref="X"/>.
        /// </summary>
        double X { get; }

        /// <summary>
        /// Текущая координата 3D-точки / вектора по оси <see cref="Y"/>.
        /// </summary>
        double Y { get; }

        /// <summary>
        /// Текущая координата 3D-точки / вектора по оси <see cref="Z"/>.
        /// </summary>
        double Z { get; }

        /// <summary>
        /// Предыдущая координата 3D-точки / вектора по оси <see cref="X"/>.
        /// </summary>
        double PreviousX { get; }

        /// <summary>
        /// Предыдущая координата 3D-точки / вектора по оси <see cref="Y"/>.
        /// </summary>
        double PreviousY { get; }

        /// <summary>
        /// Предыдущая координата 3D-точки / вектора по оси <see cref="Z"/>.
        /// </summary>
        double PreviousZ { get; }
    }
}
