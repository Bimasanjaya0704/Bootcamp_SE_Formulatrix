public class Program : IDisposable
{
	static void Main()
	{
		TripJakarta();
	}

	static void TripJakarta()
	{
		string FilePath = "MyFile.txt";
		using (FileStream fs = new(FilePath, FileMode.Create))
		{
			HandleTrip(fs);
		}

	}

	static void HandleTrip(FileStream fs)
	{
		//.......
	}

	public void Dispose()
	{
		throw new NotImplementedException();
	}
}