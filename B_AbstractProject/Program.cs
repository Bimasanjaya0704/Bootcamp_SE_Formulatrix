public class Program
{
	static void Main()
	{
		Lingkaran luasLingkaran = new(5);
		Console.WriteLine("Luas lingkaran adalah = " + luasLingkaran.HitungLuas());

		Segitiga luasSegitiga = new(8, 12);
		Console.WriteLine("Luas lingkaran adalah = " + luasSegitiga.HitungLuas());
	}
}

public abstract class Bangundatar
{
	public double luas;
	public abstract double HitungLuas();

}

public class Lingkaran : Bangundatar
{
	public double pi;
	public double jarijari;
	public Lingkaran(double r)
	{
		jarijari = r;
	}

	public override double HitungLuas()
	{
		luas = 3.14 * jarijari * jarijari;
		return luas;
	}
}

public class Segitiga : Bangundatar
{
	public double alas;
	public double tinggi;

	public Segitiga(double a, double t)
	{
		alas = a;
		tinggi = t;
	}
	public override double HitungLuas()
	{
		luas = 0.5 * alas * tinggi;
		return luas;
	}
}