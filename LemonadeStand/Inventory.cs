using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonadeStand2
{
    public class Inventory : Stand
    {
        public double balanceOfCups         = 0;
        public double balanceOfWaterBottles = 0;
        public double balanceOfLemons       = 0;
        public double balanceOfSugarCubes   = 0;
        public double balanceOfIce          = 0;
        public double totalCupsOfLemonades  = 0;
        public double cupsOfLemonadesSold   = 0;
        

        public void SupplyBalance()
        {
            Console.WriteLine(" Your Total Items: {0} Empty Cups, {1} Bottles of Water, {2} Lemons, {3} Ice Cubes, {4} Sugar Cubes \n", balanceOfCups, balanceOfWaterBottles, balanceOfLemons, balanceOfIce, balanceOfSugarCubes);       
        }
        public double LemonadesMade()
        {
            return totalCupsOfLemonades;
        }
    }
}


