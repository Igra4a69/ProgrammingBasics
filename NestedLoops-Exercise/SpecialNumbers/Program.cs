namespace SpecialNumbers;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        for (int number = 1111; number <= 9999; number++)
        {
            string numStr = number.ToString();
            bool isSpecial = true;

            foreach (char digitChar in numStr)
            {
                int digit = digitChar - '0';

                if (digit == 0 || n % digit != 0)
                {
                    isSpecial = false;
                    break;
                }
            }

            if (isSpecial)
            {
                Console.Write(number + " ");
            }
        }
    }
}