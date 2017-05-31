using System;
using System.Collections.Generic;
using System.Linq;


namespace SetsOfElements
{
    class ElementSets
    {
        static void Main()
        {
            int[] numbersInColections= Console.ReadLine().Split().Select(int.Parse).ToArray();
            HashSet<int>numbersN = new HashSet<int>();
            HashSet<int>numbersM = new HashSet<int>();
            for (int i = 0; i < numbersInColections[0]; i++)
            {
                int num = int.Parse(Console.ReadLine());
                numbersN.Add(num);
            }

            for (int i = 0; i < numbersInColections[1]; i++)
            {
                int num = int.Parse(Console.ReadLine());
                numbersM.Add(num);
            }

            numbersM.IntersectWith(numbersN);
            foreach (var num in numbersM)
            {
                Console.Write($"{num} ");
            }
        }
    }
}
