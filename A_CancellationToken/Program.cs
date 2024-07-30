public class Program
{
	static void Main()
	{
		Console.WriteLine("Program starting");
		CancellationTokenSource SetToken = new CancellationTokenSource();

		Task order1 = Task.Run(() => SendPacket("Packet 1", SetToken.Token));
		Task order2 = Task.Run(() => SendPacket("Packet 2", SetToken.Token));

		Task cargo1 = Task.Run(() => CargoDelivery("Cargo 1", SetToken.Token));
		Task cancelOrder = Task.Run(() =>
		{
			Console.WriteLine("Press enter to cancel order...");
			Console.ReadLine();
			Thread.Sleep(200);
			SetToken.Cancel();
		});
		Task.WaitAny(order1, order2, cargo1, cancelOrder);

		Console.WriteLine("Program Finish");
		Console.ReadLine();
	}

	static void SendPacket(string name, CancellationToken ct)
	{
		Console.WriteLine($"{name} Delivery Starting");
		for (int i = 0; i < 100; i += 7)
		{
			Console.WriteLine($"{name} Sending {i}%");
			Thread.Sleep(500);
			if (ct.IsCancellationRequested)
			{
				Console.WriteLine($"{name} Canceled.");
				return;
			}
		}
		Console.WriteLine($"{name} Delivery Finish.");
	}

	static void CargoDelivery(string name, CancellationToken ct)
	{
		Console.WriteLine($"{name} Cargp Delivery Starting");
		for (int i = 0; i < 100; i++)
		{
			Console.WriteLine($"{name} Sending {i}%");
			Thread.Sleep(500);
			if (ct.IsCancellationRequested)
			{
				Console.WriteLine($"{name} Canceled.");
				return;
			}
		}
		Console.WriteLine($"{name} Delivery Finish.");
	}

}
