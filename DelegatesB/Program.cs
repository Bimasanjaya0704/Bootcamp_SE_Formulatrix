
public delegate void MyDelegate(int x);

public class Program
{
	public static void Main()
	{
		MyDelegate delegate1 = new MyDelegate(PrintNumber);

		delegate1(5);
	}

	public static void PrintNumber(int num)
	{
		Console.WriteLine("Number: " + num);
	}
}
