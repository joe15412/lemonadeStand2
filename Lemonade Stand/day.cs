using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{    //weather change
    //custumers change
    //price per weather conditions
    //set recipe
    class day
    {
        static string weatherConditions = Weather.randomConditions1();
        static public int temp = Weather.randomTemperature();

        public static double PriceModifier()
        {
            if (temp >= 50 && temp <= 59)
            {
                return .75;
            }
            else if (temp >= 60 && temp <= 69)
            {
                return .80;
            }
            else if (temp >= 70 && temp <= 79)
            {
                return .85;
            }
            else if (temp >= 80 && temp <= 89)
            {
                return 1.00;
            }
            else if (temp >= 90 && temp <= 99)
            {
                return 1.10;
            }
            return 1.0;
        }

        public static int numberOfCustomers()
        {

            switch (weatherConditions)
            {
                case "light rain":
                    return 35;
                case "heavy rain":
                    return 20;
                case "hazy":
                    return 50;
                case "sunny":
                    return 55;
                case "partly cloudy":
                    return 45;
                case "partly sunny":
                    return 40;

                default: return 50;
            }
        }

        internal class weather
        {
            internal class randomConditions : Weather
            {
            }
        }
    }
}
}
