using System;

namespace TopNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string endNumber = Console.ReadLine();


            TopNumberCheck(endNumber);
        }

        private static void TopNumberCheck(string endNumber)
        {
            int number = int.Parse(endNumber);
            int tempNum = 0;
            int tempNum2 = 0;
            bool check1 = false;
            bool check2 = false;

            for (int i = 1; i <= number; i++)
            {
                tempNum2 = i;
                while (tempNum2 > 0)
                {
                    tempNum += tempNum2 % 10;
                    tempNum2 = tempNum2 / 10;
                }

                if (tempNum % 8 == 0)
                {
                    check1 = true;
                    tempNum = 0;
                }
                else
                {
                    tempNum = 0;
                }

                tempNum2 = i;
                while (tempNum2 > 0)
                {
                    tempNum = tempNum2 % 10;
                    tempNum2 = tempNum2 / 10;

                    if (tempNum == 1 || tempNum == 3 || tempNum == 5 || tempNum == 7 ||
                        tempNum == 9)
                    {
                        check2 = true;
                        if (check1 == true && check2 == true)
                        {
                            Console.WriteLine(i);
                        }
                        break;
                    }
                    else
                    {
                        check2 = false;
                    }

                    
                }
                check1 = false;
                check2 = false;
                tempNum = 0;
            }
        }
    }
}
