using System;
using System.Collections.Generic;
using System.Linq;


namespace PhoneBook
{
    class Phonebook
    {
        static void Main()
        {
            Dictionary<string,string> book = new Dictionary<string, string>();
            List<string>searchings = new List<string>();
            string[] input = Console.ReadLine().Split(new char[] {'-'}, StringSplitOptions.RemoveEmptyEntries);
            while (input[0]!="search")
            {
                if (book.ContainsKey(input[0]))
                {
                    book[input[0]] = input[1];
                }
                book[input[0]] = input[1];
                input = Console.ReadLine().Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
            }
            input = Console.ReadLine().Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
            while (!input[0].Equals("stop"))
            {

                
                searchings.Add(input[0]);
                input = Console.ReadLine().Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (var person in searchings)
                {
                    if (book.ContainsKey(person))
                    {
                        Console.WriteLine($"{person} -> {book.First(p=>p.Key.Equals(person)).Value}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {person} does not exist.");
                    }
                }
            
            
        }
    }
}
