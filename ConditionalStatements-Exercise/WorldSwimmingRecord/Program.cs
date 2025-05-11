namespace WorldSwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double worldRecord = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double timePerMeter = double.Parse(Console.ReadLine());
            
            double swimmingTime = distance * timePerMeter;
            
            double resistanceDelay = Math.Floor(distance / 15) * 12.5;
            
            double totalTime = swimmingTime + resistanceDelay;
            
            if (totalTime < worldRecord)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {totalTime:F2} seconds.");
            }
            else
            {
                double timeDifference = totalTime - worldRecord;
                Console.WriteLine($"No, he failed! He was {timeDifference:F2} seconds slower.");
            }
        }
    }
}