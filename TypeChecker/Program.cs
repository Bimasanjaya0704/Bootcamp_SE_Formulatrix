public class Program
{
	static void Main()
	{
		int a = 12;
		int b = 22;
		string sa = "Bima";
		string sb = "Sanjaya";
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
		if (a is int && b is int)
		{
			return (int)a + (int)b;
		}
		if (a is string && b is string)
		{
			return (string)a + (string)b;
		}
		return null;
	}
}