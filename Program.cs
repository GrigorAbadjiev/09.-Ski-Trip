using System;

namespace _09._Ski_Trip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nightsCount = int.Parse(Console.ReadLine()) - 1;
            string roomType = Console.ReadLine();  
            string rating = Console.ReadLine();

            double totalSum;
            switch (roomType)
            {
                case "room for one person": totalSum = nightsCount * 18; break;
                case "apartment": totalSum = nightsCount * 25; break;
                default: totalSum = nightsCount * 35; break;
            }
            if (roomType == "apartment")
            {
                if (nightsCount < 10)
                {
                    totalSum *= 0.7;
                }
                else if (nightsCount <= 15)
                {
                    totalSum *= 0.65;
                }
                else if (nightsCount > 15)
                {
                    totalSum *= 0.5;
                }
                

                
            }
            else if (roomType == "president apartment")
            {
                if (nightsCount < 10)
                {
                    totalSum *= 0.9;
                }
                else if (nightsCount <= 15)
                {
                    totalSum *= 0.85;
                }
                else if (nightsCount > 15)
                {
                    totalSum *= 0.8;
                }
            }
            if (rating == "positive")
            {
                totalSum *= 1.25;
            }
            else
            {
                totalSum *= 0.9;
            }
            Console.WriteLine($"{totalSum:f2}");
        }
            
                

                    
        
    }
}
