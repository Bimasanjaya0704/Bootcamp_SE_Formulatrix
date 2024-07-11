class Program
{
	static void Main()
	{
		Calculator calculator = new();
		int a = 12;
		int b = 45;
		int c = 24;
		float fa = 3.0f;
		float fb = 9.0f;
		float fc = 12.0f;
		string sa = "12";
		string sb = "2";
		string sc = "78";

		int result = calculator.Add(a, b);
		int result2 = calculator.Add(a, b, c);
		int resultSub1 = calculator.Subtraction(a, b);
		int resultSub2 = calculator.Subtraction(a, b, c);
		float resultF = calculator.Add(fa, fb);
		float resultF2 = calculator.Add(fa, fb, fc);
		float resultFSub = calculator.Subtraction(fa, fb);
		float resultFSub2 = calculator.Subtraction(fa, fb, fc);
		string resultS = calculator.Add(sa, sb);
		string resultS2 = calculator.Add(sa, sb, sc);

		Console.WriteLine($"{a} + {b} = {result} //Int");
		Console.WriteLine($"{a} + {b} + {c} = {result2} //Int");
		Console.WriteLine($"{a} - {b} = {resultSub1} //Int");
		Console.WriteLine($"{a} - {b} - {c} = {resultSub2} //Int");
		Console.WriteLine($"{fa} + {fb} = {resultF} //Float");
		Console.WriteLine($"{fa} + {fb} + {fc} = {resultF2} //Float");
		Console.WriteLine($"{fa} - {fb} = {resultFSub} //Float");
		Console.WriteLine($"{fa} - {fb} - {fc} = {resultFSub2} //Float");
		Console.WriteLine($"{sa} + {sb} = {resultS} //String");
		Console.WriteLine($"{sa} + {sb} + {sc} = {resultS2} //String");
	}
}