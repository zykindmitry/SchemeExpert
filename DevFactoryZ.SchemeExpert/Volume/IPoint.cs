namespace DevFactoryZ.SchemeExpert.Volume
{
    /// <summary>
    /// Этот интерфейс описывает точку / вектор в 3-х мерном пространстве
    /// </summary>
    interface IPoint
    {
        double X { get; set; }
        double Y { get; set; }
        void PutCoordinates(double X, double Y);
        
        //Событие, которое будет срабатывать при изменении координат точки
        event System.EventHandler PointChanged;

    }
}
