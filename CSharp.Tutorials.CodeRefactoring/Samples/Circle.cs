namespace CSharp.Tutorials.CodeRefactoring.Samples
{
	class Circle : ShapeBase
    {
        private double Radius { get; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
