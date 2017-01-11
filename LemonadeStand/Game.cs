using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonadeStand2
{
    public class Game
    {
        Player player;
        Weather weather;
        Inventory inventory;
        Day day;
        Customer customer;
        Wallet wallet;
        Stand stand = new Stand();

        // create a new customer list
        List<Customer> customerList = new List<Customer>();
        public Game()
        {
            player      = new Player();
            wallet      = new Wallet();
            weather     = new Weather();           
            day         = new Day();
            customer    = new Customer();
            inventory   = new Inventory();

        }

        public void RunGame()
        {
            DisplayWelcome();
            PlayerIntroduced();
            DisplayRule();
            DisplaySupplyPrice();
            player.GetName();
            StartGame();
            PrintCustomerList();
        }

        public void PrintCustomerList()
        {
            double totalSellPerDay = 0;
            foreach (Customer cust in customerList)
            {
                Console.WriteLine(" Day: {0} Customer: {1} Amount made: ${2}", cust.Day, cust.CustID, cust.TotalCost);
                totalSellPerDay = totalSellPerDay + cust.TotalCost;
            }
            Console.WriteLine("Total Sales: ${0}", totalSellPerDay);

            Console.ReadLine();
        }

        public void DisplayWelcome()
        {
            Console.WriteLine(" Good Morning and Welcome to your Neighborhood's Lemonade Stand. \n");

        }

        public void PlayerIntroduced()
        {
            player = new Player();
            Console.WriteLine(" My name is Master ShiFu. I see you want to sell Lemonades, Let's get started. \nPress ENTER to continue. \n", player.name);
            Console.ReadLine();
        }
        public void DisplayRule()
        {
            Console.WriteLine(" Do you want to see the rules? Yes | No \n");
            string choice = Console.ReadLine().ToLower();
            switch (choice)
            {
                case "yes":
                    Rules rule = new Rules();
                    rule.GameRules();
                    break;
                case "no":
                    Console.WriteLine(" Kool, I'm assuming you already know the rules. Now let's get Started. \n");
                    break;
                default:
                    Console.WriteLine(" Please ENTER 'Yes' | 'No' ");
                    DisplayRule();
                    break;
            }
        }

        public void DisplaySupplyPrice()
        {
            Console.WriteLine(" Here are the Supplies needed and the Prices of each Items ");
            Console.WriteLine(" You will need 5 bottles of water, 4 lemons, 5 Sugar Cubes, 5 Ice cubes, and 15 empty cups to make 10 Cups of Lemonades. ");
            Console.WriteLine(" Cost Per each item: Cup: $0.10, Water bottle: $1.00, Lemon: $0.25, Sugar Cube: $.05, Ice Cube: $0.05 each.");
            Console.WriteLine(" Press ENTER to Continue. \n");
            Console.ReadLine();
        }

        public void GetSupply()
        {
            player.totalExpense = 0; //initialize total expense to zero before buying anything

            player.BuyCups();
            player.BuyWater();
            player.BuyLemons();           
            player.BuyIce();
            player.BuySugars();
            player.MakeLemonades();
            player.SetPrice();

            // Display the daily result from DailyResults
            player.DisplayDailyResults();
        }

        public void StartGame()
        {
            while (day.day1 < day.day7)
            {
                // initialize the number cup for each day to zero before the next day sell
                day.days();
                Console.WriteLine(" It's Day {0} of 7 to sell your Lemonades", day.day1);
                weather.WeatherForecast();
                GetSupply();
                //day.CustomerPerDay(weather, player, wallet, inventory,customer); 

                double numberOfCustomer = day.CustomerPerDay(weather, player, wallet, inventory);

                // Logic for sell lemonade to customers per day

                for (int i = 0; i < numberOfCustomer; i++)
                {
                    Console.WriteLine("Number of Lemonades sold to customer(s): {0} " , i );

                    int cups = Convert.ToInt32(Console.ReadLine());
                    Customer cust = new Customer();

                    cust.CustID = i;
                    cust.Day = day.day1;

                    if (inventory.totalCupsOfLemonades > inventory.cupsOfLemonadesSold)
                    {
                        Console.WriteLine("Sorry, All Lemonades Sold Out!! \n");
                       
                    }
                    if (inventory.cupsOfLemonadesSold >= inventory.totalCupsOfLemonades)
                    {
                    }
                    // need to add if statement to check if the number cup entered greater then the total cup available,
                    // write warning message and set cust.TotalCost equal to zero, else compute cust.TotalCost.
                    // TODO: need to find out where is the total available cup value from before i add this logic


                    cust.TotalCost = cups * player.priceForEachCupOfLemonade;

                    // Add total sell to current balance of the wallet
                    wallet.CurrentBalance = wallet.CurrentBalance + cust.TotalCost;

                    // Add this customer to the customer list
                    customerList.Add(cust);
                    
                }
                Console.WriteLine(" List of Customers ", day.day1);

                PrintCustomerList();

                Console.Clear();
              
            }
            day.day1++;
           
        }
        // print the customer list
      

}


}


