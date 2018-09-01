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
        int Exit = 0;
        

        public void DisplayMenu()
        {           
            Console.WriteLine("Whatcha tryin to do yo?");
            Console.WriteLine("Type 1 to buy");                  
            Console.WriteLine("Type 2 to sell");                 
            Console.WriteLine("Type 3 for SpaceShip Upgrade ");                  
            Console.WriteLine("Type 4 to quit game");
            int userSelection = int.Parse(Console.ReadLine());

            do
            {
   
            switch (userSelection)
            {                
                case 1:
                    buyMenu.DisplayInventory(buyMenu);
                    break;

                case 2:
                    sellMenu.SoldItems();
                    break;

                case 3:
                    shipGarage.DisplayGarage(shipGarage);                   
                    break;

                case 4:
                    Exit += 1;
                    break;

                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }

            } while (Exit != 0);

        }

        
    }

    
}
