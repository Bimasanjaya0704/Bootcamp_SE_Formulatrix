class Program
{
	static void Main()
	{
		string path = @".\myName.txt";
		using (StreamWriter sw = new StreamWriter(path))
		{
			sw.Write("Bima Sanjaya");
		}

		using (StreamReader sr = new StreamReader(path))
		{
			string myName = sr.ReadLine();
			if (myName is not null)
			{
				Console.WriteLine(myName);
			}
		}
	}
}
