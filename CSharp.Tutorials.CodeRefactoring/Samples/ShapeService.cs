namespace CSharp.Tutorials.CodeRefactoring.Samples
{
    class ShapeService
    {
        public static void CalculateAreas()
        {
			Console.WriteLine("Calculating areas before refactoring...");

			double rectangleArea = CalculateRectangleArea(5, 10);
            Console.WriteLine("Area of rectangle: " + rectangleArea);

            double circleArea = CalculateCircleArea(7);
            Console.WriteLine("Area of circle: " + circleArea);

            double triangleArea = CalculateTriangleArea(3, 4, 5);
            Console.WriteLine("Area of triangle: " + triangleArea);
        }

        static double CalculateRectangleArea(double length, double width)
        {
            return length * width;
        }

        static double CalculateCircleArea(double radius)
        {
            return Math.PI * radius * radius;
        }

        static double CalculateTriangleArea(double baseLength, double height, double side)
        {
            double s = (baseLength + height + side) / 2;
            return Math.Sqrt(s * (s - baseLength) * (s - height) * (s - side));
        }
    }
}
