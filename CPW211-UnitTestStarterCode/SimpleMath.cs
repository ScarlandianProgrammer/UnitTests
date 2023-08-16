using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPW211_UnitTestStarterCode
{
    /*****************************************************************************
    * 
    * YOU MAY REFACTOR THE PARAMETER NAMES BUT DO NOT CHANGE THE METHOD SIGNATURES
    * 
    * ***************************************************************************/
    public static class SimpleMath
    {
        /// <summary>
        /// This method takes the two parameters, adds them together,
        /// then returns the sum of both numbers
        /// </summary>
        /// <param name="a">The first addend</param>
        /// <param name="b">The second addend</param>
        /// <returns>The sum of the two addends</returns>
        public static double Add(double a, double b)
        {
            return a + b;
        }

        /// <summary>
        /// This method takes in two parameters, the minuend <paramref name="a"/>,
        /// the subtrahend <paramref name="b"/>, and returns the result
        /// </summary>
        /// <param name="a">The minuend. This number must be greater than
        /// or equal to the subtrahend</param>
        /// <param name="b">The subtrahend. This is the number that will
        /// be taken out of the minuend</param>
        /// <returns>The result of the minuend minus the subtrahend</returns>
        /// <exception cref="ArgumentOutOfRangeException">An exception is thrown if <paramref name="a"/>
        /// is smaller that <paramref name="b"/></exception>
        public static double Subtract(double a, double b)
        {
            if (a < b)
            {
                throw new ArgumentOutOfRangeException();
            } else
            {
                return a - b;
            }
        }

        /// <summary>
        /// This method takes two parameters, multiplies them together,
        /// and returns the result.
        /// </summary>
        /// <param name="a">The multiplicand. The number being multiplied</param>
        /// <param name="b">The multiplier. The number by which the multiplicand is being multiplied</param>
        /// <returns>The result of the multiplicand times the multiplier</returns>
        public static double Multiply(double a, double b)
        {
            return a * b;
        }

        /// <summary>
        /// This method takes two parameters, the dividend <paramref name="a"/>,
        /// and the divisor <paramref name="b"/>, and returns the quotient.
        /// </summary>
        /// <param name="a">The dividend. The number being divided</param>
        /// <param name="b">The divisor. The number by which the dividend is being divided</param>
        /// <returns>The quotient of the dividend divided by the divisor</returns>
        /// <exception cref="ArgumentOutOfRangeException">An exception is thrown if
        /// the divisor is 0</exception>
        public static double Divide(double a, double b)
        {
            if (b == 0)
            {
                throw new ArgumentOutOfRangeException(nameof(b));
            } else
            {
                return a / b;
            }
        }
    }
}
