namespace Class_Diagram;
class Program
{
	static void Main()
	{
		Bird Murai = new Bird();
		Murai.age = 2;
		Murai.color = "Blue";
		Murai.isMale = true;
		Murai.sick = false;

		Console.WriteLine("Umur si Murai adalah : " + Murai.age);
		Console.WriteLine("Warna si Murai adalah : {0}", Murai.color);
		Console.WriteLine("Apakah si Murai pria? : {0}", Murai.isMale);
		Console.WriteLine("Apakah si Murai sakit? : {0}", Murai.sick);

		Murai.Angry();
		Console.Write("Makan apa? : ");
		string makanan = Console.ReadLine();
		Console.Write("Berapa? : ");
		int jumlah = int.Parse(Console.ReadLine());
		Murai.Eat(makanan, jumlah);
		Murai.Chirped();

		Bird Pipit = new Bird();
		Pipit.age = 5;
		Pipit.color = "Brown";
		Pipit.isMale = false;
		Pipit.sick = true;

		Console.WriteLine("Umur si Pipit adalah : {0}", Pipit.age);
		Console.WriteLine("Warna si Pipit adalah : {0}", Pipit.color);
		Console.WriteLine("Apakah si Pipit pria? : {0}", Pipit.isMale);
		Console.WriteLine("Apakah si Pipit sakit? : {0}", Pipit.sick);

		Pipit.Angry();
		Console.Write("Makan apa? : ");
		string makan = Console.ReadLine();
		Console.Write("Berapa? : ");
		int berapa = int.Parse(Console.ReadLine());
		Pipit.Eat(makan, berapa);
	}
}