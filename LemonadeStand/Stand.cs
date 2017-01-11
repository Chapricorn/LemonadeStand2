using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonadeStand2
{
    public class Stand
    {
        public double numberOfCups = 1;
        public double numberOfWaters = 1;
        public double numberOfLemons = 1;
        public double numberOfIce = 1;     
        public double numberOfSugar = 1;

        //public double pricePerCup = 0.75;

        public double PricePerWater;
        public double PricePerLemon;
        public double PricePerCup;
        public double PricePerSugar;
        public double PricePerIce;


        public Stand()
        {
            PricePerWater = 1.25;
            PricePerLemon = 0.25;
            PricePerCup = 0.10;
            PricePerSugar = 1.00;
            PricePerIce = 0.05;

        }
        
    }
}
    