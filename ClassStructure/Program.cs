using Animal;
class Program
{
	static void Main()
	{
		// Murai
		Bird Murai = new Bird();
		Murai.name = "Boy";
		Murai.age = 12;
		Murai.color = "White";
		Console.WriteLine("Nama : {0}, umur : {1}, dan warna {2} ", Murai.name, Murai.age, Murai.color);

		// Dog
		Dog Pitbul = new Dog();
		Pitbul.name = "heyo";
		Pitbul.age = 5;
		Pitbul.color = "black";


	}
}