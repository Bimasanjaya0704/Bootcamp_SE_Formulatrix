public class Program
{
    static void Main()
    {
        Console.WriteLine("Program Running");
        try
        {
            int[] myArray = { 1, 2, 3 };
            Console.WriteLine(myArray[5]);
        }
        catch (FormatException e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            Console.WriteLine("Gas terus");
        }
        Console.WriteLine("Program Finish");
    }
}