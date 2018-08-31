using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceTraderProject
{
    class SellMenu
    {
        static Random rnd = new Random();
        MoneyMath Money = new MoneyMath();       
        int goldPrice = rnd.Next(100, 1001);
        int silverPrice = rnd.Next(100, 1001);
        int titaniumPrice = rnd.Next(100, 1001);


        public SellMenu()
        {

        }

        public string DisplayInventory(SellMenu sellMenu)
        {

            

            Console.WriteLine("What would you like to sell?" + "\n" +
                               "Type Gold, Silver, or Titanium to sell the item");

            string itemList = "Gold"     + "   " + "$" + (goldPrice)   + "\n" +
                              "Silver"   + "   " + "$" + (silverPrice) + "\n" +
                              "Titanium" + "   " + "$" + (titaniumPrice);

            Console.WriteLine(itemList);
            return itemList;
        }

    

        public void SoldItems(SellMenu sellMenu)
        { 
             string userSelection = Console.ReadLine();

             if (userSelection == "Gold")
             {
                 Money.MoneyAddition(goldPrice, 1);
             }
             else if (userSelection == "Silver")
             {
                 Money.MoneyAddition(silverPrice, 1);
             }
             else if (userSelection == "Titanium")
             {
                 Money.MoneyAddition(titaniumPrice, 1);
             }
             else
             {
                 Console.WriteLine("Invalid input. Please make a selection");
             }
    }
}
}
