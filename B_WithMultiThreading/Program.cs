﻿class Program
{
    public static void Main()
    {
        Console.WriteLine("Program Starting");

        Thread t1 = new Thread(Print);
        Thread t2 = new Thread(Fax);
        Thread t3 = new Thread(Scan);

        t1.Start();
        t2.Start();
        t3.Start();
        t1.Join();
        t2.Join();
        t3.Join();

        Console.WriteLine("Program End");
    }

    static void Print()
    {
        Console.WriteLine("Print Start");
        Thread.Sleep(5000);
        Console.WriteLine("Print Finish");
    }
    static void Fax()
    {
        Console.WriteLine("Fax Start");
        Thread.Sleep(8000);
        Console.WriteLine("Fax Finish");
    }
    static void Scan()
    {
        Console.WriteLine("Scan Start");
        Thread.Sleep(3000);
        Console.WriteLine("Scan Finish");
    }
}
