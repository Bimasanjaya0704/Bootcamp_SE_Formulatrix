public class Program
{
	static void Main()
	{
		int a = 12;
		Adder add = new();
		add.Add(a);
		Console.WriteLine(a);
	}
}

public class Adder
{
	public int Add(int x)
	{
		return x++;
	}
}