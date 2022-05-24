using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            string typeOfGroup = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();

            float price = 0;
            float totalPrice = 0;

            switch (typeOfGroup)
            {
                case "Students":
                    if (dayOfWeek == "Friday")
                    {
                        price = 8.45f;
                        
                    }
                    else if (dayOfWeek == "Saturday")
                    {
                        price = 9.80f;
                        
                    }
                    else if (dayOfWeek == "Sunday")
                    {
                        price = 10.46f;
                        
                    }
                    break;
                case "Business":
                    if (dayOfWeek == "Friday")
                    {
                        price = 10.90f;
                        
                    }
                    else if (dayOfWeek == "Saturday")
                    {
                        price = 15.60f;
                        
                    }
                    else if (dayOfWeek == "Sunday")
                    {
                        price = 16f;
                        
                    }
                    break;
                case "Regular":
                    if (dayOfWeek == "Friday")
                    {
                        price = 15f;
                        
                    }
                    else if (dayOfWeek == "Saturday")
                    {
                        price = 20f;
                        
                    }
                    else if (dayOfWeek == "Sunday")
                    {
                        price = 22.50f;
                        
                    }
                    break;
            }


            if (typeOfGroup == "Students" && numberOfPeople >= 30)
            {
                totalPrice = price * numberOfPeople - ((price * numberOfPeople) * 0.15f);
            }
            else if (typeOfGroup == "Business" && numberOfPeople >= 100)
            {
                totalPrice = price * numberOfPeople - ((price * 10));
            }
            else if (typeOfGroup == "Regular" && (numberOfPeople >= 10 && numberOfPeople <= 20))
            {
                totalPrice = price * numberOfPeople - ((price * numberOfPeople) * 0.05f);
            }
            else
            {
                totalPrice = price * numberOfPeople;
            }

            Console.WriteLine(String.Format("Total price: {0:F2}", totalPrice));



        }
    }
}
