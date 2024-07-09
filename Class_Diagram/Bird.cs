namespace Class_Diagram;

public class Bird()
{
    public int age;
    public string color;
    public bool isMale;
    public bool sick;

    public void Angry()
    {
        Console.WriteLine("Dapat Angry");
    }
    public void Eat(string jenisMakanan, int jumlah)
    {
        Console.WriteLine("Dapat Eat " + jumlah + " " + jenisMakanan);
    }
    public void Chirped()
    {
        Console.WriteLine("Dapat Berkicau");
    }
}

