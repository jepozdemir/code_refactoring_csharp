namespace CSharp.Tutorials.CodeRefactoring.Samples
{
	class Triangle : ShapeBase
    {
        private double BaseLength { get; }
        private double Height { get; }
        private double Side { get; }

        public Triangle(double baseLength, double height, double side)
        {
            BaseLength = baseLength;
            Height = height;
            Side = side;
        }

        public override double CalculateArea()
        {
            double s = (BaseLength + Height + Side) / 2;
            return Math.Sqrt(s * (s - BaseLength) * (s - Height) * (s - Side));
        }
    }
}
