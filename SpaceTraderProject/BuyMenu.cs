using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceTraderProject
{
    class BuyMenu
    {
        
        static Random rnd = new Random();         
        int goldPrice = rnd.Next(100, 1001);
        int silverPrice = rnd.Next(100, 1001);
        int titaniumPrice = rnd.Next(100, 1001);
       

        public BuyMenu()
        {

        }
  
        public void DisplayInventory()
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
                
            
        }

        public void BoughtItems()
        {
            do
            {
                DisplayInventory();
                string userSelection = Console.ReadLine();

            if (userSelection == "1")
            {
                MoneySubtraction(goldPrice, 1);
                CargoAddition(1);
                Console.WriteLine(MainMenu.userMoney);                   
            }
            else if (userSelection == "2")
            {
                MoneySubtraction(silverPrice, 1);
                CargoAddition(1);
                Console.WriteLine(MainMenu.userMoney);
            }
            else if (userSelection == "3")
            {
                MoneySubtraction(titaniumPrice, 1);
                CargoAddition(1);
                Console.WriteLine(MainMenu.userMoney);
            }
            else if (userSelection == "4")
            {
                    return;             
            }
            else
            {
                Console.WriteLine("Invalid input. Please make a selection");
            }
            } while (true) ;
        }

        public double MoneySubtraction(int i, int k)
        {
            MainMenu.userMoney -= (i * k);
            return MainMenu.userMoney;
        }

        public double CargoAddition(int k)
        {
            return MainMenu.userCargo += k;
        }


    }
}
