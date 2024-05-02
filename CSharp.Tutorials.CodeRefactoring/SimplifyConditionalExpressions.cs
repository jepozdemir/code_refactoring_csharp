namespace CSharp.Tutorials.CodeRefactoring
{
	class SimplifyConditionalExpressions
	{
		// Before refactoring
		public string GetWeatherForecast(int temperature)
		{
			if (temperature > 30)
			{
				return "Hot";
			}
			else
			{
				return "Mild";
			}
		}

		// After refactoring
		public string GetWeatherForecast_Better(int temperature)
		{
			return temperature > 30 ? "Hot" : "Mild";
		}
	}
}
