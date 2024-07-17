public delegate int MyDelegates(int a, int b);
public class Program
{
	static void Main()
	{
		Calculator calc = new();
		MyDelegates myDel = calc.Add;
		myDel = calc.Subs;
		myDel = calc.Div;
		myDel = calc.Mul;
		int result = myDel.Invoke(10, 5);
		Console.WriteLine(result);
	}
}

public class Calculator
{
	public int Add(int a, int b)
	{
		return a + b;
	}
	public int Subs(int a, int b)
	{
		return a - b;
	}
	public int Div(int a, int b)
	{
		return a / b;
	}
	public int Mul(int a, int b)
	{
		return a * b;
	}
}