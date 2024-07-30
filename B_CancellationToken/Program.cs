public class Program
{
	static async Task Main()
	{
		Console.WriteLine("Program Starting");
		CancellationTokenSource setToken = new CancellationTokenSource();
		Task task1 = Task.Run(() => Timer(setToken.Token));
		Task task2 = Task.Run(() => Action(setToken));
		await Task.WhenAny(task1, task2);
		Console.WriteLine("Program End");
	}

	private static void Action(CancellationTokenSource ct)
	{

		Console.ReadLine();
		ct.Cancel();

	}

	static async Task Timer(CancellationToken ct)
	{
		int setTimer = 60000;
		Console.WriteLine($"Set Timer : {setTimer / 60000} Minute");
		Console.WriteLine("timer Start");
		for (int i = setTimer; i >= 0; i -= 1000)
		{
			Console.WriteLine($"Time Remaining {i / 1000} Seconds");
			await Task.Delay(1000);
			if (ct.IsCancellationRequested)
			{
				Console.WriteLine($"Timer Stoped!");
				return;
			}
		}
		Console.WriteLine("Timer Finish");
	}
}