using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Inventory
    { //buy inventory
        //track lemons, sugar ice cups, money
        static int lemons = 0;
        static int sugar = 0;
        static int ice = 0;
        static int cup = 0;
        static int money = 0;

        public static void addLemons(int amount)
        {
            lemons += amount;
        }
        public static void addSugar(int amount)
        {
            sugar += amount;
        }
        public static void addIce(int amount)
        {
            ice += amount;
        }
        public static void addCup(int amount)
        {
            cup += amount;
        }

        public static void addMoney(int amount)
        {
            money += amount;

        }
        public static int getMoney()
        {
            return money;
        }


    }
}
