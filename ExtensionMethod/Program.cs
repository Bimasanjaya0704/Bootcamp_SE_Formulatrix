public class Program
{
	static void Main()
	{
		string name = "Bima Sanjaya";
		int age = 22;

		name.Print();
		age.Print();
	}
}

public static class MyExtension
{
	public static void Print(this object value)
	{
		Console.WriteLine(value);
	}
}