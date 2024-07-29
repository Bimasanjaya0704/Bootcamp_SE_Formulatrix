class Program
{
    public static void Main()
    {
        Console.WriteLine("Program Starting");

        Program pro = new();
        pro.Print();
        pro.Fax();
        pro.Scan();
        Console.WriteLine("Program End");
    }

    public void Print()
    {
        Console.WriteLine("Print Start");
        Thread.Sleep(5000);
        Console.WriteLine("Print Finish");
    }
    public void Fax()
    {
        Console.WriteLine("Fax Start");
        Thread.Sleep(8000);
        Console.WriteLine("Fax Finish");
    }
    public void Scan()
    {
        Console.WriteLine("Scan Start");
        Thread.Sleep(3000);
        Console.WriteLine("Scan Finish");
    }
}

