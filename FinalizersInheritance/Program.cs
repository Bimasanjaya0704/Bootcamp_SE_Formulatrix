
class Foundation
{
	~Foundation()
	{
		Console.WriteLine("Foundation destructed");
	}
}

class House : Foundation
{
	~House()
	{
		Console.WriteLine("House destructed");
	}
}
class Roof : House
{
	~Roof()
	{
		Console.WriteLine("Roof destructed");
	}
}

public class Program
{
	static void Main()
	{
		createInctance();
		GC.Collect();
		GC.WaitForPendingFinalizers();
	}

	static void createInctance()
	{
		Roof roof = new();
	}
}