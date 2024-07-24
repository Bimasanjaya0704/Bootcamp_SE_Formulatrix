public class Program
{
	static void Main()
	{
		RollDice roll = new();
		Dice diceResult = roll.Rolling();
		Console.WriteLine($"Hasil lemparan dadu: {diceResult}");
	}
}

public enum Dice
{
	one = 1,
	two, three, four, five, six
}

public class RollDice
{
	public Dice Rolling()
	{
		Random random = new();
		int diceValue = random.Next(1, 6);
		return (Dice)diceValue;
	}
}