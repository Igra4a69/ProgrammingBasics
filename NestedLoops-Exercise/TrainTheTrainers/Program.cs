namespace TrainTheTrainers;

class Program
{
    static void Main(string[] args)
    {
        int juryCount = int.Parse(Console.ReadLine());

        double totalSum = 0;
        int totalGradesCount = 0;

        while (true)
        {
            string presentation = Console.ReadLine();
            if (presentation == "Finish")
            {
                break;
            }

            double sumGrades = 0;

            for (int i = 0; i < juryCount; i++)
            {
                double grade = double.Parse(Console.ReadLine());
                sumGrades += grade;
                totalSum += grade;
                totalGradesCount++;
            }

            double average = sumGrades / juryCount;
            Console.WriteLine($"{presentation} - {average:F2}.");
        }

        double finalAverage = totalSum / totalGradesCount;
        Console.WriteLine($"Student's final assessment is {finalAverage:F2}.");
    }
}