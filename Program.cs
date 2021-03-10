using System.Collections.Generic;
using System;

namespace generiskaKlasser_ovning
{
    class Program
    {
        static void Main(string[] args)
        {
            DictionaryShop();
        }

        private static void DictionaryShop()
        {
            int playerCoins = 100;
            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            dictionary.Add("apple", 10);
            dictionary.Add("cucumber", 20);
            dictionary.Add("carrot", 101);

            while (true)
            {
                foreach (string key in dictionary.Keys)
                {
                    System.Console.WriteLine(key + ": " + dictionary[key] + " coins");
                }

                System.Console.WriteLine("\n\nWhat to buy?\nType the desiered object");
                string playerChoose = Console.ReadLine();

                while (dictionary.ContainsKey(playerChoose) != true)
                {
                    System.Console.WriteLine("Item is not for purchase, please try again");
                    playerChoose = Console.ReadLine();
                }

                if (dictionary[playerChoose] > playerCoins)
                {
                    System.Console.WriteLine("Item too expensive, you can not afford it");
                }

                else
                {
                    playerCoins -= dictionary[playerChoose];
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
            
        }
    }
}
