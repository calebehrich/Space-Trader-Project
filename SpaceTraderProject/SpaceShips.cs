using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceTraderProject
{
    class SpaceShips
    {
        public SpaceShips()
        {

        }

        public void TryIntermediateSpaceshipPurchase(int cost)
        {
            if (MainMenu.userMoney > cost)
            {
                MainMenu.userMoney -= cost;
                MainMenu.userMaxCargo = 100;
                MainMenu.MaxFuel = 25;
                Console.WriteLine("You purchased this ship for $" + cost);
                Console.WriteLine("");
                ChooseSpeedIntermediate();
            }
            else
            {
                Console.WriteLine("You don't have enough money to purchase this ship!");
                Console.WriteLine("Press 'Enter' to continue");
                Console.ReadLine();
            }
        }

        public void TryAdvancedSpaceshipPurchase(int cost)
        {
            if (MainMenu.userMoney > cost)
            {
                MainMenu.userMoney -= cost;
                MainMenu.userMaxCargo = 150;
                MainMenu.MaxFuel = 50;
                Console.WriteLine("You purchased this ship for $" + cost);
                Console.WriteLine("");
                ChooseSpeedAdvanced();
            }
            else
            {
                Console.WriteLine("You don't have enough money to purchase this ship!");
                Console.WriteLine("Press 'Enter' to continue");
                Console.ReadLine();
            }
        }


        public void ChooseSpeedBasic()
        {
            
            Console.WriteLine("Select a speed for your SpaceShip");
            Console.WriteLine("Speed must be between 1 and 4");
            int selectedSpeed = int.Parse(Console.ReadLine());
            if (selectedSpeed > 0 && selectedSpeed <= 4)
            {
                MainMenu.ShipSpeed = selectedSpeed;
                Console.Clear();
                Console.WriteLine("Your ship now has a speed of: " + selectedSpeed);
            }
            else
            {
                Console.WriteLine("You can't choose that speed");
            }
        }

        public void ChooseSpeedIntermediate()
        {
            Console.WriteLine("Select a speed for your SpaceShip");
            Console.WriteLine("Speed must be between 1 and 6");
            int selectedSpeed = int.Parse(Console.ReadLine());
            if (selectedSpeed > 0 && selectedSpeed <= 6)
            {
                MainMenu.ShipSpeed = selectedSpeed;
                Console.Clear();
                Console.WriteLine("Your ship now has a speed of: " + selectedSpeed);
            }
            else
            {
                Console.WriteLine("You can't choose that speed");
            }
        }

        public void ChooseSpeedAdvanced()
        {
            Console.WriteLine("Select a speed for your SpaceShip");
            Console.WriteLine("Speed must be between 1 and 9");
            int selectedSpeed = int.Parse(Console.ReadLine());
            if (selectedSpeed > 0 && selectedSpeed <= 9)
            {
                MainMenu.ShipSpeed = selectedSpeed;
                Console.Clear();
                Console.WriteLine("Your ship now has a speed of: " + selectedSpeed);
            }
            else
            {
                Console.WriteLine("You can't choose that speed");
            }
        }
    }
}
