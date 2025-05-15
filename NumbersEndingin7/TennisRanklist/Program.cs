namespace TennisRanklist;

class Program
{
    static void Main(string[] args)
    {
        int tournaments = int.Parse(Console.ReadLine());
        int startingPoints = int.Parse(Console.ReadLine());

        int totalPoints = startingPoints;
        int winCount = 0;
        int gainedPoints = 0;

        for (int i = 0; i < tournaments; i++)
        {
            string stage = Console.ReadLine();

            if (stage == "W")
            {
                totalPoints += 2000;
                gainedPoints += 2000;
                winCount++;
            }
            else if (stage == "F")
            {
                totalPoints += 1200;
                gainedPoints += 1200;
            }
            else if (stage == "SF")
            {
                totalPoints += 720;
                gainedPoints += 720;
            }
        }

        int averagePoints = gainedPoints / tournaments;
        double winPercent = winCount * 100.0 / tournaments;

        Console.WriteLine($"Final points: {totalPoints}");
        Console.WriteLine($"Average points: {averagePoints}");
        Console.WriteLine($"{winPercent:F2}%");
    }
}