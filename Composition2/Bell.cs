using ComponentsBicycle;
namespace BicycleComponents;

public class Bell : Components
{
	public int size;
	public string model;
	public string material;

	public Bell(string brand, string colour, int price, int size, string model, string material) : base(brand, colour, price)
	{
		this.size = size;
		this.model = model;
		this.material = material;
	}

	public void Click()
	{
		Console.WriteLine("Kring Kring Kring");
	}
}
