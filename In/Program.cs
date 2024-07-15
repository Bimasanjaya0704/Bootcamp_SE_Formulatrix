// Sebelum masuk harus sudah di assign (Read Only)
public class Program
{
    static void Main()
    {
        int a = 12;
        Adder add = new();
        add.Add(in a);
        Console.WriteLine(a);
    }
}
public class Adder
{
    public void Add(in int x)
    {
        // x = 13;
    }
}