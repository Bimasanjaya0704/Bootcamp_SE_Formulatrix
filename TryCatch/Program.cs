public class Program
{
    static void Main()
    {
        Console.WriteLine("Program Running");
        try
        {
            int[] myArray = { 1, 2, 3 };
            Console.WriteLine(myArray[2]);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        Console.WriteLine("Program Finish");
    }
}