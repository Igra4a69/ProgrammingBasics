namespace NumberRange;

class Program
{
    static void Main(string[] args)
    {
        // Вход: четем цяло число
        int number = int.Parse(Console.ReadLine());

        // Проверки
        if (number < 100)
        {
            Console.WriteLine("Less than 100");
        }
        else if (number <= 200)
        {
            Console.WriteLine("Between 100 and 200");
        }
        else
        {
            Console.WriteLine("Greater than 200");
        }
    }
}