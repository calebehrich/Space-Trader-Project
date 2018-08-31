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

            MainMenu Menu = new MainMenu();
            do
            {
            Menu.DisplayMenu();
            } while (Menu.Exit == 1);

            Console.ReadLine();
   
        }
    }
}
