using ComponentsBicycle;
namespace BicycleComponents;

public class Lamp : Components
{
	public int watt;

	public Lamp(string brand, string colour, int price, int watt) : base(brand, colour, price)
	{
		this.watt = watt;
	}

	public void Start()
	{
		Console.WriteLine($"Lamp {colour} is strat");
	}

}
