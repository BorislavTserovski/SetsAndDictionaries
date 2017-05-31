using System;
using System.Collections.Generic;
using System.Linq;


namespace HandsOfCards
{
    class CardHands
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(new[] {':',' ',','},StringSplitOptions.RemoveEmptyEntries).ToArray();

            Dictionary<string,List<int>> people = new Dictionary<string, List<int>>();
           
            while (input[0]!="JOKER")
            {
                List<int> cards = new List<int>();
                string name = input[0];
                for (int i = 1; i < input.Length; i++)
                {
                    Card temp = new Card();
                    temp.Name = input[i];
                    cards.Add(temp.CardToInt());
                }
                people[name] = cards;
                input = Console.ReadLine().Split(new[] { ':', ' ', ',' },StringSplitOptions.RemoveEmptyEntries).ToArray();
            }

            foreach (var person in people)
            {
                Console.WriteLine($"{person.Key} : {person.Value.Sum()}");
            }
           

        }

        public class Card
        {
            public string Name { get; set; }


            public int CardToInt()
            {
               
                int total = 0;
                int type = 0;
                int power = 0;
                switch (this.Name[0])

                {
                    case '2':
                        type = 2;
                        break;
                    case '3':
                        type = 3;
                        break;
                    case '4':
                        type = 4;
                        break;
                    case '5':
                        type = 5;
                        break;
                    case '6':
                        type = 6;
                        break;
                    case '7':
                        type = 7;
                        break;
                    case '8':
                        type = 8;
                        break;
                    case '9':
                        type = 9;
                        break;
                    case '1':
                        type = 10;
                        break;
                    case 'J':
                        type = 11;
                        break;
                    case 'Q':
                        type = 12;
                        break;
                    case 'K':
                        type = 13;
                        break;
                    case 'A':
                        type = 14;
                        break;
                }
                switch (this.Name[this.Name.Length - 1])
                {
                    case 'S':
                        power = 4;
                        break;
                    case 'H':
                        power = 3;
                        break;
                    case 'D':
                        power = 2;
                        break;
                    case 'C':
                        power = 1;
                        break;


                }
                total = type * power;
              
                return total;
            }
        }
    }
}
