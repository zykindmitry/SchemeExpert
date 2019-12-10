using System;

namespace DevFactoryZ.SchemeExpert._3D
{
    /// <summary>
    /// Этот класс представляет точку / вектор в 3-х мерном пространстве.
    /// Оповещает об изменении любой из координат при подписке на событие <see cref="PointMoved"/>. 
    /// </summary>
    public class Point : IPoint
    {
        #region .ctor

        /// <summary>
        /// Создает экземпляр <see cref="Point"/> с заданными координатами.
        /// </summary>
        /// <param name="x">Координата 3D-точки / вектора по оси X.</param>
        /// <param name="y">Координата 3D-точки / вектора по оси Y.</param>
        /// <param name="z">Координата 3D-точки / вектора по оси Z.</param>
        /// <param name="precision">Количество знаков после запятой, участвующих в сравнении значений двух координат.</param>
        public Point(double x, double y, double z, uint precision)
            : this(new Location(x, y, z, precision))
        {

        }

        /// <summary>
        /// Создает экземпляр <see cref="Point"/> с заданными координатами.
        /// </summary>
        /// <param name="location">Координаты создаваемого экземпляра <see cref="Point"/></param>
        public Point(ILocation location)
        {
            MoveTo(location);
        }

        #endregion

        #region Текущие координаты 3D-точки / вектора

        /// <summary>
        /// Текущие координаты 3D-точки / вектора, а также параметр, определяющий точность сравнения значений координат - 
        /// количество знаков после запятой, участвующих в сравнении значений двух координат.
        /// </summary>
        public ILocation Location { get; private set; }

        #endregion

        #region Методы изменения значений координат

        /// <summary>
        /// Установка нового значения координат 3D-точки / вектора.
        /// </summary>
        /// <param name="newValueX">Новое значение координаты 3D-точки / вектора по оси <see cref="X"/>.</param>
        /// <param name="newValueY">Новое значение координаты 3D-точки / вектора по оси <see cref="Y"/>.</param>
        /// <param name="newValueZ">Новое значение координаты 3D-точки / вектора по оси <see cref="Z"/>.</param>
        public void MoveTo(double newValueX, double newValueY, double newValueZ)
        {
            MoveTo(Location.CreateNew(newValueX, newValueY, newValueZ));
        }

        /// <summary>
        /// Установка нового значения координат 3D-точки / вектора.
        /// </summary>
        /// <param name="newLocation">Новые координаты 3D-точки / вектора.</param>
        public void MoveTo(ILocation newLocation)
        {
            var previous = Location as Location; // Приводим к Location, чтобы использовать переопределенные операторы ==, !=.

            Location = newLocation ?? throw new ArgumentNullException(nameof(newLocation), "Не заданы координаты 3D-точки / вектора.");

            // Если это НЕ новый объект Point, и новый Location НЕ равен старому, то генерим событие PointMoved.
            if (previous != null && (Location as Location) != previous)
            {
                OnPointMoved(previous, Location);
            }
        }

        /// <summary>
        /// Перемещение 3D-точки по заданному вектору.
        /// </summary>
        /// <param name="vector">Вектор перемещения 3D-точки.</param>
        public void Move(ILocation vector)
        {
            MoveTo(Location.CreateByAdding(vector));
        }

        #endregion

        #region PointMoved implementation

        public event EventHandler<LocationChangedEventArgs> PointMoved;

        /// <summary>
        /// Метод для генерации события <see cref="PointMoved"/>.
        /// </summary>
        /// <param name="previous">Информация о предыдущем (старом) значении координат 3D-точки / вектора.</param>
        /// <param name="current">Информация о текущем (новом) значении координат 3D-точки / вектора.</param>
        protected virtual void OnPointMoved(ILocation previous, ILocation current)
        {
            PointMoved?.Invoke(this, new LocationChangedEventArgs(previous, current));
        }

        #endregion
    }

}
