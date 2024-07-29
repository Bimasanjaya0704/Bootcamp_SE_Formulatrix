class Program
{
	static void Main()
	{
		Console.WriteLine("Program starting");
		Task task1 = new Task(() => Scan("Messege Accepted"));
		task1.Start();

		Task task2 = Task.Run(() => Scan("Messece V2 Accepted"));

		Task.WaitAll(task1, task2);
		Console.WriteLine("Program finished");
	}
	static void Scan(string message)
	{
		Console.WriteLine("Scan start");
		Thread.Sleep(5000);
		Console.WriteLine("Scan finished" + message);
	}
}