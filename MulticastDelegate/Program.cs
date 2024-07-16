public delegate void MyDelegates();
public class Program
{
	static void Main()
	{
		Radio radio = new Radio();
		Tv tv = new Tv();
		MyDelegates myDel = radio.TurnOn;
		myDel += tv.OnTv;
		myDel();
	}
}

public class Radio
{
	public void TurnOn()
	{
		Console.WriteLine("Menyala radio");
	}
}

public class Tv
{
	public void OnTv()
	{
		Console.WriteLine("Menyala TV");
	}
}