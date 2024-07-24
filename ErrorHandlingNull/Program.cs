public class Program
{
    static void Main()
    {
        GetData get = new();
        int[] status = get.IsNull();
        if (!(status == null))
        {
            Console.WriteLine(status);
        }
        Console.WriteLine("Data is null");
    }
}

class GetData
{
    public int[] IsNull()
    {
        return null;
    }
}