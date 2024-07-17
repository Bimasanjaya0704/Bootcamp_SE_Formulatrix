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
		// int result = myDel.Invoke(10, 5);
		// Console.WriteLine(result);

		int[] result = new int[4];
		Delegate[] invocationList = myDel.GetInvocationList();

		int count = 0;
		foreach (MyDelegates method in invocationList)
		{
			result[0] = method.Invoke(10, 5);
			count++;
		}
		foreach (var i in result)
		{
			Console.WriteLine(i);
		}
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