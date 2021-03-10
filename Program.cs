using System.Collections.Generic;
using System;

namespace generiskaKlasser_ovning
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerCoins = 100;
            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            dictionary.Add("apple", 10);
            dictionary.Add("cucumber", 20);

            foreach (string key in dictionary.Keys)
            {
                System.Console.WriteLine(key + ": " + dictionary[key] + " coins");
            }

            System.Console.WriteLine("\n\nWhat to buy?\nType the desiered object");

            string playerChoose = Console.ReadLine();

            playerCoins -= dictionary[playerChoose];

            System.Console.WriteLine("Thanks for your purchase!\nCoins left: " + playerCoins);

            Console.ReadLine();
        }
    }
}
