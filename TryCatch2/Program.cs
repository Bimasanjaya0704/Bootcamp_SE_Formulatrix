public class Program
{
    static void Main()
    {
        Console.WriteLine("Program Running");
        try
        {
            string[] name = { "Bima", "Sanjaya7" };
            Console.WriteLine(name[1]);

            int[] array = null;
            Console.WriteLine(array[2]);

            string userName = "bims7";
            int convertUserName = int.Parse(userName);
            Console.WriteLine(convertUserName);

            string[] hobby = { "football", "volleyball", "sleeping" };
            Console.WriteLine(hobby[1]);

        }
        catch (FormatException e)
        {
            Console.WriteLine("FormatException...");
            Console.WriteLine(e.Message);
        }
        catch (IndexOutOfRangeException e)
        {
            Console.WriteLine("IndexOutOfRangeException...");
            Console.WriteLine(e.Message);
        }
        catch (Exception e)
        {
            Console.WriteLine("Exception...");
            Console.WriteLine(e.Message);
        }


        Console.WriteLine("Program Finish");
    }
}