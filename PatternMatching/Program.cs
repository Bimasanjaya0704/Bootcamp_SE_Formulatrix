public class Program
{
	static void Main()
	{
		int a = 12;
		int b = 22;
		string sa = "Bima";
		string sb = " Sanjaya";
		Calculator calculator = new();
		int resultInt = (int)calculator.Add(a, b);
		Console.WriteLine("Hasil result int " + resultInt);
		string resultString = (string)calculator.Add(sa, sb);
		Console.WriteLine("Hasil result string " + resultString);
	}
}

public class Calculator
{
	public object Add(object a, object b)
	{
		if (a is int c && b is int d)
		{
			return c + d;
		}
		if (a is string e && b is string f)
		{
			return e + f;
		}
		return null;
	}
}