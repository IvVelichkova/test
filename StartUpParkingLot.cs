using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ParkingLot
{
    class StartUpParkingLot
    {
        /*1.Parking Lot
        Write program that:
        Record car number for every car that enter in parking lot
        Remove car number when the car go out
        Input will be string in format [direction, carNumber]
        input end with string "END"
        Print the output with all car numbers which are in parking lot */
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var parking = new SortedSet<string>();

            while (input!="END")
            {
                var tokens = Regex.Split(input, "[, ]+", RegexOptions.IgnorePatternWhitespace);
                var operation = tokens[0];
                var numCurrent = tokens[1];

                switch (operation)
                {
                    case "IN":
                        parking.Add(numCurrent);
                        break;
                    case "OUT":
                        parking.Remove(numCurrent);
                        break;
                }
                input = Console.ReadLine();
            }
            if (parking.Count!=0)
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
