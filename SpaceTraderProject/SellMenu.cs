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
        int goldPrice = rnd.Next(100, 1001);
        int silverPrice = rnd.Next(100, 1001);
        int titaniumPrice = rnd.Next(100, 1001);
        

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
            Console.WriteLine(" ");

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
            Console.Clear();   
            DisplayInventory();
                try
                {
                    int userSelection = int.Parse(Console.ReadLine());

                    switch (userSelection)
                    {
                        case 1:
                            Console.Clear();
                            MoneyAddition(goldPrice, MainMenu.goldCargo);                                                       
                            break;

                        case 2:
                            Console.Clear();
                            MoneyAddition(silverPrice, MainMenu.silverCargo);                                                       
                            break;

                        case 3:
                            Console.Clear();
                            MoneyAddition(titaniumPrice, MainMenu.titaniumCargo);                                                        
                            break;

                        case 4:
                            return;


                        default:
                            Console.WriteLine("Invalid Input");
                            break;

                    }
                }
                catch (System.FormatException)
                {

                    Console.WriteLine("Please enter one of the options displayed to you");
                    Console.WriteLine("Press 'Enter' to continue");
                    Console.ReadLine();
                }           

            } while (true);
        }

        public void MoneyAddition(int i, double cargo)
        {
            if (cargo > 0)
            {
                MainMenu.userMoney += i;
                cargo -= 1;
                MainMenu.userCurrentCargo -= 1;
                Console.WriteLine("Your cargo balance for this cargo type is: " + cargo);
                Console.WriteLine("Your Money balance is: $" + MainMenu.userMoney);
                Console.WriteLine("Your Cargo Balance is: " + MainMenu.userCurrentCargo);
                Console.WriteLine("Press 'Enter' to continue");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("You don't have any cargo of this type");
                Console.WriteLine("Press 'Enter' to continue");
                Console.ReadLine();
            }
            
        }
       
       
    }
}
