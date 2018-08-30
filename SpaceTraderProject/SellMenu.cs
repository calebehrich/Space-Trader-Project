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
        MoneyMath Money = new MoneyMath();
        int goldPrice = 0;
        int silverPrice = 0;
        int titaniumPrice = 0;


        public SellMenu()
        {

        }

        public string DisplayInventory()
        {

            

            Console.WriteLine("What would you like to sell?" + "\n" +
                               "Type Gold, Silver, or Titanium to sell the item");

            string itemList = "Gold"     + "   " + "$" + (sellPrice.ItemPrice(goldPrice))   + "\n" +
                              "Silver"   + "   " + "$" + (sellPrice.ItemPrice(silverPrice)) + "\n" +
                              "Titanium" + "   " + "$" + (sellPrice.ItemPrice(titaniumPrice));

            Console.WriteLine(itemList);
            return itemList;
        }

    

        public void SoldItems()
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
