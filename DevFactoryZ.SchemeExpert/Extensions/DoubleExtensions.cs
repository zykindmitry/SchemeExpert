using System;

namespace DevFactoryZ.SchemeExpert.Extensions
{
    public static class DoubleExtensions
    {
        /// <summary>
        /// Сравнение двух значений типа <see cref="double"/> с учетом количества значимых для сравнения знаков после запятой.
        /// Значения считаются равными, если модуль их разности меньше или равен 10^(-precision).
        /// </summary>
        /// <param name="forCompare">Первое значение для сравнения.</param>
        /// <param name="compareWith">Второе значение для сравнения.</param>
        /// <param name="precision">Точность сравнения - количество знаков после запятой, участвующих в сравнении.</param>
        /// <returns></returns>
        public static bool Equals(this double forCompare, double compareWith, uint precision)
        {
            return Math.Abs(forCompare - compareWith) <= Math.Pow(10, -precision);
        }
    }
}
