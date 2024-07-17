public class Program
{
	static void Main()
	{
		Publisher pub = new();
		Subscriber sub = new();
		Subscriber sub2 = new();

		pub.del += sub.GetNotification;
		pub.del += sub2.GetNotification;
	}
}