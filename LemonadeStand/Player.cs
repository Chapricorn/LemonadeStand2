using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonadeStand2
{
   public class Player
    {
        public string name;
        Wallet wallet;
        Stand stand;
        Inventory inventory;
        Recipe recipe;
        public double totalExpense;
        public double priceForEachCupOfLemonade;

        public Player()
        {
            wallet      = new Wallet();
            stand       = new Stand();
            inventory   = new Inventory();
            recipe      = new Recipe();
        }
        public void GetName()
        {
            Console.WriteLine("Please ENTER your Name \n");
            name = Console.ReadLine();
            if (name.Equals(""))
            {
                Console.WriteLine("Please ENTER your Name \n");
                GetName();                
            }
        }
        public void DisplayDailyResults()
        {
            Console.WriteLine(" \n Balance of supplies after Lemonades made: " );
            //foreach (Inventory item in SupplyBalance)
            {
                Console.WriteLine("  Balance of Cups: {0} ", inventory.balanceOfCups);
                Console.WriteLine("  Balance of Water Bottles: {0} ", inventory.balanceOfWaterBottles);
                Console.WriteLine("  Balance of Ice Cubes: {0} ", inventory.balanceOfIce);
                Console.WriteLine("  Balance of Lemons: {0} ", inventory.balanceOfLemons);              
                Console.WriteLine("  Balance of Sugar Cubes: {0} ", inventory.balanceOfSugarCubes);
                Console.WriteLine(" \n ");
                //Console.ReadLine();
            }
        }
        public void DisplayTotalBalance()
        {
            Console.WriteLine(" \n Total Expense = ${0} ", totalExpense);
            Console.WriteLine(" Current Balance = ${0} ", wallet.CurrentBalance);
            Console.WriteLine(" ");

        }
        public double BuyCups()
        {
            Console.WriteLine(" How many Cups do you want to buy? Need 15 Cups to start");

            try
            {
                double item = Convert.ToDouble(Console.ReadLine());
                if (wallet.CurrentBalance > stand.PricePerCup * item)
                {
                    wallet.CurrentBalance = wallet.CurrentBalance - (stand.PricePerCup * item);
                    inventory.balanceOfCups += (stand.numberOfCups * item);
                    //wallet.displayCurrentBalance();
                    //Console.WriteLine(" Total {0} Empty cups. \n", inventory.balanceOfCups);

                    // compute the total expense
                    totalExpense = totalExpense + stand.PricePerCup * item;
                    DisplayTotalBalance();


                }
                else if (wallet.CurrentBalance < stand.PricePerCup * item)
                {
                    Console.WriteLine(" Sorry {0} you don't have enough cash in your Wallet ", name);
                    BuyCups();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(" Invalid Entry ");
                Console.WriteLine(" Please use Numbers ONLY!");
                BuyCups();
            }

            return wallet.CurrentBalance;
        }
        public double BuyLemons()
        {
            Console.WriteLine(" How many lemons you want to buy? Need 5 Lemons to start");
            try
            {
                double item = Convert.ToDouble(Console.ReadLine());
                if (wallet.CurrentBalance > stand.PricePerLemon * item)
                {
                    wallet.CurrentBalance = wallet.CurrentBalance - (stand.PricePerLemon * item);
                    inventory.balanceOfLemons += (stand.numberOfLemons * item);
                    //wallet.displayCurrentBalance();
                    //Console.WriteLine(" Total  {0} Lemons. \n", inventory.balanceOfLemons);

                    // compute the total expense
                    totalExpense = totalExpense + stand.PricePerLemon * item;
                    DisplayTotalBalance();

                }
                else if (wallet.CurrentBalance < stand.PricePerLemon * item)
                {
                    Console.WriteLine(" Sorry {0} you don't have enough cash in your Wallet. ", name);

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(" Invalid Entry ");
                Console.WriteLine(" Please use Numbers ONLY! ");
                BuyLemons();
            }
            return wallet.CurrentBalance;
        }
        public double BuyWater()
        {
            Console.WriteLine(" How many Water bottles do you want to buy? Need 5 bottles to start  ");
            try
            {
                double item = Convert.ToDouble(Console.ReadLine());
                if (wallet.CurrentBalance > stand.PricePerWater * item)
                {
                    wallet.CurrentBalance = wallet.CurrentBalance - (stand.PricePerWater * item);
                    inventory.balanceOfWaterBottles += (stand.numberOfWaters * item);
                    //wallet.displayCurrentBalance();
                    //Console.WriteLine(" Total  {0} Bottles of water. \n", inventory.balanceOfWaterBottles);

                    // compute the total expense
                    totalExpense = totalExpense + stand.PricePerWater * item;
                    DisplayTotalBalance();

                }
                else if (wallet.CurrentBalance < stand.PricePerWater * item)
                {
                    Console.WriteLine(" Sorry {0} you don't have enough cash in your Wallet. ", name);

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(" Invalid Entry ");
                Console.WriteLine(" Please use Numbers ONLY! ");
                BuyWater();
            }

            return wallet.CurrentBalance;
        }
        public double BuyIce()
        {
            Console.WriteLine(" How many Ice Cubes do you want? Need 5 Ice Cubes to start ");
            try
            {
                double item = Convert.ToDouble(Console.ReadLine());

                if (wallet.CurrentBalance > stand.PricePerIce * item)
                {
                    wallet.CurrentBalance = wallet.CurrentBalance - (stand.PricePerIce * item);
                    inventory.balanceOfIce += (stand.numberOfIce * item);
                    //wallet.displayCurrentBalance();
                    //Console.WriteLine(" Total {0} Ice Cubes. \n", inventory.balanceOfIce);

                    // compute the total expense
                    totalExpense = totalExpense + stand.PricePerIce * item;
                    DisplayTotalBalance();

                }
                else if (wallet.CurrentBalance < stand.PricePerIce * item)
                {
                    Console.WriteLine(" Sorry {0} you don't have enough cash in your Wallet ", name);

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(" Invalid Entry ");
                Console.WriteLine(" Please use Numbers ONLY!");
                BuyIce();
            }
            return wallet.CurrentBalance;
        }

        public double BuySugars()
        {
            Console.WriteLine(" How many Sugar Cubes do you want to buy? Need 5 Sugar Cubes to start ");
            try
            {
                double item = Convert.ToDouble(Console.ReadLine());
                if (wallet.CurrentBalance > stand.PricePerSugar * item)
                {
                    wallet.CurrentBalance = wallet.CurrentBalance - (stand.PricePerSugar * item);
                    inventory.balanceOfSugarCubes += (stand.numberOfSugar * item);
                    //wallet.displayCurrentBalance();
                    //Console.WriteLine(" Total {0} Sugar Cubes. \n", inventory.balanceOfSugarCubes);

                    // compute the total expense
                    totalExpense = totalExpense + stand.PricePerCup * item;
                    DisplayTotalBalance();

                }
                else if (wallet.CurrentBalance < stand.PricePerSugar * item)
                {
                    wallet.displayCurrentBalance();
                    inventory.SupplyBalance();
                    Console.WriteLine(" Sorry {0} you don't have enough cash in your Wallet. ", name);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(" Invalid Entry ");
                Console.WriteLine(" Please use Numbers ONLY! ");
                BuySugars();
            }
            return wallet.CurrentBalance;
        }
        public Inventory Result = new Inventory();
        public List<Inventory> SupplyBalance = new List<Inventory>();

        public void MakeLemonades()

        {
            inventory.SupplyBalance();

            // save daily result inventory to a list
            Inventory supplies              = new Inventory();
            supplies.balanceOfCups          = inventory.balanceOfCups;
            supplies.balanceOfWaterBottles  = inventory.balanceOfWaterBottles;
            supplies.balanceOfLemons        = inventory.balanceOfLemons;
            supplies.balanceOfSugarCubes    = inventory.balanceOfSugarCubes;
            supplies.balanceOfIce           = inventory.balanceOfIce;
            supplies.totalCupsOfLemonades   = inventory.totalCupsOfLemonades;
            supplies.cupsOfLemonadesSold    = inventory.cupsOfLemonadesSold;
            // add daily inventory to a list
            SupplyBalance.Add(supplies);

            wallet.displayCurrentBalance();
            {
                {
                    inventory.totalCupsOfLemonades  = inventory.totalCupsOfLemonades    += 15;
                    inventory.balanceOfLemons       = inventory.balanceOfLemons         - 5;
                    inventory.balanceOfSugarCubes   = inventory.balanceOfSugarCubes     - 5;
                    inventory.balanceOfIce          = inventory.balanceOfIce            - 5;
                    inventory.balanceOfWaterBottles = inventory.balanceOfWaterBottles   - 5;
                    inventory.balanceOfCups         = inventory.balanceOfCups           - 15;

                    Console.WriteLine(" Good, You've Made {0} cup(s) of Lemonade(s) to Sell. \n", inventory.totalCupsOfLemonades);
                    }
             
                }
            }
             public void MakeMoreLemonades()
        {
            Console.WriteLine(" Want to make more Lemonades? Yes | No \n");
            string MakeMore = Console.ReadLine().ToLower();
            if (MakeMore == " Yes ")
            {
            }
            else if (MakeMore == " No ")
            {
                Console.WriteLine("Great Good luck on your sales! \n");
            }
            else
            {
                Console.WriteLine(" Invalid Entry! ");
                MakeMoreLemonades();
            }
        }
        public double SetPrice()
        {
            Console.WriteLine("Set a price for each Cup of your lemonades: ");
            try
            {
                double price = Convert.ToDouble(Console.ReadLine());

                wallet.PerCupOfLemonade = inventory.totalCupsOfLemonades * price;

                // Add total sell to the current balance
                wallet.CurrentBalance = wallet.CurrentBalance + wallet.PerCupOfLemonade;

                priceForEachCupOfLemonade = price;

                Console.WriteLine("Each cup of Lemonade cost: ${0}", price);
                Console.WriteLine("You have {0} cups of lemonade, if you sell all your lemonades you will make ${1}", inventory.totalCupsOfLemonades, wallet.PerCupOfLemonade);
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("\nINVALID ENTRY! Enter a dollar amount for price\n");
                SetPrice();
            }
            return wallet.PerCupOfLemonade;
        }

    }


}









