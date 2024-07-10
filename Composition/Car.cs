namespace CarBody;
using CarComponents;

public class Car
{
	static void Cars()
	{
		Engine engine = new Engine("125", "Bollo", "Minyak");
		Tire tire = new Tire(12, "Uranium", "Hyuko");
		Console.WriteLine("Isi engine : " + engine);
		Console.WriteLine("Isi tire : " + tire);
	}
}
