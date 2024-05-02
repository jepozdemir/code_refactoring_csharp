using CSharp.Tutorials.CodeRefactoring.Samples;

namespace CSharp.Tutorials.CodeRefactoring.DesignPatterns
{
	class FactoryPattern
	{
		public static void Run()
		{
			ShapeFactory factory = new ShapeFactory();
			Console.WriteLine("Calculating areas by using Factory Pattern");
			ShapeBase rectangle = factory.CreateShape(ShapeType.Rectangle, 5, 10);
			Console.WriteLine("Area of rectangle: " + rectangle.CalculateArea());

			ShapeBase circle = factory.CreateShape(ShapeType.Circle, 7);
			Console.WriteLine("Area of circle: " + circle.CalculateArea());

			ShapeBase triangle = factory.CreateShape(ShapeType.Triangle, 3, 4, 5);
			Console.WriteLine("Area of triangle: " + triangle.CalculateArea());
		}

		class ShapeFactory
		{
			public ShapeBase CreateShape(ShapeType type, params double[] dimensions)
			{
				switch (type)
				{
					case ShapeType.Rectangle:
						if (dimensions.Length != 2)
							throw new ArgumentException("Invalid dimensions for rectangle.");
						return new Rectangle(dimensions[0], dimensions[1]);
					case ShapeType.Circle:
						if (dimensions.Length != 1)
							throw new ArgumentException("Invalid dimensions for circle.");
						return new Circle(dimensions[0]);
					case ShapeType.Triangle:
						if (dimensions.Length != 3)
							throw new ArgumentException("Invalid dimensions for triangle.");
						return new Triangle(dimensions[0], dimensions[1], dimensions[2]);
					default:
						throw new ArgumentException("Invalid shape specified.");
				}
			}
		}
	}
}
