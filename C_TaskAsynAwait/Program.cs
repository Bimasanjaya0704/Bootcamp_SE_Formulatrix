public class Program
{
	static async void Main()
	{
		Console.WriteLine("Program starting");
		CancellationTokenSource SetToken = new CancellationTokenSource();

		Task order1 = Task.Run(() => SendPacket("Packet 1", SetToken.Token));
		Task order2 = Task.Run(() => SendPacket("Packet 2", SetToken.Token));

		Task cargo1 = Task.Run(() => CargoDelivery("Cargo 1", SetToken.Token));
		Task cancelOrder = Task.Run(async () =>
		{
			Console.WriteLine("Press enter to cancel order...");
			Console.ReadLine();
			await Task.Delay(200);
			SetToken.Cancel();
		});
		await Task.WhenAny(order1, order2, cargo1, cancelOrder);

		Console.WriteLine("Program Finish");
		Console.ReadLine();
	}

	static async Task SendPacket(string name, CancellationToken ct)
	{
		Console.WriteLine($"{name} Delivery Starting");
		for (int i = 0; i < 100; i += 7)
		{
			Console.WriteLine($"{name} Sending {i}%");
			await Task.Delay(500);
			if (ct.IsCancellationRequested)
			{
				Console.WriteLine($"{name} Canceled.");
				return;
			}
		}
		Console.WriteLine($"{name} Delivery Finish.");
	}

	static async Task CargoDelivery(string name, CancellationToken ct)
	{
		Console.WriteLine($"{name} Cargp Delivery Starting");
		for (int i = 0; i < 100; i++)
		{
			Console.WriteLine($"{name} Sending {i}%");
			await Task.Delay(500);
			if (ct.IsCancellationRequested)
			{
				Console.WriteLine($"{name} Canceled.");
				return;
			}
		}
		Console.WriteLine($"{name} Delivery Finish.");
	}

}
