using SimpleGeometryLibrary.Enums;

namespace SimpleGeometryLibrary.Figures
{
    /// <summary>
    /// Geometric figure: Circle
    /// </summary>
    public class Triangle : IFigure
    {
        public double A { get; }
        public double B { get; }
        public double C { get; }

        public TriangleType Type { get; }

        /// <summary>
        /// Triangle constructor
        /// </summary>
        /// <param name="a">First side</param>
        /// <param name="b">Second side</param>
        /// <param name="c">Third side</param>
        /// <exception cref="ArgumentException"></exception>
        public Triangle(double a, double b, double c) {
            if(!IsValidTriangle(a, b, c))
            {
                throw new ArgumentException("Triangle with such sides cannot exist.");
            }
            A = a;
            B = b; 
            C = c;
            Type = GetTriangleType();
        }
        
        /// <summary>
        /// Calculate triangle area
        /// </summary>
        /// <returns>Triangle area</returns>
        public double GetArea()
        {
            double halfP = GetPerimeter() / 2;
            return Math.Sqrt(halfP * (halfP - A) * (halfP - B) * (halfP - C));
        }

        /// <summary>
        /// Calculate triangle perimeter
        /// </summary>
        /// <returns>Triangle perimeter</returns>
        public double GetPerimeter()
        {
            return A + B + C;
        }

        /// <summary>
        /// Check if triangle with such sides can exist
        /// </summary>
        /// <param name="a">First side</param>
        /// <param name="b">Second side</param>
        /// <param name="c">Third side</param>
        /// <returns></returns>
        private bool IsValidTriangle(double a, double b, double c)
        {
            if(a <= 0 || b <= 0 || c <= 0)
            {
                return false;
            }
            if(a + b <= c)
            {
                return false;
            } 
            else if (a + c <= b)
            {
                return false;
            }
            else if (b + c <= a)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Define triangle type by three sides
        /// </summary>
        /// <returns>Triangle type</returns>
        private TriangleType GetTriangleType()
        {
            if(A == B && B == C)
            {
                return TriangleType.Equilateral;
            }
            if ((A * A + B * B == C * C) || (A * A + C * C == B * B) || (C * C + B * B == A * A))
            {
                return TriangleType.Right;
            }
            return TriangleType.Basic;
        }
    }
}
