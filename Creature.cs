using System;
using System.Collections.Generic;

namespace generiskaKlasser_ovning
{
    public class Creature
    {
        public string name;
        public string weaknessTag = Program.weakness["fire"];

        public List<string> strings = new List<string>();

        public Creature()
        {
            strings.Add(name);
            strings.Add(weaknessTag);

            for (int i = 0; i < strings.Count; i++)
            {
                System.Console.WriteLine(strings[i]);
            }
        }
    }
}
