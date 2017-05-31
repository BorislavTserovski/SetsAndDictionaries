using System;
using System.Collections.Generic;
using System.Linq;


namespace CountSymbols
{
    class CountingSymbols
    {
        static void Main()
        {
            string input = Console.ReadLine();
            Dictionary<char,int>letterCollection = new Dictionary<char, int>();
            for (int i = 0; i < input.Length; i++)
            {
                if (!letterCollection.ContainsKey(input[i]))
                {
                    letterCollection[input[i]] = 1;
                }
                else
                {
                    letterCollection[input[i]]++;
                }
            }
            foreach (var kvp in letterCollection.OrderBy(p=>p.Key))
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value} time/s");
            }
        }
    }
}
