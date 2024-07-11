
public class CalculatorParams
{
	public int Add(params int[] numbers)
	{
		int result = 0;
		foreach (int i in numbers)
		{
			result += i;
		}
		return result;
	}
	public int Substraction(params int[] numbers)
	{
		int result = 0;
		foreach (int i in numbers)
		{
			result -= i;
		}
		return result;
	}
	public int Multiple(params int[] numbers)
	{
		int result = 0;
		foreach (int i in numbers)
		{
			result *= i;
		}
		return result;
	}
}
