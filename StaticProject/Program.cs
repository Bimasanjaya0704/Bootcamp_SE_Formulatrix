using System.Reflection;

public class Program
{
	static void Main()
	{
		Car car = new Car();
		Console.WriteLine(car.prodNumber);
		Console.WriteLine(Car.id);
		Console.WriteLine(Car.colour);

		Car car2 = new();
		Console.WriteLine(car2.prodNumber);
		Console.WriteLine(Car.id);
		Console.WriteLine(Car.colour);

		Car car3 = new Car();
		Console.WriteLine(car3.prodNumber);
		Console.WriteLine(Car.id);
		Console.WriteLine(Car.colour);

		Car car4 = new();
		Console.WriteLine(car4.prodNumber);
		Console.WriteLine(Car.id);
		Console.WriteLine(Car.colour);
	}
}

public class Car
{
	public int prodNumber = 0;
	public static int id;
	public static string colour;
	public Car()
	{
		id++;
		prodNumber = id;
		if (id % 2 != 0)
		{
			colour = "Pink";
		}
		else
		{
			colour = "yellow";
		}
	}
}
