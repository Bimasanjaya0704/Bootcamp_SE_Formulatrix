
using System.Numerics;

public class Calculator<T> where T : INumber<T>
{
	public T Addition(T a, T b)
	{
		return a + b;
	}
	public T Substraction(T a, T b)
	{
		return a - b;
	}
	public T Division(T a, T b)
	{
		return a - b;
	}
	public T Multiplication(T a, T b)
	{
		return a - b;
	}
}
