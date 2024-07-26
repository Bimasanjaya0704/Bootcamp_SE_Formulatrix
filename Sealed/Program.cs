public class Program
{
	static void Main()
	{
		string soundAnimal = "Miaww is Cat Sound!!";
		Cat cat = new();
		cat.MakeSound();
		soundAnimal.Print();
	}
}
interface IAnimal
{
	public void MakeSound();
}

public sealed class Cat : IAnimal
{
	public void MakeSound()
	{
		Console.WriteLine("Miauww!");
	}
}
public static class MyExtension
{
	public static void Print(this object value)
	{
		Console.WriteLine(value);
	}
}
