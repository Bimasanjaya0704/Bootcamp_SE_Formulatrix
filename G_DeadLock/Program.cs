public class Program
{

	static async Task Main()
	{
		Task task1 = null;
		Task task2 = null;
		Console.WriteLine("Program Starting");
		task1 = Task.Run(async () =>
		{
			Console.WriteLine("Task 1 Started");
			await task2;
			Console.WriteLine("Task 1 Finish");
		});
		task2 = Task.Run(async () =>
		{
			Console.WriteLine("Task 2 Started");
			await task1;
			Console.WriteLine("Task 2 Finish");
		});
		await Task.WhenAll(task1, task2);
		Console.WriteLine("Program End");
	}
}