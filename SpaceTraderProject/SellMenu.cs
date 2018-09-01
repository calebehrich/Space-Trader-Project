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
        int Exit = 0;

        public SellMenu()
        {

        }

        public string DisplayInventory()
        {
            Console.WriteLine("What would you like to sell?");
            Console.WriteLine("Type 1 for Gold");
            Console.WriteLine("Type 2 for Silver");
            Console.WriteLine("Type 3 for Titanium");
            Console.WriteLine("Type 4 for Main Menu");

            string itemList = "Gold"     + "   " + "$" + (goldPrice)   + "\n" +
                              "Silver"   + "   " + "$" + (silverPrice) + "\n" +
                              "Titanium" + "   " + "$" + (titaniumPrice);

            Console.WriteLine(itemList);
            return itemList;
        }

    

        public void SoldItems()
        {
            do
            {
                
             DisplayInventory();   
            
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

            } while (Exit != 0);
        }
    }
}
