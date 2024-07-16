public class Program
{
	static void Main()
	{
		Calculator calculator = new Calculator();
		calculator.Addition(4, 5);
		calculator.Addition(40.0f, 15.0f);
		calculator.Addition(4.0, 5.0);
		calculator.Addition(4.01M, 15.01M);
		calculator.Substraction(4, 5);
		calculator.Substraction(40.0f, 15.0f);
		calculator.Substraction(4.0, 5.0);
		calculator.Substraction(4.01M, 15.01M);
		calculator.Division(4, 5);
		calculator.Division(40.0f, 15.0f);
		calculator.Division(4.0, 5.0);
		calculator.Division(4.01M, 15.01M);
		calculator.Multiplication(4, 5);
		calculator.Multiplication(40.0f, 15.0f);
		calculator.Multiplication(4.0, 5.0);
		calculator.Multiplication(4.01M, 15.01M);
		Console.WriteLine($"Addition {calculator.Addition(1, 2)}");
		Console.WriteLine($"Substraction {calculator.Substraction(22, 6)}");
		Console.WriteLine($"Division {calculator.Division(91, 12)}");
		Console.WriteLine($"Multiplication {calculator.Multiplication(21, 92)}");
	}
}