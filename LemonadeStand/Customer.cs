using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonadeStand2
{
    public class Customer
    {
        public int CustID;
        public double TotalCost;
        public double Day;

       
        public void BuyLemonade(int cupcupsOfLemonadesSold, double pricePerCup)
        {
            TotalCost = cupcupsOfLemonadesSold * pricePerCup;
        }
    }
}