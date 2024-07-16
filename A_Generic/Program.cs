public class Program
{
	static void Main()
	{
		MyOwnCollection<int> myOwnCollection = new MyOwnCollection<int>(3);
		MyOwnCollection<string> myOwnCollectionString = new MyOwnCollection<string>(3);
		myOwnCollection.Add(5);
		myOwnCollection.Add(12);
		myOwnCollectionString.Add("Bims");
		Console.WriteLine(myOwnCollectionString.Get(0));
		Console.WriteLine(myOwnCollection.Get(0));
		myOwnCollection.Remove(0);
		Console.WriteLine(myOwnCollection.Get(0));

	}
}

public class MyOwnCollection<T>
{
	public T[] myCollection;
	public int count = 0;
	public MyOwnCollection(int size)
	{
		myCollection = new T[size];
	}
	public void Add(T input)
	{
		if (count == myCollection.Length)
		{
			return;
		}
		myCollection[count] = input;
		count++;
		// Console.WriteLine("Add berhasil ");
	}
	public T Get(int index)
	{
		return myCollection[index];
	}
	public void Remove(int index)
	{
		myCollection[index] = default;
		Console.WriteLine("Remove berhasil ");

	}
}