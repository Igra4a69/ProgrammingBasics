namespace InvalidNumber;

class Program
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());

        if ((number >= 100 && number <= 200) || number == 0)
        {
            // валидно е, не печатаме нищо
        }
        else
        {
            Console.WriteLine("invalid");
        }
    }
}