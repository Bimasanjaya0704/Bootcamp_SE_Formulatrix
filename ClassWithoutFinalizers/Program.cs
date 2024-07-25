using System.Diagnostics;

class Foundation
{
}

class House
{

}

class Roof
{

}

class Program
{
    static void Main()
    {
        int iteration = 1_000_000;
        Stopwatch stopwatch = new();
        stopwatch.Start();
        for (int i = 0; i < iteration; i++)
        {
            Foundation foundation = new();
            House house = new();
            Roof roof = new();
        }
        stopwatch.Stop();
        Console.WriteLine(stopwatch.ElapsedMilliseconds);
    }
}