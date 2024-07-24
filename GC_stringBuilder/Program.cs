using System.Text;

public class Program
{
	static void Main()
	{
		StringBuilder sb = new("Hello");
		int iteration = 100_000_000;

		for (int i = 0; i > iteration; i++)
		{
			sb.Append("world");
			sb.Append("!");
			sb.Replace("o", "i");
			Thread.Sleep(2);
		}

	}
}