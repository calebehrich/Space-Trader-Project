using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceTraderProject
{
    class SpaceShips
    {
      
        public void Basic()
        {
            ChooseSpeed();
            Console.WriteLine("Speed must be between 1 and 4");
        }

        public void Intermediate()
        {
            ChooseSpeed();
            Console.WriteLine("Speed must be between 1 and 6");
        }
        
        public void Advanced()
        {
            ChooseSpeed();
            Console.WriteLine("Speed must be between 1 and 9");
        }

        public void ChooseSpeed()
        {
            Console.WriteLine("Select a speed for your SpaceShip");
            int selectedSpeed = int.Parse(Console.ReadLine());
            if (selectedSpeed > 0 && selectedSpeed <= 4)
            {
                int speed = selectedSpeed;
            }
            else
            {
                Console.WriteLine("You can't choose that speed");
            }
        }
    }
}
