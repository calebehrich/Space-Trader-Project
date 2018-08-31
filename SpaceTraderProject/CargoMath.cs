using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceTraderProject
{
    class CargoMath
    {
        public int userCargo = 50;

        public CargoMath()
        {

        }
         
        public void CargoAddition(int k)
        {
            userCargo += k;
        }

        public void CargoSubtraction(int k)
        {
            userCargo -= k;
        }
    }
}
