using SimpleGeometryLibrary.Figures;

namespace SimpleGeometryLibrary
{
    public static class SimpleGeometry
    {
        /// <summary>
        /// Calculate figure area
        /// </summary>
        /// <param name="figure"></param>
        /// <returns>Figure area</returns>
        public static double GetArea(IFigure figure)
        {
            return figure.GetArea();
        }

        /// <summary>
        /// Calculate triangle area
        /// </summary>
        /// <param name="figure"></param>
        /// <returns>Площадь треугольника</returns>
        public static double GetArea(double A, double B, double C)
        {
            try
            {
                return GetArea(new Triangle(A, B, C));
            }
            catch{
                throw;
            }
        }

        /// <summary>
        /// Calculate circle area
        /// </summary>
        /// <param name="figure"></param>
        /// <returns>Площадь круга</returns>
        public static double GetArea(double r)
        {
            try
            {
                return GetArea(new Circle(r));
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Calculate figure perimetr
        /// </summary>
        /// <param name="figure"></param>
        /// <returns></returns>
        public static double GetPerimetr(IFigure figure)
        {
            return figure.GetPerimeter();
        }
    }
}