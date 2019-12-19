using System;
using DevFactoryZ.SchemeExpert.Extensions;

namespace DevFactoryZ.SchemeExpert._2D
{
    /// <summary>
    /// Класс, реализующий интерфейс <see cref="IPoint"/>.
    /// Описывает 2D-точку на оси координат.
    /// </summary>
    public class Point : IPoint
    {
        public double X { get; private set; }
        public double Y { get; private set; }

        #region .ctor
        public Point(double x, double y, uint precision)
        {
            X = x;
            Y = y;
            this.precision = precision;

        }

        public Point(uint precision)
        {
            this.precision = precision;
        }

        #endregion

        #region Методы воздействия на координаты точки.

        /// <summary>
        /// Смещение точки на вектор.
        /// </summary>
        /// <param name="vector"></param>
        internal void Move(IPoint vector)
        {
            var previous = this;
            if (previous != (Point)vector)
            {
                (X, Y) = (vector.X, vector.Y);
                PointChangedEventArgs e = new PointChangedEventArgs((ICoordinate)previous, (ICoordinate)vector);
                OnPointChangedEvent(e);
            }
        }

        /// <summary>
        /// Поворот точки вокруг цента на заданный угол.
        /// </summary>
        /// <param name="center"></param>
        /// <param name="angle"></param>
        internal void Rotate(IPoint center, Angle angle) 
        {
            var previous = this;
            X = (X - center.X) * Math.Cos(angle.Radians) - (Y - center.Y) * Math.Sin(angle.Radians);
            Y = (Y - center.Y) * Math.Sin(angle.Radians) + (X - center.X) * Math.Cos(angle.Radians);
            if (previous != this)
            {
                PointChangedEventArgs e = new PointChangedEventArgs((ICoordinate)previous, (ICoordinate)this);
                OnPointChangedEvent(e);
            }
        }

        #endregion

        #region Событие на изменение точки координат.

        public event EventHandler<PointChangedEventArgs> PointLocationChanged;
        protected virtual void OnPointChangedEvent(PointChangedEventArgs e)
        {
            PointLocationChanged?.Invoke(this, e);
        }

        #endregion

        #region Переопределенные методы

        /// <summary>
        /// Количество знаков после запятой. Введена для переопределения метода Equals.
        /// </summary>
        readonly uint precision;
        public override bool Equals(object obj)
        {
            return !(obj is Point pointToCompare) ? false : X.Equals(pointToCompare.X, precision) && Y.Equals(pointToCompare.Y, precision);
        }
        public static bool operator ==(Point left, object right) => left.Equals(right);
        public static bool operator !=(Point left, object right) => !left.Equals(right);
        public override int GetHashCode()
        {
            var hash = 19;

            hash = hash * 37 + X.GetHashCode();
            hash = hash * 37 + Y.GetHashCode();

            return hash;
        }

        #endregion

    }
}
