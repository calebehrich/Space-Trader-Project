using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceTraderProject
{
    class ShuffleInfo
    {
        Random rnd = new Random();

        public ShuffleInfo()
        {
            
        }

        public int ItemPrice(int thing)
        {
            int i = rnd.Next(100, 1001);
            thing = i;
            return thing;
        }







    }
}
