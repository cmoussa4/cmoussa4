using System;
using System.Collections.Generic;


namespace revision
{
    class Program
    {

        static void Main(string[] args)
        {
            //Generator

            Random random = new Random();
            int decision;
            int decision2;
            int decision3;
            int decision4;
            bool playeralive = true;
            int heals = 0;
            int attacks = 0;

            //player stats
            int playerhealth = 30;
            int playerattack = 5;
            int playerheal = 2;

            //Grunt stats
            int grunthealth = 10;
            int gruntattack = 3;
            int gruntheal = 2;

            //Warrior stats
            int Warriorhealth = 15;
            int Warriorattack = 5;
            int Warriorheal = 1;

            //Knight stats
            int Knighthealth = 20;
            int Knightattack = 7;
            int Knightheal = 2;

            //Minatour stats
            int Minotaurhealth = 25;
            int Minotaurattack = 9;
            int Minotaurheal = 3;
            Console.WriteLine("Welcome to gladiator Battle, slay your enemy in this turn based combat game! your first enemy is a Grunt!\npress [1] to attack or [2] to heal");
            while (playerhealth > 0 && grunthealth > 0)
            {
                decision = int.Parse(Console.ReadLine());
                if (decision == 1)
                {
                    attacks++;
                    Console.WriteLine("You choose to attack!");
                    grunthealth -= playerattack;
                    Console.WriteLine("Player Health: " + playerhealth + " Grunt Health: " + grunthealth + "\n----------------");
                }
                else if (decision == 2)
                {
                    heals++;
                    Console.WriteLine("You choose to heal!");
                    playerhealth += playerheal;
                    Console.WriteLine("Player Health: " + playerhealth + " Grunt Health: " + grunthealth + "\n----------------");
                }
                else
                {
                    Console.WriteLine("Error");
                    Console.WriteLine("Player Health: " + playerhealth + " Grunt Health: " + grunthealth + "\n----------------");
                }

                int gruntdecision = random.Next(1, 3);
                if (grunthealth > 0)
                {
                    if (gruntdecision == 1)
                    {
                        Console.WriteLine("Grunt chooses to attack!");
                        playerhealth -= gruntattack;
                        Console.WriteLine("Player Health: " + playerhealth + " Grunt Health: " + grunthealth + "\n----------------");
                    }
                    else if (gruntdecision == 2)
                    {
                        Console.WriteLine("Grunt chooses to heal!");
                        grunthealth += gruntheal;
                        Console.WriteLine("Player Health: " + playerhealth + " Grunt Health: " + grunthealth + "\n----------------");
                    }
                }


            }
            if (playerhealth > 0)
            {
                Console.WriteLine("You slayed your first opponent!");
                playeralive = true;
            }
            else if (grunthealth > 0)
            {
                Console.WriteLine("You have been slain...");
                playeralive = false;
            }

            if (playeralive)
            {
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("You have won your first battle warrior, pick a reward before your next opponent");
                Console.WriteLine("Press [1] for the magic apple(gives you some health)\npress [2] for a sword upgrade(upgrades your attack)");
                int pickreward = int.Parse(Console.ReadLine());

                if (pickreward == 1)
                {
                    Console.WriteLine("You chose the magic apple!");
                    playerhealth += 3;
                    Console.WriteLine("The magic apple heals some of your battle wounds\nPlayer Health:" + playerhealth);
                }
                else if (pickreward == 2)
                {
                    Console.WriteLine("You chose the sword upgrade!");
                    playerattack += 1;
                    Console.WriteLine("Your sword does " + playerattack + " Damage now");
                }
                else
                {
                    Console.WriteLine("You choose nothing");
                }
            }
            Console.WriteLine("-----------------------------------\nYour next opponent is a Warrior prepare to battle!\npress [1] to attack or [2] to heal");
            while (playerhealth > 0 && Warriorhealth > 0)
            {
                decision2 = int.Parse(Console.ReadLine());
                if (decision2 == 1)
                {
                    attacks++;
                    Console.WriteLine("You choose to attack!");
                    Warriorhealth -= playerattack;
                    Console.WriteLine("Player Health: " + playerhealth + " Warrior Health: " + Warriorhealth + "\n----------------");
                }
                else if (decision2 == 2)
                {
                    heals++;
                    Console.WriteLine("You choose to heal!");
                    playerhealth += playerheal;
                    Console.WriteLine("Player Health: " + playerhealth + " Warrior Health: " + Warriorhealth + "\n----------------");
                }
                else
                {
                    Console.WriteLine("Error");
                    Console.WriteLine("Player Health: " + playerhealth + " Warrior Health: " + Warriorhealth + "\n----------------");
                }

                int warriordecision = random.Next(1, 3);
                if (Warriorhealth > 0)
                {
                    if (warriordecision == 1)
                    {
                        Console.WriteLine("Warrior chooses to attack!");
                        playerhealth -= Warriorattack;
                        Console.WriteLine("Player Health: " + playerhealth + " Warrior Health: " + Warriorhealth + "\n----------------");
                    }
                    else if (warriordecision == 2)
                    {
                        Console.WriteLine("Warrior chooses to heal!");
                        Warriorhealth += Warriorheal;
                        Console.WriteLine("Player Health: " + playerhealth + " Warrior Health: " + Warriorhealth + "\n----------------");
                    }
                }


            }
            if (playerhealth > 0)
            {
                Console.WriteLine("You slayed your Second opponent!");
                playeralive = true;
            }
            else if (Warriorhealth > 0)
            {
                Console.WriteLine("You have been slain...");
                playeralive = false;
            }

            if (playeralive)
            {
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("You have survived 2 rounds in the arena! you have shown great skill, pick another reward before your next opponent");
                Console.WriteLine("Press [1] for the magic apple(gives you some health)\npress [2] for a sword upgrade(upgrades your attack)");
                int pickreward2 = int.Parse(Console.ReadLine());

                if (pickreward2 == 1)
                {
                    Console.WriteLine("You chose the magic apple!");
                    playerhealth += 3;
                    Console.WriteLine("The magic apple heals some of your battle wounds\nPlayer Health:" + playerhealth);
                }
                else if (pickreward2 == 2)
                {
                    Console.WriteLine("You chose the sword upgrade!");
                    playerattack += 1;
                    Console.WriteLine("Your sword does " + playerattack + " Damage now");
                }
                else
                {
                    Console.WriteLine("You choose nothing");
                }
            }
            Console.WriteLine("-----------------------------------\nYour next opponent is a Knight prepare to battle!\npress [1] to attack or [2] to heal");
            while (playerhealth > 0 && Knighthealth > 0)
            {
                decision3 = int.Parse(Console.ReadLine());
                if (decision3 == 1)
                {
                    attacks++;
                    Console.WriteLine("You choose to attack!");
                    Knighthealth -= playerattack;
                    Console.WriteLine("Player Health: " + playerhealth + " Knight Health: " + Knighthealth + "\n----------------");
                }
                else if (decision3 == 2)
                {
                    heals++;
                    Console.WriteLine("You choose to heal!");
                    playerhealth += playerheal;
                    Console.WriteLine("Player Health: " + playerhealth + " Knight Health: " + Knighthealth + "\n----------------");
                }
                else
                {
                    Console.WriteLine("Error");
                    Console.WriteLine("Player Health: " + playerhealth + " Knight Health: " + Knighthealth + "\n----------------");
                }

                int knightdecision = random.Next(1, 3);
                if (Knighthealth > 0)
                {
                    if (knightdecision == 1)
                    {
                        Console.WriteLine("Knight chooses to attack!");
                        playerhealth -= Knightattack;
                        Console.WriteLine("Player Health: " + playerhealth + " Knight Health: " + Knighthealth + "\n----------------");
                    }
                    else if (knightdecision == 2)
                    {
                        Console.WriteLine("Knight chooses to heal!");
                        Knighthealth += Knightheal;
                        Console.WriteLine("Player Health: " + playerhealth + " Knight Health: " + Knighthealth + "\n----------------");
                    }
                }


            }
            if (playerhealth > 0)
            {
                Console.WriteLine("You slayed your Third opponent!");
                playeralive = true;
            }
            else if (Knighthealth > 0)
            {
                Console.WriteLine("You have been slain...");
                playeralive = false;
            }
            if (playeralive)
            {
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("You have survived 3 rounds in the arena! you are one of the best warriors we have had!, pick one last reward before your final opponent");
                Console.WriteLine("Press [1] for the magic apple(gives you some health)\npress [2] for a sword upgrade(upgrades your attack)");
                int pickreward3 = int.Parse(Console.ReadLine());

                if (pickreward3 == 1)
                {
                    Console.WriteLine("You chose the magic apple!");
                    playerhealth += 4;
                    Console.WriteLine("The magic apple heals some of your battle wounds\nPlayer Health:" + playerhealth);
                }
                else if (pickreward3 == 2)
                {
                    Console.WriteLine("You chose the sword upgrade!");
                    playerattack += 2;
                    Console.WriteLine("Your sword does " + playerattack + " Damage now");
                }
                else
                {
                    Console.WriteLine("You choose nothing");
                }
            }
            Console.WriteLine("-----------------------------------\nYour final opponent is the great Minotaur, no one has slain him! prepare to battle!\npress [1] to attack or [2] to heal");
            while (playerhealth > 0 && Minotaurhealth > 0)
            {
                decision4 = int.Parse(Console.ReadLine());
                if (decision4 == 1)
                {
                    attacks++;
                    Console.WriteLine("You choose to attack!");
                    Minotaurhealth -= playerattack;
                    Console.WriteLine("Player Health: " + playerhealth + " Minotaur Health: " + Minotaurhealth + "\n----------------");
                }
                else if (decision4 == 2)
                {
                    heals++;
                    Console.WriteLine("You choose to heal!");
                    playerhealth += playerheal;
                    Console.WriteLine("Player Health: " + playerhealth + " Minotaur Health: " + Minotaurhealth + "\n----------------");
                }
                else
                {
                    Console.WriteLine("Error");
                    Console.WriteLine("Player Health: " + playerhealth + " Minotaur Health: " + Minotaurhealth + "\n----------------");
                }

                int minotaurdecision = random.Next(1, 3);
                if (Minotaurhealth > 0)
                {
                    if (minotaurdecision == 1)
                    {
                        Console.WriteLine("Minotaur chooses to attack!");
                        playerhealth -= Minotaurattack;
                        Console.WriteLine("Player Health: " + playerhealth + " Minotaur Health: " + Minotaurhealth + "\n----------------");
                    }
                    else if (minotaurdecision == 2)
                    {
                        Console.WriteLine("Minotaur chooses to heal!");
                        Minotaurhealth += Minotaurheal;
                        Console.WriteLine("Player Health: " + playerhealth + " Minotaur Health: " + Minotaurhealth + "\n----------------");
                    }
                }


            }
            if (playerhealth > 0)
            {
                Console.WriteLine("You slayed your Final opponent!");
                playeralive = true;
            }
            else if (Minotaurhealth > 0)
            {
                Console.WriteLine("You have been slain...");
                playeralive = false;
            }

            if (playeralive)
            {
                Console.WriteLine("I......\nI can't believe it you are the greatest warrior that has ever stepped foot in this arena, you have earned your freedom!");

                Console.WriteLine("\n-------------------------------\nYOUR STATS AFTER COMPLETING THE GAME\nPlayer Health:" + playerhealth + " Sword Damage:" + playerattack + "\nHeals used:" + heals + " Amount of times you attacked:" + attacks + "\n-------------------------------\n");
            }
            Console.WriteLine("Thanks For Playing");



        }
    }
}
