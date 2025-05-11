namespace ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double tripCost = double.Parse(Console.ReadLine());
            int puzzleCount = int.Parse(Console.ReadLine());
            int dollCount = int.Parse(Console.ReadLine());
            int bearCount = int.Parse(Console.ReadLine());
            int minionCount = int.Parse(Console.ReadLine());
            int truckCount = int.Parse(Console.ReadLine());

            double puzzlePrice = 2.60;
            double dollPrice = 3.00;
            double bearPrice = 4.10;
            double minionPrice = 8.20;
            double truckPrice = 2.00;
            
            double totalCost = (puzzleCount * puzzlePrice) + 
                               (dollCount * dollPrice) + 
                               (bearCount * bearPrice) + 
                               (minionCount * minionPrice) + 
                               (truckCount * truckPrice);
            
            if (puzzleCount + dollCount + bearCount + minionCount + truckCount >= 50)
            {
                totalCost -= totalCost * 0.25;
            }
            
            totalCost -= totalCost * 0.10;
            
            if (totalCost >= tripCost)
            {
                double remainingMoney = totalCost - tripCost;
                Console.WriteLine($"Yes! {remainingMoney:F2} lv left.");
            }
            else
            {
                double neededMoney = tripCost - totalCost;
                Console.WriteLine($"Not enough money! {neededMoney:F2} lv needed.");
            }
        }
    }
}