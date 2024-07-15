public class Program
{
    static void Main()
    {
        Car car = new Car();
        car.price = 12;
        Adder add = new();
        add.Add(car.price);
        Console.WriteLine(car.price);
    }
}
public class Adder
{
    public int Add(int x)
    {
        return x++;
    }
}
class Car
{
    public int price;
}