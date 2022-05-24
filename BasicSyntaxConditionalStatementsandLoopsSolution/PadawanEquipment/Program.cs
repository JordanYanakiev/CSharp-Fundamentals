using System;

namespace PadawanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            float money = float.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());
            float lightSaberPrice = float.Parse(Console.ReadLine());
            float robePrice = float.Parse(Console.ReadLine());
            float beltPrice = float.Parse(Console.ReadLine());

            double totalLightsabers = 0;
            totalLightsabers = studentsCount + Math.Ceiling(studentsCount * 0.1f);

            int freeBelts = studentsCount / 6;
            int totalBelts = studentsCount - freeBelts;

            double totalCost = (totalLightsabers * lightSaberPrice) + (robePrice * studentsCount) + (totalBelts * beltPrice);

            if (money >= totalCost)
            {
                Console.WriteLine(String.Format("The money is enough - it would cost {0:F2}lv.", totalCost));
            }
            else
            {
                double neededMoney = totalCost - money;
                Console.WriteLine(String.Format("John will need {0:F2}lv more.", neededMoney));
            }
        }
    }
}
