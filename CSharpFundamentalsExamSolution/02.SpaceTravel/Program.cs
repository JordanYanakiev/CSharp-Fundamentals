using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.SpaceTravel
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputString = Console.ReadLine().Split("||");
            int startFuel = int.Parse(Console.ReadLine());
            int startAmmunition = int.Parse(Console.ReadLine());
            string command = null;


            //while (true)
            //{

            for (int i = 0; i < inputString.Length; i++) 
            
            { 
                command = inputString[i];
                string[] commands = command.Split(" ");

                if (commands[0] == "Titan")
                {
                    Console.WriteLine("You have reached Titan, all passengers are safe.");
                    return;
                }

                if (commands[0] == "Travel")
                {
                    Travel(commands[1]); 
                    startFuel -= 1;

                    if (startFuel <= 0)
                    {
                        Console.WriteLine("Mission failed.");
                        return;
                    }
                }
                else if (commands[0] == "Enemy")
                {
                    int enemyArmr = int.Parse(commands[1]);
                    //Enemy(commands[1], startAmmunition, startFuel);int enemyArmr = int.Parse(enemyArmour);
                    if (enemyArmr <= startAmmunition)
                    {
                        Console.WriteLine($"An enemy with {enemyArmr} armour is defeated.");
                        startAmmunition -= enemyArmr;
                    }
                    else if (enemyArmr >= startAmmunition && startFuel >= enemyArmr * 2)
                    {
                        startFuel -= enemyArmr * 2;
                        Console.WriteLine($"An enemy with {enemyArmr} armour is outmaneuvered.");
                    }
                    else if (startFuel < enemyArmr * 2)
                    {
                        Console.WriteLine("Mission failed.");
                        return;
                    }
                }
                else if (commands[0] == "Repair")
                {
                    //Repair(commands[1], startAmmunition, startFuel);
                    int amounntToAdd = int.Parse(commands[1]);
                    int addAmmo = amounntToAdd * 2;
                    startAmmunition += addAmmo;
                    startFuel += amounntToAdd;

                    Console.WriteLine($"Ammunitions added: {addAmmo}.");
                    Console.WriteLine($"Fuel added: {amounntToAdd}.");
                }


            }



            //Console.WriteLine(string.Join(" ", inputString));
 
        }


        private static void Repair(string ammunitionAdded, int startAmmunition, int startFuel)
        {
            int amounntToAdd = int.Parse(ammunitionAdded);
            int addAmmo = amounntToAdd * 2;
            startAmmunition += addAmmo;
            startFuel += amounntToAdd;

            Console.WriteLine($"Ammunitions added: {addAmmo}.");
            Console.WriteLine($"Fuel added: {amounntToAdd}.");
        }

        private static void Enemy(string enemyArmour, int startAmmunition, int startFuel)
        {
            int enemyArmr = int.Parse(enemyArmour);
            if (enemyArmr <= startAmmunition)
            {
                Console.WriteLine($"An enemy with {enemyArmr} armour is defeated.");
                startAmmunition -= enemyArmr;
            }
            else if (enemyArmr >= startAmmunition && startFuel >= enemyArmr * 2)
            {
                startFuel -= enemyArmr * 2;
                Console.WriteLine($"An enemy with {enemyArmr} armour is outmaneuvered.");
            }
            else if (startFuel < enemyArmr * 2)
            {
                Console.WriteLine("Mission failed.");
                return;
            }
        }

        private static void Travel(string lightYears)
        {
            int distance = int.Parse(lightYears);
            Console.WriteLine($"The spaceship travelled {distance} light-years.");
        }
    }
}
