using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using DevFactoryZ.SchemeExpert._3D;

namespace System.ComponentModel
{
    /// <summary>
    /// Расширение класса <see cref="EventArgs"/> 
    /// для получение информации о предыдущем и текущем (новом) значении координат 3D-точки / вектора.
    /// </summary>
    public class PointChangedEventArgs : EventArgs
    {
        #region .ctor

        /// <summary>
        /// Создает экземпляр <see cref="PointChangedEventArgs"/> с заданными значениями аргументов.
        /// </summary>
        /// <param name="point">Информация о предыдущем и текущем (новом) значении координат 3D-точки / вектора.</param>
        public PointChangedEventArgs(IPoint point)
        {
            Point = point;
        }

        #endregion

        /// <summary>
        /// Информация о предыдущем и текущем (новом) значении координат 3D-точки / вектора.
        /// </summary>
        public IPoint Point { get; }
    }
}
