class Program
{
    static void Main()
    {
        string path = @".\myName.txt";
        using (StreamWriter sw = new StreamWriter(path))
        {
            sw.Write("Bima Sanjaya");
        }
    }
}
