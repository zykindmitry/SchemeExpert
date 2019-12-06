using DevFactoryZ.SchemeExpert;

namespace System.ComponentModel
{
    /// <summary>
    /// Расширение класса <see cref="EventArgs"/> 
    /// для получение информации о предыдущем (старом) и текущем (новом) значении координат 3D-точки / вектора.
    /// </summary>
    public class LocationChangedEventArgs : EventArgs
    {
        #region .ctor

        /// <summary>
        /// Создает экземпляр <see cref="LocationChangedEventArgs"/> с заданными значениями аргументов.
        /// </summary>
        /// <param name="previous">Информация о предыдущем (старом) значении координат 3D-точки / вектора.</param>
        /// <param name="current">Информация о текущем (новом) значении координат 3D-точки / вектора.</param>
        public LocationChangedEventArgs(ILocation previous, ILocation current)
        {
            Previous = previous;
            Current = current;
        }

        #endregion

        /// <summary>
        /// Информация о текущем (новом) значении координат 3D-точки / вектора.
        /// </summary>
        public ILocation Current { get; }

        /// <summary>
        /// Информация о предыдущем (старом) значении координат 3D-точки / вектора.
        /// </summary>
        public ILocation Previous { get; }
    }
}
