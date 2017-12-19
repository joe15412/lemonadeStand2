using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    //set random types of weather
    public class Weather
    {
        static string[] weatherConditions = { "light rain", "heavy rain", "hazy", "sunny", "partly cloudy", "partly sunny", };
        private Func<string> randomConditions1;

        public void Weather(Func<string> randomConditions1)
        {
            this.randomConditions1 = randomConditions1;
            return;
        }

        static public int randomTemperature()
        {
            int minTemp = 50;
            int maxTemp = 99;
            Random random = new Random();
            int temp = random.Next(minTemp, maxTemp);
            return temp;
        }


        static public string randomConditions1()
        {
            Random random = new Random();
            string randomWeather = weatherConditions[random.Next(0, weatherConditions.Length)];


            return randomWeather;


        }
    }
}
