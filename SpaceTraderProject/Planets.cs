using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceTraderProject
{
    class Planets
    {        
        string name;
        double xcord;
        double ycord;

        public Planets(string planetName, double planetXCord, double planetYCord)

        {
            name = planetName;
            xcord = planetXCord;
            ycord = planetYCord;
            
        }

        public void CalculateDistance()
        {
            double distance = Math.Sqrt(Math.Pow(xcord, 2) + Math.Pow(ycord, 2));
            
        }
    }
}
