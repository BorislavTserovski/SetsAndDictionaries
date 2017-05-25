using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot
{
    class Parking
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] {' ', ','},
                StringSplitOptions.RemoveEmptyEntries);

            var parking = new SortedSet<string>();
            while (input[0]!="END")
            {
                switch (input[0])
                {
                    case "IN": parking.Add(input[1]);
                        break;
                    case "OUT": parking.Remove(input[1]);
                        break;
                }
                input = Console.ReadLine().Split(new char[] { ' ', ',' },
                    StringSplitOptions.RemoveEmptyEntries);
            }
            if (parking.Count>0)
            {
                foreach (var car in parking)
                {
                    Console.WriteLine(car);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
