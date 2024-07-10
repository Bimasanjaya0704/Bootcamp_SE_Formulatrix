class A
{
	public A()
	{
		Console.WriteLine("A Created!!");
	}
	public void Testing()
	{
		Console.WriteLine("Parent Class");
	}
}

class B : A
{
	public B()
	{
		Console.WriteLine("B Created!!");
	}
}

class C : B
{
	public C()
	{
		Console.WriteLine("C Created!!");
	}
}

class D : C
{
	public D()
	{
		Console.WriteLine("D Created!!");
	}
}

class Program
{
	static void Main()
	{
		D d = new D();
		d.Testing();
	}
}