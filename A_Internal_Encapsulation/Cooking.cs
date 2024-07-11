public class Cooking
{
	private int _amount;
	public string name;
	public string type;
	public string level;

	public int GetAmount()
	{
		return _amount;
	}
	public void SetAmount(int setAmount)
	{
		if (setAmount > 0)
		{
			_amount = setAmount;
		}
	}

	public Cooking(int amount, string name, string type, string level)
	{
		this._amount = amount;
		this.name = name;
		this.type = type;
		this.level = level;
	}
	public Cooking()
	{

	}

	public void FireChicken()
	{
		Cooking cooking = new Cooking();
		cooking.name = "FireWings";
		cooking._amount = 10;
		cooking.type = "fried";
		cooking.level = "hot";
		Console.WriteLine(cooking);
	}
	static void Main()
	{
		Console.WriteLine("Hello Cooking");
	}
}