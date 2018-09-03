using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceTraderProject
{
    class Travel
    {
        public static Planets currentPlanet;

        public void DisplayPlanets()
        {
            Console.Clear();
            Planets[] Planet = new Planets[8];
            Planet[0] = new Planets("Earth", 0, 0);
            Planet[1] = new Planets("Pluto", 15, 20);
            Planet[2] = new Planets("Uranus", -10, -10);
            Planet[3] = new Planets("Planet Hollywood", 35, 30);
            Planet[4] = new Planets("Happy Planet", 100, -75);
            Planet[5] = new Planets("Alpha Centauri", 5, -10);
            Planet[6] = new Planets("M63", 16, 3);
            Planet[7] = new Planets("P34", -9, 6);

            currentPlanet = Planet[0];

            Console.WriteLine("Your current planet is : " + currentPlanet.PlanetName());
            Console.WriteLine("");
            Console.WriteLine("Type the number of the planet you want to go to");
            Console.WriteLine("");

            Console.WriteLine("1  " + Planet[0].PlanetName());
            Console.WriteLine("2  " + Planet[1].PlanetName());
            Console.WriteLine("3  " + Planet[2].PlanetName());
            Console.WriteLine("4  " + Planet[3].PlanetName());
            Console.WriteLine("5  " + Planet[4].PlanetName());
            Console.WriteLine("6  " + Planet[5].PlanetName());
            Console.WriteLine("7  " + Planet[6].PlanetName());
            Console.WriteLine("8  " + Planet[7].PlanetName());
            int travelChoice = int.Parse(Console.ReadLine());
        } 
        
        
    }
}
