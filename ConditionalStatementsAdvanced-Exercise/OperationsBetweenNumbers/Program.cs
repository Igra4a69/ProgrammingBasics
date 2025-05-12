namespace OperationsBetweenNumbers;

class Program
{
    static void Main(string[] args)
    {
        int N1 = int.Parse(Console.ReadLine());
        int N2 = int.Parse(Console.ReadLine());
        string op = Console.ReadLine();

        double result = 0;

        if (op == "+" || op == "-" || op == "*")
        {
            if (op == "+")
            {
                result = N1 + N2;
            }
            else if (op == "-")
            {
                result = N1 - N2;
            }
            else if (op == "*")
            {
                result = N1 * N2;
            }

            string evenOrOdd = result % 2 == 0 ? "even" : "odd";
            Console.WriteLine($"{N1} {op} {N2} = {result} - {evenOrOdd}");
        }
        else if (op == "/")
        {
            if (N2 == 0)
            {
                Console.WriteLine($"Cannot divide {N1} by zero");
            }
            else
            {
                result = (double)N1 / N2;
                Console.WriteLine($"{N1} / {N2} = {result:F2}");
            }
        }
        else if (op == "%")
        {
            if (N2 == 0)
            {
                Console.WriteLine($"Cannot divide {N1} by zero");
            }
            else
            {
                result = N1 % N2;
                Console.WriteLine($"{N1} % {N2} = {result}");
            }
        }
    }
}