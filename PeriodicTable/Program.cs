﻿using System;
using System.Collections.Generic;
using System.Linq;


namespace PeriodicTable
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            HashSet<string> table = new HashSet<string>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < input.Length; j++)
                {
                    table.Add(input[j]);
                }
            }
            Console.WriteLine(string.Join(" ", table.OrderBy(e=>e)));
            
        }
    }
}
