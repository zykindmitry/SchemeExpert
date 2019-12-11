using System;
using System.Collections.Generic;
using System.Text;

namespace DevFactoryZ.SchemeExpert.Volume
{
    /// <summary>
    /// Класс, описывающий объект Angle.
    /// </summary>
    /// Имеет свойства: 
    ///     Degree <see cref="Dergee"/> - величина угла в градусах.
    ///     Radians <see cref="Radians"/> - величина угла в радианах.
    public class Angle
    {
        public double Dergee { get; private set; }
        public double Radians { get; private set; }

        #region .ctor

        private Angle()
        {
        }

        /// <summary>
        /// Статический метод, позволяющий создать объект Angle, имеющий указанную величину в градусах и преобразующий ее в радианы.
        /// </summary>
        /// <param name="degree"></param>
        /// <returns></returns>
        public static Angle FromDegrees(double degree)
        {
            Angle angle = new Angle();
            angle.Dergee = degree;
            angle.Radians = Math.PI / 180.0 * degree;
            return angle;
        }

        /// <summary>
        /// Статический метод, позволяющий создать объект Angle, имеющий указанную величину в радианах и преобразующий ее в градусы.
        /// </summary>
        /// <param name="radians"></param>
        /// <returns></returns>
        public static Angle FromRadians(double radians)
        {
            Angle angle = new Angle();
            angle.Radians = radians;
            angle.Dergee = 180.0 / Math.PI * radians;
            return angle;
        }

        #endregion
    }
}
