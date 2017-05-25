using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

   
namespace CountSameValuesInArray
{
    
    class CountDoubleValues
    {
        static void Main()
        {
            double[] input = Console.ReadLine().Split(new char[]{' '},StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse).ToArray();
            SortedDictionary<double, int> kvp = new SortedDictionary<double, int>();
            

            for (int i = 0; i < input.Length; i++)
            {
                if (!kvp.ContainsKey(input[i]))
                {
                    kvp.Add(input[i],1);
                }
                else
                {
                    
                    kvp[input[i]]++;
                }
            }
            foreach (var pair in kvp)
            {
                Console.WriteLine($"{pair.Key} - {pair.Value} times");
            }
        }
    }
}
