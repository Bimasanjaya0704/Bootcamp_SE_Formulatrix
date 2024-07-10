namespace ComponentsBicycle;

public class Components
{
	public string brand;
	public string colour;
	public int price;

	public Components(string brand, string colour, int price)
	{
		this.brand = brand;
		this.colour = colour;
		this.price = price;
	}

	public void Use()
	{
		Console.WriteLine("Can Using");
	}
}
