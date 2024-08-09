using System.Runtime.Serialization;
using System.Xml.Serialization;

[DataContract]
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

		List<Player> listPlayer = new List<Player>
		{
			player1,
			player2,
			player3,
			player4
		};


		DataContractSerializer dataContract = new(typeof(List<Player>));
		using (FileStream fs = new("./players.txt", FileMode.Create))
		{
			dataContract.WriteObject(fs, listPlayer);
		}

		List<Player> listPlayer2;
		using (FileStream fs = new("./players.txt", FileMode.Open))
		{
			listPlayer2 = (List<Player>)dataContract.ReadObject(fs);
		}
		foreach (var i in listPlayer2)
		{
			Console.WriteLine("Player Name " + i.GetName());
			Console.WriteLine("Player ID " + i.GetId());
			Console.WriteLine("Player Data Health " + i.GetPlayerdata().GetHealth());
			Console.WriteLine("Player Data Id Player " + i.GetPlayerdata().GetIdPlayer());
			Console.WriteLine("Player Data Coin " + i.GetPlayerdata().GetCoin());

		}
	}
}

public class Player
{
	[DataMember]
	public string _name { get; }
	[DataMember]
	public int _id { get; }
	[DataMember]
	public PlayerData _data { get; }
	public Player(string name, int id, PlayerData data)
	{
		_name = name;
		_id = id;
		_data = data;
	}
	public Player() { }

	public string GetName() => _name;
	public int GetId() => _id;
	public PlayerData GetPlayerdata() => _data;
}

public class PlayerData
{
	[DataMember]
	public int _health { get; }
	[DataMember]
	public int _idPlayer { get; }
	[DataMember]
	public int _coin { get; }
	public PlayerData(int health, int id, int coin)
	{
		_health = health;
		_idPlayer = id;
		_coin = coin;
	}
	public PlayerData() { }

	public int GetHealth() => _health;
	public int GetIdPlayer() => _idPlayer;
	public int GetCoin() => _coin;
}