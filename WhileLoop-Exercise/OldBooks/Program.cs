namespace OldBooks;

class Program
{
    static void Main(string[] args)
    {
        string favoriteBook = Console.ReadLine();
        string input;
        int checkedBooks = 0;

        while ((input = Console.ReadLine()) != "No More Books")
        {
            if (input == favoriteBook)
            {
                Console.WriteLine($"You checked {checkedBooks} books and found it.");
                return;
            }

            checkedBooks++;
        }

        Console.WriteLine("The book you search is not here!");
        Console.WriteLine($"You checked {checkedBooks} books.");
    }
}