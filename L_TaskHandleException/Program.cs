class Program
{
	static void Main()
	{
		Console.WriteLine("Program starting");
		Task task1 = new Task(Scan);
		try
		{
			task1.Start();
			task1.Wait();
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
		}
		Console.WriteLine("Program End");
	}
	static void Scan()
	{
		throw new Exception();
	}
}