using System;
using System.Collections.Generic;
using System.Linq;


namespace FixEmails
{
    class Emails
    {
        static void Main()
        {
            string inputName = Console.ReadLine();
            Dictionary<string, string> people = new Dictionary<string, string>();
            while (inputName!="stop")
            {
                for (int i = 0; i < 1; i++)
                {
                  string inputEmail = Console.ReadLine().ToLower();
                    people[inputName] = inputEmail;
                }
                inputName = Console.ReadLine();
            }
            foreach (var kvp in people)
            {
                if (!kvp.Value.EndsWith("us",StringComparison.InvariantCulture)
                    ||kvp.Value.EndsWith("uk",StringComparison.InvariantCulture))
                {
                    Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
                }
            }
        }
    }
}
