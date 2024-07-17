using System.Collections;

public class Program
{
	static void Main()
	{
		// Array
		int[] myArray = new int[4];
		myArray[0] = 2;
		myArray[1] = 4;
		myArray[2] = 8;
		myArray[3] = 10;
		Console.WriteLine("#########");
		Console.WriteLine("Array");
		foreach (var i in myArray)
		{
			Console.WriteLine(i);
		}

		// Array List
		ArrayList myArrayList = new();
		myArrayList.Add(12);
		myArrayList.Add(1.4f);
		myArrayList.Add(2.9M);
		myArrayList.Add("Hello");
		Console.WriteLine("#########");
		Console.WriteLine("Array List");
		foreach (var i in myArrayList)
		{
			Console.WriteLine(i);
		}

		// List
		List<int> myList = new();
		myList.Add(2);
		myList.Add(12);
		myList.Add(22);
		myList.Add(32);
		Console.WriteLine("#########");
		Console.WriteLine("List");
		foreach (var i in myList)
		{
			Console.WriteLine(i);
		}


		// HashSet
		HashSet<int> myHash = new();
		myHash.Add(12);
		myHash.Add(15);
		myHash.Add(22);
		Console.WriteLine("#########");
		Console.WriteLine("HashSet");
		foreach (var i in myHash)
		{
			Console.WriteLine(i);
		}

		HashSet<int> a = new() { 1, 2, 3, 4 };
		HashSet<int> b = new() { 2, 3 };
		bool status1 = a.IsSupersetOf(b);
		bool status2 = b.IsSubsetOf(a);
		Console.WriteLine(status1);
		Console.WriteLine(status2);

		// Queue
		Queue<int> myQueue = new();
		myQueue.Enqueue(12);
		myQueue.Enqueue(13);
		myQueue.Enqueue(14);
		myQueue.Enqueue(15);
		int resultQueue = myQueue.Dequeue();
		Console.WriteLine(resultQueue);



		Employee employeeOne = new Employee()
		{
			Id = 1,
			Name = "Bims"
		};

		Employee employeeTwo = new Employee()
		{
			Id = 2,
			Name = "Jack"
		};

		Employee employeeThree = new Employee()
		{
			Id = 3,
			Name = "Holland"
		};


		Queue<Employee> employeeQueue = new Queue<Employee>();
		employeeQueue.Enqueue(employeeOne);
		employeeQueue.Enqueue(employeeTwo);
		employeeQueue.Enqueue(employeeThree);
		foreach (Employee emp in employeeQueue)
		{
			Console.WriteLine(emp.Id + " " + emp.Name);
		}

		// Stack

	}
}

public class Employee
{
	public int Id { get; set; }
	public string Name { get; set; }
}