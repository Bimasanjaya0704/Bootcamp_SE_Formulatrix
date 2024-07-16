
public class Program
{
	static void Main()
	{
		Calculator<int> calc = new Calculator<int>();
		int result = calc.Add(4, 5);
		Console.WriteLine(result);
	}
}
