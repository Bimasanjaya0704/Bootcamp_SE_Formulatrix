using System.Xml.Serialization;

public class Program
{
	static void Main()
	{
		PlayerData playerData1 = new(100, 1, 0);
		Player player1 = new Player("Werkudara", 1, playerData1);

		PlayerData playerData2 = new(100, 2, 0);
		Player player2 = new Player("Bima", 2, playerData2);

		PlayerData playerData3 = new(100, 3, 0);
		Player player3 = new Player("Nakula", 3, playerData3);

		PlayerData playerData4 = new(100, 4, 0);
		Player player4 = new Player("Sadewa", 4, playerData4);

		List<Player> listPlayer = new();
		listPlayer.Add(player1);
		listPlayer.Add(player2);
		listPlayer.Add(player3);
		listPlayer.Add(player4);

		XmlSerializer serializer = new(typeof(List<Player>));
		using (FileStream fs = new("./players.txt", FileMode.Create))
		{
			serializer.Serialize(fs, listPlayer);
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