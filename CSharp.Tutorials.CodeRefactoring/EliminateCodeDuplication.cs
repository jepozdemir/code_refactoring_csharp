namespace CSharp.Tutorials.CodeRefactoring
{
	class EliminateCodeDuplication
	{
		public static void Run()
		{
			Console.WriteLine("Calculating areas by single method...");

			// Calculate the area of a rectangle
			double rectangleArea = CalculateArea(ShapeType.Rectangle, 5, 10);
			Console.WriteLine("Area of rectangle: " + rectangleArea);

			// Calculate the area of a circle
			double circleArea = CalculateArea(ShapeType.Circle, 7);
			Console.WriteLine("Area of circle: " + circleArea);

			// Calculate the area of a triangle
			double triangleArea = CalculateArea(ShapeType.Triangle, 3, 4, 5);
			Console.WriteLine("Area of triangle: " + triangleArea);
		}

		// Method to calculate the area of various shapes
		static double CalculateArea(ShapeType shape, params double[] dimensions)
		{
			switch (shape)
			{
				case ShapeType.Rectangle:
					return dimensions[0] * dimensions[1];
				case ShapeType.Circle:
					return Math.PI * dimensions[0] * dimensions[0];
				case ShapeType.Triangle:
					double s = (dimensions[0] + dimensions[1] + dimensions[2]) / 2;
					return Math.Sqrt(s * (s - dimensions[0]) * (s - dimensions[1]) * (s - dimensions[2]));
				default:
					throw new ArgumentException("Invalid shape specified");
			}
		}
	}
}
