namespace Graduation;

class Program
{
    static void Main(string[] args)
    {
        string studentName = Console.ReadLine();
        int currentGrade = 1;
        int failCount = 0;
        double totalGrades = 0.0;

        while (currentGrade <= 12)
        {
            double grade = double.Parse(Console.ReadLine());

            if (grade < 4.00)
            {
                failCount++;
                if (failCount > 1)
                {
                    Console.WriteLine($"{studentName} has been excluded at {currentGrade} grade");
                    return;
                }
                continue;
            }
            
            totalGrades += grade;
            currentGrade++;
        }

        double averageGrade = totalGrades / 12;
        Console.WriteLine($"{studentName} graduated. Average grade: {averageGrade:F2}");
    }
}