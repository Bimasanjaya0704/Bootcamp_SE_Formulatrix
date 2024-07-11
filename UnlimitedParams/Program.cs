class Program
{
	static void Main()
	{
		CalculatorParams calculator = new();
		int result = calculator.Add(2, 3, 5, 7, 9, 4, 3, 8, 90);
		Console.WriteLine(result);
		int resultSub = calculator.Substraction(2, 3, 5, 7, 9, 4, 3, 8, 90);
		Console.WriteLine(resultSub);
		int resultMul = calculator.Multiple(2, 3, 5, 7, 9, 4, 3, 8, 90);
		Console.WriteLine(resultMul);
	}
}