// Sebelum keluar harus sudah di assign
public class Program
{
    static void Main()
    {
        int a;
        Adder add = new();
        add.Add(out a);
        Console.WriteLine(a);
    }
}
public class Adder
{
    public int Add(out int x)
    {
        return x = 10;
    }
}