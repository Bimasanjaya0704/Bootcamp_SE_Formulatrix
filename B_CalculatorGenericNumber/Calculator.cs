

using System.Numerics;

public class Calculator
{
	public T Addition<T>(T a, T b) where T : IAdditionOperators<T, T, T>
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
