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

            Console.Clear();
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
                try
                {
                int userSelection = int.Parse(Console.ReadLine());
                switch (userSelection)
                {
                    case 1:                        
                       Console.Clear();
                       MoneySubtraction(goldPrice);                      
                       AddSpecificCargo(MainMenu.goldCargo);                       
                        break;

                    case 2:           
                       Console.Clear();
                       MoneySubtraction(silverPrice);                       
                       AddSpecificCargo(MainMenu.goldCargo);                      
                        break;

                    case 3:            
                       Console.Clear();
                       MoneySubtraction(titaniumPrice);                       
                       AddSpecificCargo(MainMenu.goldCargo);                      
                        break;

                    case 4:            
                        return;             
 
                    default:
                       Console.WriteLine("Invalid input. Please make a selection");
                        break;
                }
            }
                catch (System.FormatException)
            {

                Console.WriteLine("Please enter one of the options displayed to you");
                Console.WriteLine("Press 'Enter' to continue");
                Console.ReadLine();
            }
        } while (true) ;
        }

        public void MoneySubtraction(int i)
        {
            if (MainMenu.userMoney < i)
            {
                Console.WriteLine("You don't have enough money to buy this item");
                Console.WriteLine("Press 'Enter' to continue");
                Console.ReadLine();
            }
            else
            {
                MainMenu.userMoney -= i;
            }
            
        }

        public void AddSpecificCargo(double cargo)
        {
            if (MainMenu.userCurrentCargo < MainMenu.userMaxCargo)
            {
                cargo += 1;
                MainMenu.userCurrentCargo += 1;
                Console.WriteLine("Your cargo balance for this cargo type is: " + cargo);
                Console.WriteLine("Your Money balance is: $" + MainMenu.userMoney);
                Console.WriteLine("Your Cargo Balance is: " + MainMenu.userCurrentCargo);
                Console.WriteLine("Press 'Enter' to continue");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Not enough cargo space");
                Console.WriteLine("Press 'Enter' to continue");
                Console.ReadLine();
            }
        }


    }
}
