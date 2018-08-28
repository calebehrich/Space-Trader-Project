using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceTraderProject
{
    class MethodsRandom
    {
        public MethodsRandom()
        {

        }

        public void BuyItems(List<string> buy)
        {
            Random rnd = new Random();
            buy.OrderBy(x => rnd.Next()).Take(5);          
        }
       
            
            


    }
}
