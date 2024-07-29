public class Program
{
	static void Main()
	{
		Console.WriteLine("Program Starting");
		Task t1 = Task.Run(() => Print());
		Task t2 = Task.Run(() => Scan());
		Task t3 = Task.Run(() => Fax());

		Task.WaitAll(t1, t2, t3);
		Console.WriteLine("Program Ended");
	}

	static void Print()
	{
		Console.WriteLine("Print Start");
		Thread.Sleep(2000);
		Console.WriteLine("Print End");
	}
	static void Scan()
	{
		Console.WriteLine("Scan Start");
		Thread.Sleep(2000);
		Console.WriteLine("Scan End");
	}
	static void Fax()
	{
		Console.WriteLine("Fax Start");
		Thread.Sleep(2000);
		Console.WriteLine("Fax End");
	}
}