public class Car
{
	public Car()
	{
		Console.WriteLine($"Car Created save in Gen {GC.GetGeneration(this)}!!");
	}
	~Car()
	{
		Console.WriteLine($"Car Destructed save Gen {GC.GetGeneration(this)}!!");
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
		Car car = new();
	}
}