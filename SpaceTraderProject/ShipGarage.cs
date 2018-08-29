using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceTraderProject
{
    class ShipGarage
    {
        public void DisplayGarage()
        {
            Console.WriteLine("Pick a ship to buy");

            string shipList = "Type 1 for Intermediate"    + "   "  + "$18000"  + "\n" +
                              "Max Speed:6  "   + "Max Cargo:50  "  + "Max Fuel:25 " +
                              "Type 2 for Advanced"        + "   "  + "$100000" + "\n" +
                              "Max Speed:9  "   + "Max Cargo:100  " + "Max Fuel:50 ";

            Console.WriteLine(shipList);
            int userSelection = int.Parse(Console.ReadLine());

            switch (userSelection)
            {
                case 1:
                    //Intermediate Ship
                    break;

                case 2:
                    //Advanced Ship
                    break;

                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }
        }
    }
}
