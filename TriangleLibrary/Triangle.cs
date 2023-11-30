using System;
using System.Collections.Generic;
using System.Linq;

namespace TriangleLibrary
{
    public static class Triangle
    {
        /// <summary>
        /// 0 - invalid
        /// 1 - right
        /// 2 - acute
        /// 3 - obtuse
        /// </summary>
        /// <param name="side1"></param>
        /// <param name="side2"></param>
        /// <param name="side3"></param>
        /// <returns></returns>
        public static int GetTriangleType(double side1, double side2, double side3)
        {
            if (side1 <= 0 || 
                side2 <= 0 || 
                side3 <= 0 || 
                side1 + side2 <= side3 || 
                side1 + side3 <= side2 || 
                side2 + side3 <= side1)
            {
                return 0; // треугольник не существует
            }

            try
            {
                double[] sideSquares = new double[3] { Math.Pow(side1, 2), Math.Pow(side2, 2), Math.Pow(side3, 2) };
                Array.Sort(sideSquares);

                if (sideSquares[2] < sideSquares[0] + sideSquares[1])
                {
                    return 2; // остроугольный треугольник
                }

                if (sideSquares[2] > sideSquares[0] + sideSquares[1])
                {
                    return 3; // тупоугольный треугольник
                }

                return 1; // прямоугольный треугольник
            }
            catch(OverflowException ex)
            {
                return 0;
            }
        }
    }
}
