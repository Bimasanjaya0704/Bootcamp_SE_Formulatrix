class Program
{
	static void Main()
	{
		// Mother
		Mother mother = new Mother();
		mother.Happy();
		// mother.Sad();
		// mother.Play();
		mother.MakeSad();

		// Child
		Child child = new Child();
		child.Happy();
		// child.Sad();
		child.Play();
		child.MakeSad();
	}
}

class Mother
{

	private void Sad()
	{
		Console.WriteLine("Mother sad");
	}

	public void MakeSad()
	{
		Sad();
	}

	public void Happy()
	{
		Console.WriteLine("Happy");
	}
}

class Child : Mother
{
	public void Play()
	{
		Console.WriteLine("Play");
	}
}