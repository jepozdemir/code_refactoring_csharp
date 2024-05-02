namespace CSharp.Tutorials.CodeRefactoring.Samples
{
	class Rectangle : ShapeBase
    {
        private double Length { get; }
        private double Width { get; }

        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public override double CalculateArea()
        {
            return Length * Width;
        }
    }
}
