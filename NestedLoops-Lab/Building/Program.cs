namespace Building;

class Program
{
    static void Main(string[] args)
    {
        int floors = int.Parse(Console.ReadLine());
        int roomsPerFloor = int.Parse(Console.ReadLine());

        for (int floor = floors; floor >= 1; floor--)
        {
            for (int room = 0; room < roomsPerFloor; room++)
            {
                if (floor == floors) // последен етаж - апартаменти с L
                {
                    Console.Write($"L{floor}{room} ");
                }
                else if (floor % 2 == 0) // четен етаж - офиси
                {
                    Console.Write($"O{floor}{room} ");
                }
                else // нечетен етаж - апартаменти
                {
                    Console.Write($"A{floor}{room} ");
                }
            }

            Console.WriteLine();
        }
    }
}