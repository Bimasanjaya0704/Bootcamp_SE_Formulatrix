namespace ProgramPerson;
public class Program
{
	static void Main()
	{
		Person person = new("Bima Sanjaya", 22);
		person.Run();
	}
}

partial class Person
{
	public string Name { get; set; }
	public int Age { get; set; }

	public Person(string name, int age)
	{
		Name = name;
		Age = age;
	}
}