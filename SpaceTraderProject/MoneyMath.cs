using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceTraderProject
{
    class MoneyMath
    {
        public int userMoney = 10000;

        public void MoneyAddition(int i, int k)
        {
            userMoney += (i*k);
        }

        public void MoneySubtraction(int i, int k)
        {
            userMoney -= (i*k);
        }
    }
}
