using System.Numerics;

public class Program
{
	static void Main()
	{
		// Calculator
		Calculator calculator = new();
		Console.WriteLine(calculator.Add(5, 6));

		// Operator Overloading
		Human human = new();
		Human human1 = new();
		Human result = human + human1;
		Console.WriteLine(result.money);

		// Add Car
		Human resultHumanAdd = calculator.Add(human, human1);
		Human resultHumanSub = calculator.Substraction(human, human1);
		Human resultHumanDiv = calculator.Division(human, human1);
		Human resultHumanMul = calculator.Multiplication(human, human1);
	}
}

public class Calculator
{
	public T Add<T>(T a, T b) where T : IAdditionOperators<T, T, T>
	{
		return a + b;
	}
	public T Substraction<T>(T a, T b) where T : ISubtractionOperators<T, T, T>
	{
		return a - b;
	}
	public T Division<T>(T a, T b) where T : IDivisionOperators<T, T, T>
	{
		return a / b;
	}
	public T Multiplication<T>(T a, T b) where T : IMultiplyOperators<T, T, T>
	{
		return a * b;
	}
}

public class Human : IAdditionOperators<Human, Human, Human>, ISubtractionOperators<Human, Human, Human>, IDivisionOperators<Human, Human, Human>, IMultiplyOperators<Human, Human, Human>
{
	public int money;
	public static Human operator +(Human mom, Human dad)
	{
		int result = mom.money + dad.money;
		Human human = new Human();
		human.money = result;
		return human;
	}
	public static Human operator -(Human mom, Human dad)
	{
		int result = mom.money - dad.money;
		Human human = new Human();
		human.money = result;
		return human;
	}
	public static Human operator /(Human mom, Human dad)
	{
		int result = mom.money / dad.money;
		Human human = new Human();
		human.money = result;
		return human;
	}
	public static Human operator *(Human mom, Human dad)
	{
		int result = mom.money * dad.money;
		Human human = new Human();
		human.money = result;
		return human;
	}
}