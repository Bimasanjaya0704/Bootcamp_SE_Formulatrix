using System.Xml.Serialization;

public class Program
{
	static void Main()
	{
		List<Player> listPlayer = new();

		XmlSerializer serializer = new(typeof(List<Player>));
		using (FileStream fs = new("./players.txt", FileMode.Open))
		{
			listPlayer = (List<Player>)serializer.Deserialize(fs);
		}
		foreach (var i in listPlayer)
		{
			Console.WriteLine("Player Name " + i.Name);
			Console.WriteLine("Player ID " + i.Id);
			Console.WriteLine("Player Data Health " + i.Data.Health);
			Console.WriteLine("Player Data Id Player " + i.Data.IdPlayer);
			Console.WriteLine("Player Data Coin " + i.Data.Coin);

		}
	}
}

public class Player
{
	public string Name { get; set; }
	public int Id { get; set; }
	public PlayerData Data { get; set; }
	public Player(string name, int id, PlayerData data)
	{
		Name = name;
		Id = id;
		Data = data;
	}
	public Player()
	{

	}
}

public class PlayerData
{
	public int Health { get; set; }
	public int IdPlayer { get; set; }
	public int Coin { get; set; }
	public PlayerData(int health, int id, int coin)
	{
		Health = health;
		IdPlayer = id;
		Coin = coin;
	}
	public PlayerData() { }
}