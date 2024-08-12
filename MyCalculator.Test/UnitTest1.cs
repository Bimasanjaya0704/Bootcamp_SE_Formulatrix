namespace MyCalculator.Test;

public class MyCalculatorTest
{
	private Calculator _calc;
	[SetUp]
	public void SetUp()
	{
		_calc = new Calculator();
	}
	[Test]
	public void Add_ReturnCorrectResult()
	{
		//Arange
		int a = 3;
		int b = 3;
		int excepted = 6;
		//Act
		int result = _calc.Add(a, b);
		//Assert
		Assert.That(result, Is.EqualTo(excepted));
	}
	[Test]
	public void Add_ThrowException_AddingZero()
	{
		int a = 0;
		int b = 0;

		Assert.Throws<Exception>(() => _calc.Add(a, b));
	}

	[TestCase(3, 4, 7)]
	[TestCase(12, 4, 16)]
	[TestCase(3, 43, 46)]
	[TestCase(67, 8, 75)]
	public void Add_ReturnCorrectResult(int a, int b, int excpected)
	{
		int result = _calc.Add(a, b);
		Assert.That(result, Is.EqualTo(excpected));
	}
}