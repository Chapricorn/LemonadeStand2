using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonadeStand2
{
    class Wallet
    {
        public double CurrentBalance;
        public double PerCupOfLemonade;
        public double CurrentRevenue;

        public Wallet()
        {
            CurrentBalance = 30.00;
            PerCupOfLemonade = 0;
            CurrentRevenue = 0;

        }
        public double LeftOverCash()
        {
            return CurrentBalance;
        }
        public void displayCurrentBalance()
        {
            Console.WriteLine(" Your cash balance ${0} ", CurrentBalance);
        }
    }
}
    