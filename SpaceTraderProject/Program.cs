using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceTraderProject
{
    class Program
    {
        

        static void Main(string[] args)
        {

            BuyMenu PurchaseMenu = new BuyMenu();
            PurchaseMenu.DisplayInventory();
            SellMenu SaleMenu = new SellMenu();
            SaleMenu.DisplayInventory();

            
        }
    }
}
