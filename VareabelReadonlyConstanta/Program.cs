// Variabel, Variabel Readonly, Variabel Constanta

public class Program
{
    static void Main()
    {
        Car car = new(2, 12);
        Console.WriteLine(car.price);
        Console.WriteLine(car.price2);
        Console.WriteLine(Car.price3);
    }
}

public class Car
{
    public int price;
    public readonly int price2;
    public const int price3 = 22;
    public Car(int price, int price2)
    {
        this.price = price;
        this.price2 = price2;
    }
}