// Sebelum masuk method harus sudah di assign
public class Program
{
	static void Main()
	{
		Car car = new Car();
		car.price = 12;
		Adder add = new();
		add.Add(ref car.price);
		Console.WriteLine(car.price);
	}
}
public class Adder
{
	public int Add(ref int x)
	{
		return x++;
	}
}
class Car
{
	public int price;
}