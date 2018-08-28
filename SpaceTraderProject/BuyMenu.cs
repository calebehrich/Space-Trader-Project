using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceTraderProject
{
    class BuyMenu
    {
        public BuyMenu()
        {

        }

        private void DisplayMenuText()
        {
            Console.WriteLine("What would you like to buy?");
        }

        public List<string> Buying()
        {
            List<string> buy = new List<string>();
            string[] items = { "Gold", "Silver", "Dogs", "Wood", "Titanium", "Fruit",
                               "Birdseed", "Eagle", "Broken VolksWagen", "Car Parts",
                               "Silk", "Kittens", "Textiles", "Alligator",
                               "Case of Monsters", "Copenhagen", "School Supplies",
                               "Flux Capacitor" };
            buy.AddRange(items);
            return buy;
        }


    }
}
