using System;
using System.Collections.Generic;
using System.Linq;


namespace SoftuniParty
{
    class Party
    {
        static void Main()
        {
            string input = Console.ReadLine();
            SortedSet<string> invited  = new SortedSet<string>();
            while (input!="PARTY")
            {
                invited.Add(input);
                input = Console.ReadLine();
            }
            while (input!="END")
            {
                invited.Remove(input);
                input = Console.ReadLine();
            }
            Console.WriteLine(invited.Count);
            foreach (var person in invited)
            {
                Console.WriteLine(person);
            }
        }
    }
}
