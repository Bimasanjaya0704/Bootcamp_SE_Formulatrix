class Program
{
    static void Main()
    {
        Console.WriteLine("Program Starting");
        try
        {
            string result = "";
            Thread t1 = new Thread(() => result = Print());
            t1.Start();

            Console.WriteLine(result);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Exception!");
        }

        Console.WriteLine("Program Ended");
    }

    static string Print()
    {
        Console.WriteLine("Print Start");
        try
        {
            string a = "12ff";
            int b = int.Parse(a);
            return $"Print finished with output {b}";
        }
        catch (Exception ex)
        {
            Console.WriteLine("Print Error");
        }
        return "Cant Print";
    }
}

