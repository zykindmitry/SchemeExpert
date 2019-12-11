using System;
using System.Collections.Generic;
using System.Text;

namespace DevFactoryZ.SchemeExpert.Volume
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
        public Point(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        public Point()
        {

        }

        #endregion

        #region Методы воздействия на координаты точки.

        /// <summary>
        /// Смещение точки на вектор.
        /// </summary>
        /// <param name="vector"></param>
        internal void Move(IPoint vector)
        {
            if ((this.X, this.Y) != (vector.X, vector.Y))
            {
                PointChangedEventArgs e = new PointChangedEventArgs(new Point(vector.X, vector.Y));
                OnPointChangedEvent(e);
                (this.X, this.Y) = (vector.X, vector.Y);
            }
        }

        /// <summary>
        /// Поворот точки вокруг цента на заданный угол.
        /// </summary>
        /// <param name="center"></param>
        /// <param name="angle"></param>
        internal void Rotate(IPoint center, Angle angle) 
        {
            var RotatedPoind = new Point();
            RotatedPoind.X = (this.X - center.X) * Math.Cos(angle.Dergee) - (this.Y - center.Y) * Math.Sin(angle.Dergee);
            RotatedPoind.Y = (this.Y - center.Y) * Math.Sin(angle.Dergee) + (this.X - center.X) * Math.Cos(angle.Dergee);
            if ((RotatedPoind.X, RotatedPoind.Y) != (this.X,this.Y))
            {
                PointChangedEventArgs e = new PointChangedEventArgs(new Point(RotatedPoind.X, RotatedPoind.Y));
                OnPointChangedEvent(e);
                (this.X, this.Y) = (RotatedPoind.X, RotatedPoind.Y);
            }
        }

        #endregion

        #region Событие на изменение точки координат.

        public event EventHandler<PointChangedEventArgs> OnLocationChanged;
        protected virtual void OnPointChangedEvent(PointChangedEventArgs e)
        {
            OnLocationChanged?.Invoke(this, e);
        }

        #endregion
    }
}
