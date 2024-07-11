class Program
{
	static void Main()
	{
		Cooking cooking = new Cooking();
		cooking.name = "rendang";
		cooking.SetAmount(12);
		cooking.GetAmount();
		Console.WriteLine($"nama makanan {cooking.name} dan berjumlah " + cooking.GetAmount());
	}
}