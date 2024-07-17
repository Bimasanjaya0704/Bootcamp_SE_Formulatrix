public class Program
{
	static void Main()
	{
		Action<string, string> resultString = (string firstName, string lastName) => Console.WriteLine(firstName + " " + lastName);
		resultString("Bima", "Sanjaya");

		Func<int> resultInt = () => 128;
		Console.WriteLine(resultInt());
		Func<int, int, int, int> resultInt2 = (int a, int b, int c) => a + b / c;
		Console.WriteLine(resultInt2(12, 98, 12));
	}
}