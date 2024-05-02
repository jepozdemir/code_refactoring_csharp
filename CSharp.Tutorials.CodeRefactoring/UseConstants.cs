namespace CSharp.Tutorials.CodeRefactoring
{
	class UseConstants
	{
		// Before refactoring
		public double CalculateCircleArea(double radius)
		{
			return 3.14 * radius * radius;
		}

		// After refactoring
		private const double Pi = 3.14;
		public double CalculateCircleArea_Better(double radius)
		{
			return Pi * radius * radius;
		}
	}
}
