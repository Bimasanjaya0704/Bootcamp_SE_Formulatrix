namespace Subjects;

public class Sejarah : Human
{
    public override void Learning()
    {
        Human human = new();
        human.learningName = "Sejarah";
        human.learningDuration = 2;

        Console.WriteLine($"Belajar {human.learningName} selama {human.learningDuration} jam");


    }
}
