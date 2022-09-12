using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace _05.MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string bigNumber = Console.ReadLine();
            int smallNumber = int.Parse(Console.ReadLine());
            int numberInMind = 0;
            List<char> charList = new List<char>();
            StringBuilder sb = new StringBuilder();

            for (int i = bigNumber.Length - 1; i >= 0; i--)
            {
                int intNum = int.Parse(bigNumber[i].ToString());
                int tempNum = (smallNumber * intNum) + numberInMind;
                char[] tempArr = tempNum.ToString().ToCharArray();

                //    if (tempArr.Length > 1)
                //    {
                //        charList.Add(tempArr[1]);
                //        numberInMind = int.Parse(tempArr[0].ToString());

                //        sb.Append(tempArr[1]);
                //    }
                //    else 
                //    {
                //        charList.Add(tempArr[0]);
                //        sb.Append(tempArr[0]);
                //        numberInMind = 0;
                //    }

                //    if (i == 0 && tempArr.Length > 1)
                //    {
                //        charList.Add(tempArr[0]);
                //        sb.Append(tempArr[0]);
                //    }
                //}

                if (tempArr.Length > 1)
                {
                    sb.Append(tempArr[1]);
                    numberInMind = int.Parse(tempArr[0].ToString());
                }
                else if (tempArr.Length == 1)
                {
                    sb.Append(tempArr[0]);
                    numberInMind = 0;
                }

                if (i == 0 && tempArr.Length > 1)
                {
                    sb.Append(tempArr[0]);
                }
            }

            charList.Reverse();
            //Console.WriteLine(string.Join("", charList));
            //Console.WriteLine(sb);

            for (int i = sb.Length - 1; i >= 0; i--)
            {
                Console.Write(sb[i]);
            }
        }       
    }
}
