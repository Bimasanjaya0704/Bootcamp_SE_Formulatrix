using BicycleBody;
using BicycleComponents;
class Program
{
	static void Main()
	{
		// create object
		Lamp lamp = new Lamp("NEON", "Yellow", 240, 1000);
		Tire tire = new Tire("Phantom", "Green", 45, 50000, "Summer tires", true);
		Bell bell = new Bell("Kring", "yellow", 9000, 5, "Square", "Plastic");
		Bicycle bicycle = new Bicycle(lamp, tire, bell);

		// Lamp
		bicycle.lamp = lamp;
		Console.WriteLine("Lamp Brand : " + bicycle.lamp.brand);
		Console.WriteLine("Lamp colour : " + bicycle.lamp.colour);
		Console.WriteLine("Lamp Watt : " + bicycle.lamp.watt);
		Console.WriteLine("Lamp Price : " + bicycle.lamp.price);
		bicycle.lamp.Start();

		Lamp lamp2 = new Lamp("Philips", "Red", 300, 12000);
		bicycle.lamp = lamp2;
		Console.WriteLine("Lamp Brand : " + bicycle.lamp.brand);
		Console.WriteLine("Lamp colour : " + bicycle.lamp.colour);
		Console.WriteLine("Lamp Watt : " + bicycle.lamp.watt);
		Console.WriteLine("Lamp Price : " + bicycle.lamp.price);
		bicycle.lamp.Start();

		// tire
		bicycle.tire = tire;
		Console.WriteLine("Tire Brand : " + bicycle.tire.brand);
		Console.WriteLine("Tire Size : " + bicycle.tire.size);
		Console.WriteLine("Tire colour : " + bicycle.tire.colour);
		Console.WriteLine("Tire Price : " + bicycle.tire.price);
		Console.WriteLine("Tire Type : " + bicycle.tire.type);
		Console.WriteLine("Tire isGood ? : " + bicycle.tire.isGood);
		bicycle.tire.Run();

		// Bell
		bicycle.bell = bell;
		Console.WriteLine("Bell Brand : " + bicycle.bell.brand);
		Console.WriteLine("Bell Size : " + bicycle.bell.size);
		Console.WriteLine("Bell Model : " + bicycle.bell.model);
		Console.WriteLine("Bell colour : " + bicycle.bell.colour);
		Console.WriteLine("Bell Price : " + bicycle.bell.price);
		Console.WriteLine("Bell Material : " + bicycle.bell.material);
		bicycle.bell.Click();
	}
}