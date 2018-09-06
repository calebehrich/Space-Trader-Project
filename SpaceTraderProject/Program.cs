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
            GameStory Story = new GameStory();
            MainMenu Menu = new MainMenu();
            Story.DisplayGameStory();
            Console.ReadLine();
            Console.Clear();
            Story.DisplayGameDirections();
            Console.ReadLine();
            Console.Clear();
            Menu.DisplayMenu();
            Console.Clear();
            Console.WriteLine("GAME OVER!");
            Console.ReadLine();
   
        }
    }
}
