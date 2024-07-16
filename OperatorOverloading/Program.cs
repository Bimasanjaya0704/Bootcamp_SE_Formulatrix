using System.Xml.XPath;

public class Program
{
	static void Main()
	{
		Human human1 = new Human();
		Human human2 = new Human();
		Human result = human1 + human2;
		Console.WriteLine(result.money);

		Word word1 = new();
		Word word2 = new();
		Word resultString = word1 + word2;
		Console.WriteLine(resultString.doubleConstant);
	}
}

public class Human
{
	public int money = 100000;
	public static Human operator +(Human mom, Human dad)
	{
		int result = mom.money + dad.money;
		Human human = new();
		human.money = result;
		return human;
	}
}

public class Word
{
	public string doubleConstant = "Kupu ";
	public static Word operator +(Word a, Word b)
	{
		string resultWord = a.doubleConstant + b.doubleConstant;
		Word doubleWord = new();
		doubleWord.doubleConstant = resultWord;
		return doubleWord;
	}
}