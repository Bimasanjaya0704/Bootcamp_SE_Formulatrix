namespace Subjects;
public class Bahasa : Human
{
	public override void Learning()
	{
		Human human = new();
		human.learningName = "Bahasa";
		human.learningDuration = 12;

		Console.WriteLine($"Belajar {human.learningName} selama {human.learningDuration} jam");


	}
}
