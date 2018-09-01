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
                
            DisplayInventory();

            int userSelection = int.Parse(Console.ReadLine());

                switch (userSelection)
                {
                    case 1:
                        Console.Clear();
                        MoneyAddition(goldPrice, 1);
                        CargoSubtraction(1);
                        Console.WriteLine("Your new money balance is: $" + MainMenu.userMoney);
                        Console.WriteLine("Your new Cargo Balance is: " + MainMenu.userCargo);
                        break;

                    case 2:
                        Console.Clear();
                        MoneyAddition(silverPrice, 1);
                        CargoSubtraction(1);
                        Console.WriteLine("Your new money balance is: $" + MainMenu.userMoney);
                        Console.WriteLine("Your new Cargo Balance is: " + MainMenu.userCargo);
                        break;

                    case 3:
                        Console.Clear();
                        MoneyAddition(titaniumPrice, 1);
                        CargoSubtraction(1);
                        Console.WriteLine("Your new money balance is: $" + MainMenu.userMoney);
                        Console.WriteLine("Your new Cargo Balance is: " + MainMenu.userCargo);
                        break;

                    case 4:
                        return;
                        

                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }


            } while (true);
        }

        public double MoneyAddition(int i, int k)
        {
            MainMenu.userMoney += (i * k);
            return MainMenu.userMoney;
        }

        public double CargoSubtraction(int k)
        {
            return MainMenu.userCargo -= k;
        }
    }
}
