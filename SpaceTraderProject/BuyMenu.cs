using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceTraderProject
{
    class BuyMenu
    {
        MoneyMath Money = new MoneyMath();
        static Random rnd = new Random();         
        int goldPrice = rnd.Next(100, 1001);
        int silverPrice = rnd.Next(100, 1001);
        int titaniumPrice = rnd.Next(100, 1001);
        public int OtherExit = 0;

        public BuyMenu()
        {

        }
  
        public void DisplayInventory(BuyMenu buyMenu)
        {
            do
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
                BoughtItems();
            } while (OtherExit == 0);
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
                OtherExit += 1;             
            }
            else
            {
                Console.WriteLine("Invalid input. Please make a selection");
            }
        }

    }
}
