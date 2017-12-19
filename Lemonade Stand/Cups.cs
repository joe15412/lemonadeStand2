using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Cups
    {
        //set cups cost a
        private double cupCost = .05;
        private string cupName;
       
        public double GetCost()
        {
            return cupCost;
        }
        public void setCupName()
        {
            cupName = "Cups";
        }
        public string getCupName()
        {
            return cupName;

        }
    }
}
