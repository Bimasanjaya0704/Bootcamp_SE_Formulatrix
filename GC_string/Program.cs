public class Program
{
	static void Main()
	{
		string a = "hello";
		int iteration = 100_000_000;

		for (int i = 0; i < iteration; i++)
		{
			a += "world";
			a += "!";
			a.Replace("o", "i");
			Thread.Sleep(10);
		}

	}
}