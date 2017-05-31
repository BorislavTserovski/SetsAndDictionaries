using System;
using System.Collections.Generic;
using System.Linq;


namespace PopulationCounter
{
    class Startup
    {
        static void Main()
        {
            string input = Console.ReadLine();
            Dictionary<string,Dictionary<string,long>> countriesInfo = new Dictionary<string, Dictionary<string, long>>();
            while (input!="report")
            {
                string[] tokens = input.Split('|');
                string country = tokens[1];
                string city = tokens[0];
               long population = long.Parse(tokens[2]);

                if (!countriesInfo.ContainsKey(country))
                {
                    countriesInfo[country]=new Dictionary<string, long>();
                    if (!countriesInfo[country].ContainsKey(city))
                    {
                        countriesInfo[country][city] = population;
                    }
                }
                else
                {
                    countriesInfo[country][city] = population;
                }
                input = Console.ReadLine();
            }
            foreach (var country in countriesInfo.OrderByDescending(c=>c.Value.Values.Sum()))
            {
                Console.WriteLine($"{country.Key} (total population: {country.Value.Values.Sum()})");
                foreach (var city in country.Value.OrderByDescending(c=>c.Value))
                {
                    Console.WriteLine($"=>{city.Key}: {city.Value}");
                }
            }
        }
    }
}
