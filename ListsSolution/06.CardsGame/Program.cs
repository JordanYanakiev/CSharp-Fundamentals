using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.CardsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstPlayerCards = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondPlayerCards = Console.ReadLine().Split().Select(int.Parse).ToList();
            int count1 = 0;
            int count2 = 0;


            CompareCards(firstPlayerCards, secondPlayerCards, count1, count2);


            for (int i = 0; i < firstPlayerCards.Count; i++)
            {
                count1 += firstPlayerCards[i];
            }
            
            for (int i = 0; i < secondPlayerCards.Count; i++)
            {
                count2 += secondPlayerCards[i];
            }

            if (count1 > count2)
            {
                Console.WriteLine("First player wins! Sum: " + count1);

            }
            else
            {

                Console.WriteLine("Second player wins! Sum: " + count2);
            }


        }

        private static void CompareCards(List<int> firstListToCompare, List<int> secondListToCompare, int count1, int count2)
        {
            
            while (true)
            {
                if (firstListToCompare.Count <= 0 || secondListToCompare.Count <= 0)
                {
                    return;
                }


                if (firstListToCompare[0] > secondListToCompare[0])
                {
                    count1 += firstListToCompare[0] + secondListToCompare[0];
                    firstListToCompare.Add(secondListToCompare[0]);
                    secondListToCompare.RemoveAt(0);

                }
                else if (firstListToCompare[0] < secondListToCompare[0])
                {
                    count2 += firstListToCompare[0] + secondListToCompare[0];
                    secondListToCompare.Add(firstListToCompare[0]);
                    firstListToCompare.RemoveAt(0);

                }
                else if (firstListToCompare[0] == secondListToCompare[0])
                {
                    firstListToCompare.RemoveAt(0);
                    secondListToCompare.RemoveAt(0);
                }



            }
        }
    }
}
