using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonadeStand2
{
     class Day
    {
        Inventory inventory;
        Wallet wallet;

        Stand stand;
        //public double numberOfCustomer;
        //Weather weather;
        public double day1;
        public double day7;
        public double numberOfCustomer;

        public Day()
        {
          
            inventory   = new Inventory();
            wallet = new Wallet();

            //weather     = new Weather();
            //numberOfCustomer = 0;
            stand = new Stand();
            day1 = 0;
            day7 = 7;

        }

        public double days()
        {
            day1 += 1;
            return day1;
        }

        public double CustomerPerDay(Weather weather, Player player, Wallet wallet, Inventory inventory)
        {
            Random theCustomer = new Random();
            numberOfCustomer = theCustomer.Next(1, 10);

            if (weather.temperatures == 1 && weather.temperature <= 20 && wallet.PerCupOfLemonade <= .75 && inventory.totalCupsOfLemonades > 0)
            {
                inventory.totalCupsOfLemonades = inventory.totalCupsOfLemonades -= numberOfCustomer;
            }
            else if (weather.temperatures == 1 && weather.temperature > 20 && wallet.PerCupOfLemonade <= 1.00 && inventory.totalCupsOfLemonades > 0)
            {

                inventory.totalCupsOfLemonades = inventory.totalCupsOfLemonades -= numberOfCustomer;
            }

            else if (weather.temperatures == 2 && weather.temperature <= 15 && wallet.PerCupOfLemonade <= 0.75 && inventory.totalCupsOfLemonades > 0)
            {

                inventory.totalCupsOfLemonades = inventory.totalCupsOfLemonades -= numberOfCustomer;
            }
            else if (weather.temperatures == 2 && weather.temperature > 15 && wallet.PerCupOfLemonade <= 0.50 && inventory.totalCupsOfLemonades > 0)
            {

                inventory.totalCupsOfLemonades = inventory.totalCupsOfLemonades -= numberOfCustomer;
            }

            else if (weather.temperatures == 3 && weather.temperature <= 10 && wallet.PerCupOfLemonade <= 0.35 && inventory.totalCupsOfLemonades > 0)
            {
                inventory.totalCupsOfLemonades = inventory.totalCupsOfLemonades -= numberOfCustomer;

            }
            else if (weather.temperatures == 3 && weather.temperature > 10 && wallet.PerCupOfLemonade <= 0.25 && inventory.totalCupsOfLemonades > 0)
            {
                inventory.totalCupsOfLemonades = inventory.totalCupsOfLemonades -= numberOfCustomer;

            }

            Console.WriteLine("You have {0} customers today \n Press ENTER to Continue....", numberOfCustomer, inventory.totalCupsOfLemonades);
            wallet.CurrentRevenue = wallet.PerCupOfLemonade - (stand.PricePerWater + stand.PricePerLemon + stand.PricePerCup + stand.PricePerSugar + stand.PricePerIce);
            Console.ReadLine();
            return numberOfCustomer;
        }


    }
}
