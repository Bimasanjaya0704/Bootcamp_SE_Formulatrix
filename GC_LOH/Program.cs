public class Program
{
	static void Main()
	{
		float[] myFloat = new float[100 * 1024]; // 1024 = 1 kb
		Console.WriteLine("Save in GC Gen : " + GC.GetGeneration(myFloat));
	}
}