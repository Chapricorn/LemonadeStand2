using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using lemonadeStand2;

namespace UnitTestLemonadeStand
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddingTwoItems()
        {
            Player player = new Player();
            Wallet wallet = new Wallet();
            Inventory inventory = new Inventory();
            Stand stand = new Stand();

            //Arrange
            double numberOfWater = 5;
            double numberOfLemon = 6;
            double totalExpense;

            //Act
            totalExpense = numberOfWater + numberOfLemon;

            //Assert

            Assert.AreEqual(numberOfWater + numberOfLemon, totalExpense);
        }

        [TestMethod]
        public void TotalPriceOfItems()
        {
            Player player = new Player();
            Wallet wallet = new Wallet();
            Inventory inventory = new Inventory();
            Stand stand = new Stand();

            //Arrange
            double PricePerWater = 1.25;
            double PricePerLemon = 0.25;
            double PricePerCup = 0.10;
            double PricePerSugar = 1.00;
            double PricePerIce = 0.05;
            double totalExpense;

            //Act
            totalExpense = PricePerWater + PricePerLemon + PricePerCup + PricePerSugar + PricePerIce;

            //Assert

            Assert.AreEqual(PricePerWater + PricePerLemon + PricePerCup + PricePerSugar + PricePerIce, totalExpense);
        }
        [TestMethod]
        public void NumberOfWatersBought()
        {
            Player player = new Player();
            Wallet wallet = new Wallet();
            Inventory inventory = new Inventory();
            Stand stand = new Stand();

            //Arrange
            double numberOfWater = 5;
            double PricePerWater = 1.25;
            double totalExpense;

            //Act
            totalExpense = numberOfWater * PricePerWater;

            //Assert

            Assert.AreEqual(numberOfWater * PricePerWater, totalExpense);
        }



        //[TestMethod]
        //public void lemonadesSold()
        //{
        //    Player player = new Player();
        //    Customer customer = new Customer();
        //    Stand stand = new Stand();
        //    Inventory inventory = new Inventory();
        //    Wallet wallet = new Wallet();
            

        //    //Arrange
        //    double cupsOfLemonadesSold;
        //    double pricePerCupOfLemonade = 0.50;
        //    double totalExpense;


        //    //Act
        //    player.SellLemonades();

        ////Assert

        // Assert.AreEqual(cupsOfLemonadesSold * pricePerCupOfLemonade, totalExpense);
        //}

    }

}
