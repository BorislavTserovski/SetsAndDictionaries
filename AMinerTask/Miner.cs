using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMinerTask
{
    class Miner
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string,decimal>resources = new Dictionary<string, decimal>();
            while (input!="stop")
            {
                for (int i = 0; i < 1; i++)
                {
                    decimal quanity = decimal.Parse(Console.ReadLine());
                    if (!resources.ContainsKey(input))
                    {
                        resources[input] = quanity;
                    }
                    else
                    {
                        resources[input] += quanity;
                    }
                }
                input = Console.ReadLine();
            }
            foreach (var kvp in resources)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
