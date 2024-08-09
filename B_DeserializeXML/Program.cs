using System.Xml.Serialization;

public class Program
{
	static void Main()
	{


		XmlSerializer serializer = new(typeof(Player));
		PlayerData playerData;
		Player player;

		using (FileStream fs = new("./player.txt", FileMode.Open))
		{
			player = (Player)serializer.Deserialize(fs);
		}
		Console.WriteLine("Player Name " + player.Name);
		Console.WriteLine("Player ID " + player.Id);
		Console.WriteLine("Player Data Health " + player.Data.Health);
		Console.WriteLine("Player Data Id Player " + player.Data.IdPlayer);
		Console.WriteLine("Player Data Coin " + player.Data.Coin);
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