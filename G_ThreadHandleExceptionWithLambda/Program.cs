class Program
{
    static void Main()
    {
        Console.WriteLine("Program Starting");
        Thread t1 = new Thread(() =>
        {
            try
            {
                Print();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        });
        t1.Start();
        t1.Join();

        Console.WriteLine("Program Ended");
    }

    static void Print()
    {
        throw new Exception();
    }
}

