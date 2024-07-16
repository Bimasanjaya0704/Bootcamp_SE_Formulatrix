
using System.Numerics;

public class Calculator<T> where T : IAdditionOperators<T, T, T>
{
	public T Add(T a, T b)
	{
		return a + b;
	}
}
