public class Program
{
	static void Main()
	{
		Console.WriteLine("Program Starting");
		Task t1 = new Task(Print);
		Task t2 = new Task(Scan);
		Task t3 = new Task(Fax);

		t1.Start();
		t2.Start();
		t3.Start();

		t1.Wait();
		t2.Wait();
		t3.Wait();


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