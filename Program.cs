using System.Collections.Generic;
using System;

namespace generiskaKlasser_ovning
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            dictionary.Add("Apple", 10);
            dictionary.Add("Cucumber", 20);

            foreach (string key in dictionary.Keys)
            {
                System.Console.WriteLine(key + ": " + dictionary[key] + " coins");
            }

            Console.ReadLine();
        }
    }
}
