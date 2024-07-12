public class Program
{
	static void Main()
	{
		Family family = new();
		Console.WriteLine(family.Name());
		Console.WriteLine(family.Age());
		Console.WriteLine(family.Address());
		Console.WriteLine(family.Colour());
		Console.WriteLine(family.Price());
		IPerson person = new Family();
		Console.WriteLine(person.Name());

		IFile file = new FileInfo();
		file.Readfile();
		file.WriteFIle("Start Writing");
	}
}

interface IHome
{
	public string Address();
	public string Colour();
	public int Price();
}

interface IPerson
{
	public string Name();
	public int Age();
	public int Price();
}

public class Family : IPerson, IHome
{
	// Person
	public string Name()
	{
		return "Bima";
	}
	public int Age()
	{
		return 22;
	}

	// Home
	public string Address()
	{
		return "semarang";
	}

	public string Colour()
	{
		return "Red";
	}
	public int Price()
	{
		return 120000000;
	}
}

interface IFile
{
	public void Readfile();
	public void WriteFIle(string text);
}

public class FileInfo : IFile
{
	void IFile.Readfile()
	{
		Console.WriteLine("Reading File IFile.Read");

	}
	public void Readfile()
	{
		Console.WriteLine("Reading File");
	}

	public void WriteFIle(string text)
	{
		string input = text;
		Console.WriteLine("Write File");
		Console.WriteLine(input);
	}
}