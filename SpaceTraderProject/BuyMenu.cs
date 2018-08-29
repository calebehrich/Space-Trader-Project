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

  
        public string DisplayInventory()
        {
 
            int goldPrice = 0;
            int silverPrice = 0;
            int titaniumPrice = 0;
            int goldCargo = 0;
            int silverCargo = 0;
            int titaniumCargo = 0;
            string itemList = "Gold" + "   " + "$" + (goldPrice=ItemPrice()) + "   Cargo weight: " + (goldCargo = CargoSpace()) + "\n" +
                              "Silver" + "   " + "$" + (silverPrice=ItemPrice()) + "   Cargo weight: " + (silverCargo = CargoSpace()) + "\n" +
                              "Titanium" + "   " + "$" + (titaniumPrice=ItemPrice()) + "   Cargo weight: " + (titaniumCargo = CargoSpace());
                          

            


            Console.WriteLine(itemList);
            return itemList;
        }

        public int ItemPrice()
        {
            Random rnd = new Random();
            int i =rnd.Next(100, 1001);
            System.Threading.Thread.Sleep(50);
            return i; 
        }

        public int CargoSpace()
        {
            Random rnd = new Random();
            int i = rnd.Next(1, 10);
            System.Threading.Thread.Sleep(50);
            return i;
        }
    }
}
