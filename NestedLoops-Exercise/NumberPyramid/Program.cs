namespace NumberPyramid;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        int current = 1;
        bool isFinished = false;

        for (int row = 1; row <= n; row++)
        {
            for (int col = 1; col <= row; col++)
            {
                if (current > n)
                {
                    isFinished = true;
                    break;
                }

                Console.Write(current + " ");
                current++;
            }

            Console.WriteLine();

            if (isFinished)
            {
                break;
            }
        }
    }
}