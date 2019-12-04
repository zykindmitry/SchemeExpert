using DevFactoryZ.SchemeExpert._3D;

namespace System.ComponentModel
{
    /// <summary>
    /// Расширение класса <see cref="EventArgs"/> 
    /// для получение информации о предыдущем и текущем (новом) значении координат 3D-точки / вектора.
    /// </summary>
    public class PointCoordinatesChangedEventArgs : EventArgs
    {
        #region .ctor

        /// <summary>
        /// Создает экземпляр <see cref="PointCoordinatesChangedEventArgs"/> с заданными значениями аргументов.
        /// </summary>
        /// <param name="point">Информация о предыдущем и текущем (новом) значении координат 3D-точки / вектора.</param>
        public PointCoordinatesChangedEventArgs(IPoint point)
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
