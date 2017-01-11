using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonadeStand2
{
    class Program
    {
        static void Main(string[] args)
        {
            Game RunGame = new Game();
            RunGame.RunGame();
            Console.ReadKey();
        }
    }
}
