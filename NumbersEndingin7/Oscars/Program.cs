namespace Oscars;

class Program
{
    static void Main(string[] args)
    {
        string actorName = Console.ReadLine();
        double academyPoints = double.Parse(Console.ReadLine());
        int numJudges = int.Parse(Console.ReadLine());

        double totalPoints = academyPoints;

        for (int i = 0; i < numJudges; i++)
        {
            string judgeName = Console.ReadLine();
            double judgePoints = double.Parse(Console.ReadLine());

            totalPoints += (judgeName.Length * judgePoints) / 2.0;

            if (totalPoints > 1250.5)
            {
                Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {totalPoints:F1}!");
                return;
            }
        }

        double needed = 1250.5 - totalPoints;
        Console.WriteLine($"Sorry, {actorName} you need {needed:F1} more!");
    }
}