using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

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
        /// Создает экземпляр <see cref="Point"/> с нулевыми координатами.
        /// </summary>
        public Point()
        {

        }

        /// <summary>
        /// Создает экземпляр <see cref="Point"/> с заданными координатами.
        /// </summary>
        /// <param name="x">Координата по оси X.</param>
        /// <param name="y">Координата по оси Y.</param>
        /// <param name="z">Координата по оси Z.</param>
        public Point(double x, double y, double z)
        {
            MoveTo(x, y, z);
        }

        #endregion

        #region Текущие координаты 3D-точки / вектора

        /// <summary>
        /// Координата 3D-точки / вектора по оси <see cref="X"/>.
        /// </summary>
        public double X { get; private set; }

        /// <summary>
        /// Координата 3D-точки / вектора по оси <see cref="Y"/>.
        /// </summary>
        public double Y { get; private set; }

        /// <summary>
        /// Координата 3D-точки / вектора по оси <see cref="Z"/>.
        /// </summary>
        public double Z { get; private set; }

        #endregion

        #region Предыдущие координаты 3D-точки / вектора

        /// <summary>
        /// Координата 3D-точки / вектора по оси <see cref="X"/>.
        /// </summary>
        public double PreviousX { get; private set; }

        /// <summary>
        /// Координата 3D-точки / вектора по оси <see cref="Y"/>.
        /// </summary>
        public double PreviousY { get; private set; }

        /// <summary>
        /// Координата 3D-точки / вектора по оси <see cref="Z"/>.
        /// </summary>
        public double PreviousZ { get; private set; }

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
            // Сохраняем предыдущие значения координат
            PreviousX = X;
            PreviousY = Y;
            PreviousZ = Z;

            // Если хотя бы одна из координат изменилась - сохраняем новые значения координат и генерируем событие PointMoved
            if (!PreviousX.Equals(newValueX) || !PreviousY.Equals(newValueY) || !PreviousZ.Equals(newValueZ))
            {
                X = newValueX;
                Y = newValueY;
                Z = newValueZ;

                OnPointMoved(this);
            }
        }

        #endregion

        #region PointMoved implementation

        /// <summary>
        /// Событие, наступающее при изменении любой из координат 3D-точки / вектора.
        /// </summary>
        public event EventHandler<PointChangedEventArgs> PointMoved;

        /// <summary>
        /// Метод для генерации события <see cref="PointMoved"/>.
        /// </summary>
        /// <param name="point">Информация о предыдущем и текущем (новом) значении координат точки.</param>
        protected virtual void OnPointMoved(IPoint point)
        {
            var temp = PointMoved;

            temp?.Invoke(this, new PointChangedEventArgs(point));
        }

        #endregion
    }

}
