// Func<> = dapat digunakan pada method yang mempunyai return
public class Program
{
	static void Main()
	{
		Func<string, string, string> name = Fullname;
		string result = name.Invoke("Bima", "Sanjaya");
		Console.WriteLine(result);

		Func<int, int, int> addDel = Add;
		int resultAdd = addDel.Invoke(5, 6);
		Console.WriteLine(resultAdd);
	}
	static string Fullname(string firstName, string lastName)
	{
		return firstName + " " + lastName;
	}
	static int Add(int a, int b)
	{
		return a + b;
	}
}