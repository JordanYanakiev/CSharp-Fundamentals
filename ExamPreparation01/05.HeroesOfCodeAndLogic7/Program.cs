using System;
using System.Collections.Generic;

namespace _05.HeroesOfCodeAndLogic7
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfHeroes = int.Parse(Console.ReadLine());
            Dictionary<string, int> heroHitPoints = new Dictionary<string, int>();
            Dictionary<string, int> heroManaPoints = new Dictionary<string, int>();
            string input = null;
            string[] command00 = null;

            for (int i = 0; i < numberOfHeroes; i++)
            {
                input = Console.ReadLine();
                string[] cmdTokens = input.Split();
                string heroName = cmdTokens[0];
                int hP = int.Parse(cmdTokens[1]);
                int mP = int.Parse(cmdTokens[2]);

                if (!heroHitPoints.ContainsKey(heroName))
                {
                    heroHitPoints.Add(heroName, hP);
                    heroManaPoints.Add(heroName, mP);
                }
            }

            input = Console.ReadLine();
            command00 = input.Split(" - ");

            while (command00[0] != "End")
            {

                switch(command00[0])
                {
                    case "CastSpell":
                        {
                            string heroName = command00[1];
                            int manaPointsNeeded = int.Parse(command00[2]);
                            string spellName = command00[3];

                            if (heroManaPoints[heroName] >= manaPointsNeeded)
                            {
                                heroManaPoints[heroName] -= manaPointsNeeded;
                                Console.WriteLine($"{heroName} has successfully cast {spellName} and now has {heroManaPoints[heroName].ToString()} MP!");
                            }
                            else if (heroManaPoints[heroName] < manaPointsNeeded)
                            {
                                Console.WriteLine($"{heroName} does not have enough MP to cast {spellName}!");
                            }
                            break;
                        }

                    case "TakeDamage":
                        {
                            string heroName = command00[1];
                            int damage = int.Parse(command00[2]);
                            string attacker = command00[3];

                            heroHitPoints[heroName] -= damage;

                            if (heroHitPoints[heroName] > 0)
                            {
                                Console.WriteLine($"{heroName} was hit for {damage} HP by {attacker} and now has {heroHitPoints[heroName]} HP left!");
                            }
                            else
                            {
                                Console.WriteLine($"{heroName} has been killed by {attacker}!");
                                heroHitPoints.Remove(heroName);
                                heroManaPoints.Remove(heroName);
                            }
                            break;
                        }

                    case "Recharge":
                        {
                            string heroName = command00[1];
                            int mpToRecharge = int.Parse(command00[2]);


                            int amountorecover = 200 - heroManaPoints[heroName];
                            heroManaPoints[heroName] += mpToRecharge;
                            
                            if (heroManaPoints[heroName] > 200)
                            {
                                heroManaPoints[heroName] = 200;
                                Console.WriteLine($"{heroName} recharged for {Math.Abs(amountorecover)} MP!");
                            }
                            else
                            {
                                int amountrecovered = mpToRecharge;
                                Console.WriteLine($"{heroName} recharged for {amountrecovered} MP!");
                            }
                            break;
                        }

                    case "Heal":
                        {
                            string heroName = command00[1];
                            int hpToRecharge = int.Parse(command00[2]);

                            int amountorecover = 100 - heroHitPoints[heroName];
                            heroHitPoints[heroName] += hpToRecharge;

                            if (heroHitPoints[heroName] > 100)
                            {
                                
                                heroHitPoints[heroName] = 100;
                                Console.WriteLine($"{heroName} healed for {Math.Abs(amountorecover)} HP!");
                            }
                            else
                            {
                                int amountrecovered = hpToRecharge;
                                Console.WriteLine($"{heroName} healed for {amountrecovered} HP!");
                            }
                            break;
                        }
                }

                input = Console.ReadLine();
                command00 = input.Split(" - ");
            }

            foreach (var hero in heroHitPoints)
            {
                Console.WriteLine(hero.Key);
                Console.WriteLine($" HP: {heroHitPoints[hero.Key]}");
                Console.WriteLine($" MP: {heroManaPoints[hero.Key]}");
            }
        }
    }
}
