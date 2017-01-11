using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandDiagram
{
  
    class Player
    {
        
        
        public Recipe recipe;
        public Inventory inventory;
        public Money money;
        decimal balanceOfMoney;
        decimal remainingBalance;
        int cupPurchased;
        int cupUsed;
        int gallonOfWaterUsed;
        int gallonOfWaterPurchased;
        int iceCubePurchased;
        int iceCubeUsed;
        int lemonPurchased;
        int lemonUsed;
        int name;
        int sugarCubePurchased;
        int sugarCubeUsed;

       public Player()
        {
            recipe = new Recipe();
            inventory = new Inventory();
            money = new Money();
        }
        public bool BuyCup()
        {
            return true;
        }
        public bool BuyGallonOfWater()
        {
            return true;
        }
        public bool BuyIceCube()
        {
            return true;
        }
        public bool BuyLemon()
        {
            return true;
        }
        public bool BuySugarCube()
        {
            return true;
        }
        public bool MakeLemonade()
        {
            return true;
        }
        public bool UseCup()
        {
            return true;
        }
        public bool UseGallonOfWater()
        {
            return true;
        }
        public bool UseIceCube()
        {
            return true;
        }
        public bool UseLemon()
        {
            return true;
        }
        public bool UseSugarCube()
        {
            return true;
        }
        public void BuyIngredients()
        {

        }
        public void GetPlayerName()
        {

        }
        public void ShowMOney()
        {

        }
    }

}