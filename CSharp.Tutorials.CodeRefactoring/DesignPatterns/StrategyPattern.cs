using CSharp.Tutorials.CodeRefactoring.Samples;

namespace CSharp.Tutorials.CodeRefactoring.DesignPatterns
{
	class StrategyPattern
	{
		public static void Run()
		{
			Console.WriteLine("Calculating areas by using Strategy Pattern");

			Shape rectangle = new Shape(new RectangleAreaCalculator(), 5, 10);
			Console.WriteLine("Area of rectangle: " + rectangle.CalculateArea());

			Shape circle = new Shape(new CircleAreaCalculator(), 7);
			Console.WriteLine("Area of circle: " + circle.CalculateArea());

			Shape triangle = new Shape(new TriangleAreaCalculator(), 3, 4, 5);
			Console.WriteLine("Area of triangle: " + triangle.CalculateArea());
		}

		interface IAreaCalculator
		{
			double CalculateArea(params double[] dimensions);
		}

		class RectangleAreaCalculator : IAreaCalculator
		{
			public double CalculateArea(params double[] dimensions)
			{
				if (dimensions.Length != 2)
					throw new ArgumentException("Invalid dimensions for rectangle.");
				return dimensions[0] * dimensions[1];
			}
		}

		class CircleAreaCalculator : IAreaCalculator
		{
			public double CalculateArea(params double[] dimensions)
			{
				if (dimensions.Length != 1)
					throw new ArgumentException("Invalid dimensions for circle.");
				return Math.PI * dimensions[0] * dimensions[0];
			}
		}

		class TriangleAreaCalculator : IAreaCalculator
		{
			public double CalculateArea(params double[] dimensions)
			{
				if (dimensions.Length != 3)
					throw new ArgumentException("Invalid dimensions for triangle.");
				double s = (dimensions[0] + dimensions[1] + dimensions[2]) / 2;
				return Math.Sqrt(s * (s - dimensions[0]) * (s - dimensions[1]) * (s - dimensions[2]));
			}
		}

		class Shape : ShapeBase
		{
			private readonly IAreaCalculator _areaCalculator;
			private readonly double[] _dimensions;

			public Shape(IAreaCalculator areaCalculator, params double[] dimensions)
			{
				_areaCalculator = areaCalculator;
				_dimensions = dimensions;
			}

			public override double CalculateArea()
			{
				return _areaCalculator.CalculateArea(_dimensions);
			}
		}
	}
}
