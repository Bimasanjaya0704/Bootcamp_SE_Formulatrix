using Parent;

namespace Baby;

public class Child
{
	public void GetMother()
	{
		Mother mother = new Mother("ana", 12);
		mother.SetNik(332211);
		mother.GetNik();
		Console.WriteLine("Mother name = " + mother.name);
		Console.WriteLine("Mother age = " + mother.age);
		Console.WriteLine("Mother nik = " + mother.GetNik());
	}




}
