public class Program
{
	static void Main()
	{
		Calculator<int> calc = new Calculator<int>();
		Calculator<float> calc2 = new Calculator<float>();
		Calculator<double> calc3 = new Calculator<double>();
		Calculator<decimal> calc4 = new Calculator<decimal>();
		calc.Addition(4, 9);
		calc.Substraction(98, 9);
		calc.Division(50, 2);
		calc.Multiplication(32, 9);
		calc2.Addition(20.2f, 20.1f);
		calc3.Addition(22.3, 10.2);
		calc4.Addition(12.0M, 33.9M);
	}
}