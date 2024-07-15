public class Program
{
	static void Main()
	{
		// int x = 4;
		// double y = x;

		// double xx = 4.0;
		// int yy = xx;

		// double xxx = 1299999999;
		// int yyy = (int)xxx;

		// double x = 3.99;
		// double y = Math.Ceiling(x);
		// int result = (int)y;
		// Console.WriteLine(result);

		// Implisit
		// Upcasting
		// dari small ke higher
		int xx = 4;
		double yy = xx;
		Console.WriteLine("Hasil implisit upcasting " + yy);

		// Explisit
		// Downcasting
		// dari high ke small
		double xe = 12;
		int ye = (int)xe;
		Console.WriteLine("hasil explisit downcasting " + ye);

		// Pembulatan keatas
		double xc = 13.98;
		double yc = Math.Ceiling(xc);
		int rc = (int)yc;
		Console.WriteLine("hasil pembulatan keatas menggunakan ceiling " + rc);

		// Pembulatan kebawah
		double xf = 13.98;
		double yf = Math.Floor(xf);
		int rf = (int)yf;
		Console.WriteLine("hasil pembualatan kebawah menggunakan floor " + rf);
	}
}