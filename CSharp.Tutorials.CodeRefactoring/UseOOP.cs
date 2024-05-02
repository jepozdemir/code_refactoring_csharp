using CSharp.Tutorials.CodeRefactoring.Samples;

namespace CSharp.Tutorials.CodeRefactoring
{
    class UseOOP
	{
        public static void Run()
        {
			Console.WriteLine("Calculating areas by using Object Oriented Principles...");

			Rectangle rectangle = new Rectangle(5, 10);
            Console.WriteLine("Area of rectangle: " + rectangle.CalculateArea());

            Circle circle = new Circle(7);
            Console.WriteLine("Area of circle: " + circle.CalculateArea());

            Triangle triangle = new Triangle(3, 4, 5);
            Console.WriteLine("Area of triangle: " + triangle.CalculateArea());
        }
    }
}
