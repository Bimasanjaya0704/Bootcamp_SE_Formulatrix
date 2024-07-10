using ComponentsBicycle;
namespace BicycleComponents;

public class Tire : Components
{

	public int size;
	public string type;
	public bool isGood;


	public Tire(string brand, string colour, int price, int size, string type, bool isGood) : base(brand, colour, price)
	{
		this.size = size;
		this.type = type;
		this.isGood = isGood;
	}

	public void Run()
	{
		Console.WriteLine($"Tire {brand} is running");
	}
}
