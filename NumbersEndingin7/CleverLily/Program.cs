namespace CleverLily;

class Program
{
    static void Main(string[] args)
    {
        int age = int.Parse(Console.ReadLine()); 
        double washingMachinePrice = double.Parse(Console.ReadLine()); 
        int toyPrice = int.Parse(Console.ReadLine()); 

        int toysCount = 0;
        double moneySaved = 0;
        int moneyGift = 10;

        for (int i = 1; i <= age; i++)
        {
            if (i % 2 == 0)
            {
                moneySaved += moneyGift - 1; 
                moneyGift += 10; 
            }
            else
            {
                toysCount++; 
            }
        }

        moneySaved += toysCount * toyPrice;

        double diff = Math.Abs(moneySaved - washingMachinePrice);

        if (moneySaved >= washingMachinePrice)
        {
            Console.WriteLine($"Yes! {diff:F2}");
        }
        else
        {
            Console.WriteLine($"No! {diff:F2}");
        }
    }
}