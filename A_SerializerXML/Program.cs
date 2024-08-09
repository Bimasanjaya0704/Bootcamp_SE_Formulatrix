using System.Xml.Serialization;

public class Program
{
	static void Main()
	{
		PlayerData playerData = new(100, 1, 0);
		Player player = new Player("Bims", 1, playerData);

		XmlSerializer serializer = new(typeof(Player));
		using (FileStream fs = new("./player.txt", FileMode.Create))
		{
			serializer.Serialize(fs, player);
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