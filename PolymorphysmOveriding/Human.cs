
public class Human
{
	public string eat;
	public string learningName;
	public int learningDuration;

	public void Eat()
	{
		eat = "nasi padang";
		Console.WriteLine("Makan " + eat);
	}

	public virtual void Learning()
	{
		learningName = "Matematika";
		learningDuration = 0;
		Console.WriteLine($"Belajar {learningName} selama {learningDuration} jam");
	}
}

