using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceTraderProject
{
    class SellMenu
    {
        ShuffleInfo sellPrice = new ShuffleInfo();

        public SellMenu()
        {

        }

        public string DisplayInventory()
        {

            int goldPrice = 0;
            int silverPrice = 0;
            int titaniumPrice = 0;

            Console.WriteLine("What would you like to sell?" + "\n" +
                               "Type Gold, Silver, or Titanium to sell the item");

            string itemList = "Gold"     + "   " + "$" + (sellPrice.ItemPrice(goldPrice))   + "\n" +
                              "Silver"   + "   " + "$" + (sellPrice.ItemPrice(silverPrice)) + "\n" +
                              "Titanium" + "   " + "$" + (sellPrice.ItemPrice(titaniumPrice));

            Console.WriteLine(itemList);
            return itemList;
        }
    }
}
