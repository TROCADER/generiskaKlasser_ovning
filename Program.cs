using System.Collections.Generic;
using System;

namespace generiskaKlasser_ovning
{
    class Program
    {
        public static Dictionary<string, string> weakness = new Dictionary<string, string>();

        static void Main(string[] args)
        {
            // DictionaryShop();

            DictionaryElement();
        }

        private static void DictionaryShop()
        {
            int playerCoins = 100;
            Dictionary<string, int> dictionaryShop = new Dictionary<string, int>();

            dictionaryShop.Add("apple", 10);
            dictionaryShop.Add("cucumber", 20);
            dictionaryShop.Add("carrot", 101);

            while (true)
            {
                foreach (string key in dictionaryShop.Keys)
                {
                    System.Console.WriteLine(key + ": " + dictionaryShop[key] + " coins");
                }

                System.Console.WriteLine("\n\nWhat to buy?\nType the desiered object");
                string playerChoose = Console.ReadLine();

                while (dictionaryShop.ContainsKey(playerChoose) != true)
                {
                    System.Console.WriteLine("Item is not for purchase, please try again");
                    playerChoose = Console.ReadLine();
                }

                if (dictionaryShop[playerChoose] > playerCoins)
                {
                    System.Console.WriteLine("Item too expensive, you can not afford it");
                }

                else
                {
                    playerCoins -= dictionaryShop[playerChoose];
                    System.Console.WriteLine("Thanks for your purchase!");
                }

                System.Console.WriteLine("Coins left: " + playerCoins);

                System.Console.WriteLine("Enter N to stop program, or any other letter to continue");
                if (Console.ReadLine() == "n")
                {
                    break;
                }
                Console.Clear();
            }
        }

        private static void DictionaryElement()
        {
            weakness.Add("fire", "water");
            weakness.Add("water", "ice");
            weakness.Add("ice", "fire");

            Creature creature = new Creature();

            Console.ReadLine();
        }
    }
}
