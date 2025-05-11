namespace PasswordGuess;

class Program
{
    static void Main(string[] args)
    {
        string inputPassword = Console.ReadLine();

        string correctPassword = "s3cr3t!P@ssw0rd";

        if (inputPassword == correctPassword)
        {
            Console.WriteLine("Welcome");
        }
        else
        {
            Console.WriteLine("Wrong password!");
        }
    }
}