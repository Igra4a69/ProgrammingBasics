using System;

public class LunchBreak
{
    public static void Main(string[] args)
    {
        string seriesName = Console.ReadLine();
        int episodeDuration = int.Parse(Console.ReadLine());
        int breakDuration = int.Parse(Console.ReadLine());
        
        double lunchTime = (double)breakDuration / 8.0;
        double restTime = (double)breakDuration / 4.0;
        
        double remainingTimeForEpisode = breakDuration - lunchTime - restTime;
        
        if (remainingTimeForEpisode >= episodeDuration)
        {
            double freeTime = remainingTimeForEpisode - episodeDuration;
            int roundedFreeTime = (int)Math.Ceiling(freeTime);
            Console.WriteLine($"You have enough time to watch {seriesName} and left with {roundedFreeTime} minutes free time.");
        }
        else
        {
            double neededTime = episodeDuration - remainingTimeForEpisode;
            int roundedNeededTime = (int)Math.Ceiling(neededTime);
            Console.WriteLine($"You don't have enough time to watch {seriesName}, you need {roundedNeededTime} more minutes.");
        }
    }
}