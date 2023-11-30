namespace TriangleLibrary
{
    public static class Triangle
    {
        /// <summary>
        /// 0 - invalid
        /// 1- right
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
                return 0;
            }



            return 1;
        }
    }
}
