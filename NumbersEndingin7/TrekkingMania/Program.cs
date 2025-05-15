namespace TrekkingMania;

class Program
{
    static void Main(string[] args)
    {
        int groupsCount = int.Parse(Console.ReadLine());

        int totalPeople = 0;
        int musala = 0;
        int montBlanc = 0;
        int kilimanjaro = 0;
        int k2 = 0;
        int everest = 0;

        for (int i = 0; i < groupsCount; i++)
        {
            int peopleInGroup = int.Parse(Console.ReadLine());
            totalPeople += peopleInGroup;

            if (peopleInGroup <= 5)
            {
                musala += peopleInGroup;
            }
            else if (peopleInGroup <= 12)
            {
                montBlanc += peopleInGroup;
            }
            else if (peopleInGroup <= 25)
            {
                kilimanjaro += peopleInGroup;
            }
            else if (peopleInGroup <= 40)
            {
                k2 += peopleInGroup;
            }
            else
            {
                everest += peopleInGroup;
            }
        }

        Console.WriteLine($"{(musala * 100.0 / totalPeople):F2}%");
        Console.WriteLine($"{(montBlanc * 100.0 / totalPeople):F2}%");
        Console.WriteLine($"{(kilimanjaro * 100.0 / totalPeople):F2}%");
        Console.WriteLine($"{(k2 * 100.0 / totalPeople):F2}%");
        Console.WriteLine($"{(everest * 100.0 / totalPeople):F2}%");
    }
}