using CSharp.Tutorials.CodeRefactoring;
using CSharp.Tutorials.CodeRefactoring.DesignPatterns;
using CSharp.Tutorials.CodeRefactoring.Samples;
using ExtractMethod = CSharp.Tutorials.CodeRefactoring.ExtractMethod;
class Program
{
	static void Main(string[] args)
	{
		ProcessOrder();
		CalculateAreas();
	}

	static void ProcessOrder()
	{
		var order = OrderService.GetOrder();

		OrderService.ProcessOrder(order);

		ExtractMethod.ProcessOrder(order);
	}

	static void CalculateAreas()
	{
		ShapeService.CalculateAreas();

		EliminateCodeDuplication.Run();
		UseOOP.Run();
		FactoryPattern.Run();
		StrategyPattern.Run();
	}
}


