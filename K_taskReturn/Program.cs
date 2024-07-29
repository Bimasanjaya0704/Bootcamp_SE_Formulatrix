public class Program
{
	static void Main()
	{
		Task<int> task1 = new Task<int>(() => Add(1, 2));
		task1.Start();

		Task<int[]> task2 = Task<int[]>.Run(() => MyArray());
		Task.WaitAll(task1, task2);
		Console.WriteLine(task1.Result);
		Console.WriteLine(task2.Result);

	}

	static int Add(int a, int b)
	{
		return a + b;
	}

	static int[] MyArray()
	{
		return new int[8];
	}
}