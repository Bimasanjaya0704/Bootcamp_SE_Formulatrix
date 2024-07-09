namespace Constructor;
class Program
{
	static void Main()
	{
		Home home = new Home(9, 2, "Green", "Semarang");
		Console.WriteLine(home.address);
	}
}

