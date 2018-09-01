using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceTraderProject
{
    class MainMenu
    {
        public BuyMenu buyMenu = new BuyMenu();
        public SellMenu sellMenu = new SellMenu();
        public ShipGarage shipGarage = new ShipGarage();
        static public int userMoney = 10000;


        public void DisplayMenu()
        {           
            

            do
            {
                MenuInstructions();
                int userSelection = int.Parse(Console.ReadLine());
                switch (userSelection)
            {                
                case 1:
                        buyMenu.BoughtItems();                       
                        break;

                case 2:
                        sellMenu.SoldItems();                        
                        break;

                case 3:
                        shipGarage.DisplayGarage();                       
                        break;

                case 4:
                        return;

                default:
                        Console.WriteLine("Invalid Input");
                        break;
            }

            } while (true);

        }

        public void MenuInstructions()
        {
            Console.WriteLine("Whatcha tryin to do yo?");
            Console.WriteLine("Type 1 to buy");
            Console.WriteLine("Type 2 to sell");
            Console.WriteLine("Type 3 for SpaceShip Upgrade ");
            Console.WriteLine("Type 4 to quit game");
        }

        
    }

    
}
