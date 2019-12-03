using System;
using System.Collections.Generic;
using System.Text;

namespace DevFactoryZ.SchemeExpert.Volume
{
    /// <summary>
    /// Интерфейс, описывающий координаты точки.
    /// </summary>
    public interface ICoordinate
    {
        double X { get; }
        double Y { get; }
    }
}
