public class Car
{
	public Car()
	{
		Console.WriteLine($"Car Created save in Gen {GC.GetGeneration(this)}!!");
	}
	~Car()
	{
		Console.WriteLine($"Car Destructed save Genato {GC.GetGeneration(this)}!!");
	}
}

public class Program
{
	static void Main()
	{
		createInctance();
		GC.Collect();
	}

	static void createInctance()
	{
		Car car = new();
	}
}