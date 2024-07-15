public class Program
{
	static void Main()
	{
		// Variabel
		PersonVariabel person = new();
		person.setName("Bima");
		person.setAge(22);
		person.getName();
		person.getAge();
		Console.WriteLine($"Person Variabel name = {person.getName()} & age = {person.getAge()}");


		// Properties
		PersonProperties personP = new();
		personP.name = "Bimas";
		personP.age = 22;
		Console.WriteLine($"Person Properties name = {personP.name} & age = {personP.age}");
	}

}

public class PersonVariabel
{
	private int _age;
	private string _name;

	public int getAge()
	{
		return _age;
	}
	public void setAge(int age)
	{
		_age = age;
	}
	public string getName()
	{
		return _name;
	}
	public void setName(string name)
	{
		_name = name;
	}
}

interface IPersonProperties
{
	public int age { get; set; }
	public string name { get; set; }
}


public class PersonProperties : IPersonProperties
{
	private int _age;
	private string _name;
	public int age { get; set; }
	public string name { get { return _name; } set { _name = value; } }

}