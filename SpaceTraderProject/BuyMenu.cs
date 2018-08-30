using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceTraderProject
{
    class BuyMenu
    {
        ShuffleInfo buyPrice = new ShuffleInfo();
        MoneyMath Money = new MoneyMath();
        int goldPrice = 0;
        int silverPrice = 0;
        int titaniumPrice = 0;

        public BuyMenu()
        {

        }
  
        public string DisplayInventory()
        {
 
            int goldPrice = 0;
            int silverPrice = 0;
            int titaniumPrice = 0;

            Console.WriteLine("What would you like to buy?" + "\n" +
                               "Type Gold, Silver, or Titanium to purchase the item");

            string itemList = "Gold"     + "   " + "$" + (buyPrice.ItemPrice(goldPrice))   + "\n" +
                              "Silver"   + "   " + "$" + (buyPrice.ItemPrice(silverPrice)) + "\n" +
                              "Titanium" + "   " + "$" + (buyPrice.ItemPrice(titaniumPrice));
   
            Console.WriteLine(itemList);
            return itemList;
        }

        public void BoughtItems()
        {
            string userSelection = Console.ReadLine();

            if (userSelection == "Gold")
            {
                Money.MoneyAddition(goldPrice);
            }
            else if (userSelection == "Silver")
            {
                Money.MoneyAddition(silverPrice);
            }
            else if (userSelection == "Titanium")
            {
                Money.MoneyAddition(titaniumPrice);
            }
            else
            {
                Console.WriteLine("Invalid input. Please make a selection");
            }
        }

    }
}
