using Baby;

class Program
{
	static void Main()
	{
		Child child = new Child("Bima", 22, "football", true);
		Console.WriteLine("child name = " + child.name);
		Console.WriteLine("child age = " + child.age);
		Console.WriteLine("child Hobby = " + child.hobby);
		Console.WriteLine("child is Cry = ");
		child.SetCry(false);
		child.GetMother();
	}
}