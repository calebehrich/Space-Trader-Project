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
      
        public void Basic()
        {
            Console.WriteLine("Speed must be between 1 and 4");
            ChooseSpeedBasic();           
        }

        public void Intermediate()
        {
            Console.WriteLine("Speed must be between 1 and 6");
            ChooseSpeedIntermediate();            
        }
        
        public void Advanced()
        {
            Console.WriteLine("Speed must be between 1 and 9");
            ChooseSpeedAdvanced();            
        }

        public void ChooseSpeedBasic()
        {
            Console.WriteLine("Select a speed for your SpaceShip");
            int selectedSpeed = int.Parse(Console.ReadLine());
            if (selectedSpeed > 0 && selectedSpeed <= 4)
            {
                int speed = selectedSpeed;
                Console.Clear();
                Console.WriteLine("Your ship now has a speed of: " + speed);
            }
            else
            {
                Console.WriteLine("You can't choose that speed");
            }
        }

        public void ChooseSpeedIntermediate()
        {
            Console.WriteLine("Select a speed for your SpaceShip");
            int selectedSpeed = int.Parse(Console.ReadLine());
            if (selectedSpeed > 0 && selectedSpeed <= 6)
            {
                int speed = selectedSpeed;
                Console.Clear();
                Console.WriteLine("Your ship now has a speed of: " + speed);
            }
            else
            {
                Console.WriteLine("You can't choose that speed");
            }
        }

        public void ChooseSpeedAdvanced()
        {
            Console.WriteLine("Select a speed for your SpaceShip");
            int selectedSpeed = int.Parse(Console.ReadLine());
            if (selectedSpeed > 0 && selectedSpeed <= 9)
            {
                int speed = selectedSpeed;
                Console.Clear();
                Console.WriteLine("Your ship now has a speed of: " + speed);
            }
            else
            {
                Console.WriteLine("You can't choose that speed");
            }
        }
    }
}
