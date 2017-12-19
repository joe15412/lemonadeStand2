using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Ice
          {    //ice costs
              double iceCost = .05;
                 string iceName;
            
            public double GetCost()
            {
                return iceCost;
            }
            public void setIceName()
            {
                iceName = "Ice";
            }
            public string getIceName()
            {
                return iceName;
            }
        }
    }

