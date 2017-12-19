using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    public class Sugar
    {
        double sugarCost = .25;
        string sugarName;
        private string sugar;

        // set cost of sugar

        public double GetCost()
        {
            return sugarCost;
        }
        public void setSugarName()
        {
            sugarName = "Sugar";
        }
        public string getSugar()
        {
            return sugar;
        }
    }
}

