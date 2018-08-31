using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceTraderProject
{
    class MainMenu
    {
        BuyMenu PurchaseMenu = new BuyMenu();
        SellMenu SaleMenu = new SellMenu();
        ShipGarage ShipMenu = new ShipGarage();
        

        public void DisplayMenu()
        {
            Console.WriteLine("Whatcha tryin to do yo?");
            Console.WriteLine("Type 1 to buy");                  
            Console.WriteLine("Type 2 to sell");                 
            Console.WriteLine("Type 3 for SpaceShip Upgrade ");                  
            Console.WriteLine("Type 4 to quit game");
            int userSelection = int.Parse(Console.ReadLine());

            switch (userSelection)
            {
                case 1:
                    PurchaseMenu.DisplayInventory();
                    PurchaseMenu.BoughtItems();
                    break;

                case 2:
                    SaleMenu.DisplayInventory();
                    SaleMenu.SoldItems();
                    break;

                case 3:
                    ShipMenu.DisplayGarage();                   
                    break;
                case 4:
                    Console.WriteLine("GameOver");
                    Console.ReadLine();
                    break;

                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }
        }

        
    }

    
}
