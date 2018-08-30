using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceTraderProject
{
    class MoneyMath
    {
        int userMoney = 10000;

        public void MoneyAddition(int i)
        {
            userMoney += i;
        }

        public void MoneySubtraction(int i)
        {
            userMoney -= i;
        }
    }
}
