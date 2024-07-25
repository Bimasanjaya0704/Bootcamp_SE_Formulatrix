class Program
{
	static void Main()
	{
		Human human = new();
		human.name = "Bimas";
		Console.WriteLine(human);
	}
}

class Human
{
	public string name;
	public override string ToString()
	{
		return name;
	}

}