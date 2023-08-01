namespace SimpleGeometryLibrary.Figures
{
    /// <summary>
    /// Geometric figure: Circle
    /// </summary>
    public class Circle : IFigure
    {
        public double Radius { get; set; }
        /// <summary>
        /// Circle constructor
        /// </summary>
        /// <param name="radius">Circle radius</param>
        /// <exception cref="ArgumentException"></exception>
        public Circle(double radius)
        {
            if(radius <= 0)
            {
                throw new ArgumentException("Circle radius must be positive number.");
            }
            Radius = radius;
        }
        /// <summary>
        /// Calculate circle area
        /// </summary>
        /// <returns>Triangle area</returns>
        public double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
        /// <summary>
        /// Calculate cirle perimeter (circle length)
        /// </summary>
        /// <returns>Triangle area</returns>
        public double GetPerimeter()
        {
            return 2 * Math.PI * Radius;
        }
    }
}
