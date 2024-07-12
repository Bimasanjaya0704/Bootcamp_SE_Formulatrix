public class Program
{
	static void Main()
	{
		// Value Type
		Program program = new();
		// Int
		program.Value();
		// String
		program.ValueString();

		//Reference Type
		// Int
		Samplereference reference = new(5);
		Samplereference raeference2 = reference;
		raeference2.a += 2;

		Console.WriteLine("Reference Type Int : ");
		Console.WriteLine(reference.a);
		Console.WriteLine(raeference2.a);

		// String
		ReferenceString refString = new ReferenceString("Hello");
		ReferenceString refString2 = refString;
		refString2.a += " World";

		Console.WriteLine("Reference Type Sting : ");
		Console.WriteLine(refString.a);
		Console.WriteLine(refString2.a);
	}

	public void Value()
	{
		int x = 5;
		int y = x;
		y += 2;

		Console.WriteLine("Value Type Int : ");
		Console.WriteLine(x);
		Console.WriteLine(y);
	}

	public void ValueString()
	{
		string x = "Hello";
		string y = x;
		y += "world";
		Console.WriteLine("Value Type String : ");
		Console.WriteLine(x);
		Console.WriteLine(y);
	}
}

public class Samplereference
{
	public int a;
	public Samplereference(int a)
	{
		this.a = a;
	}
}

public class ReferenceString
{
	public string a;
	public ReferenceString(string a)
	{
		this.a = a;
	}
}