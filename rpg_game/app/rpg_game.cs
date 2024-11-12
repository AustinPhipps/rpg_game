using System;

namespace TurnBased
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerHp = 40;
            int enemyHp = 20;

            int playerAttack = 5;
            int enemyAttack = 7;

            int healAmount = 5;

            Random random = new Random();

            while (playerHp > 0 && enemyHp > 0)
            {
                //Player Turn
                Console.WriteLine("--Player Turn!--");
                Console.WriteLine("Player HP = " + playerHp + ". Enemy HP = " + enemyHp + ".");
                Console.WriteLine("--Enter 'a' to attack or 'h' to heal.");

                string choice = Console.ReadLine();

                if (choice == "a")
                {
                    enemyHp -= playerAttack;
                    Console.WriteLine("Player attacks enemy for " + playerAttack + " damage!");
                }
                else
                {
                    playerHp += healAmount;
                    Console.WriteLine("Player resores " + healAmount + " health!");
                }

                //Enemy Turn
                if (enemyHp > 0)
                {
                    Console.WriteLine("-- Enemy Turn --");
                    Console.WriteLine("Player HP = " + playerHp + ". Enemy HP = " + enemyHp + ".");
                    int enemyChoice = random.Next(0, 2);

                    if (enemyChoice == 0)
                    {
                        playerHp -= enemyAttack;
                        Console.WriteLine("Enemy attacks for " + enemyAttack + " damage!");
                    }
                    else
                    {
                        enemyHp += healAmount;
                        Console.WriteLine("Enemy restores " + healAmount + " health!");
                    }
                }
            }
            if (playerHp > 0)
            {
                Console.WriteLine("You won!");
            }
            else
            {
                Console.WriteLine("You lost...");
            }
        }
    }
}