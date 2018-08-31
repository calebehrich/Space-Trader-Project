using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceTraderProject
{
    class BuyMenu
    {
        MainMenu goBack = new MainMenu();
        static Random rnd = new Random();
        MoneyMath Money = new MoneyMath();
        int goldPrice = rnd.Next(100, 1001);
        int silverPrice = rnd.Next(100, 1001);
        int titaniumPrice = rnd.Next(100, 1001);

        public BuyMenu()
        {

        }
  
        public string DisplayInventory()
        {

            Console.WriteLine("What would you like to buy?"); 
            Console.WriteLine("Type 1 for Gold");                  
            Console.WriteLine("Type 2 for Silver");
            Console.WriteLine("Type 3 for Titanium");
            Console.WriteLine("Type 4 for Main Menu");
            Console.WriteLine(" ");
            string itemList = "Gold"     + "   " + "$" + (goldPrice)   + "\n" +
                              "Silver"   + "   " + "$" + (silverPrice) + "\n" +
                              "Titanium" + "   " + "$" + (titaniumPrice);
   
            Console.WriteLine(itemList);
            return itemList;
        }

        public void BoughtItems()
        {
            string userSelection = Console.ReadLine();

            if (userSelection == "1")
            {
                Money.MoneyAddition(goldPrice, 1);
                Console.WriteLine(Money.userMoney);
            }
            else if (userSelection == "2")
            {
                Money.MoneyAddition(silverPrice, 1);
                Console.WriteLine(Money.userMoney);
            }
            else if (userSelection == "3")
            {
                Money.MoneyAddition(titaniumPrice, 1);
                Console.WriteLine(Money.userMoney);
            }
            else if (userSelection == "4")
            {
                goBack.DisplayMenu();                
            }
            else
            {
                Console.WriteLine("Invalid input. Please make a selection");
            }
        }

    }
}
