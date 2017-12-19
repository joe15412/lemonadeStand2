using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    //welcome screen
    //show inventory
    //show wallet balance
    //make menu
    //add randomconditions
    //store
    //inventory
    //loop for day
    //restart game?

    class UserInterFace
    {
        public Random random;
        public Weather weather;
        public player player;
        public store store;
        public day day;
        public int randomValue;

        public Game()
        {
            random = new Random();
            weather = new day.weather.randomConditions();
            player = new Player();
            store = new Store();
            day = new Day(random);
        }
     
        }
        public void Welcome()
        {
            Console.WriteLine("Welcome");
            Console.WriteLine("You have $20.00, purchase ingredients from the store.");
            Console.WriteLine("Please hit [enter] to go to the main menu.");
            Console.ReadLine();
            Console.Clear();
                     
        }
        public void Weather()
        {
            day.weather.randomConditions();
        }
        public void MainMenu()
        {
            Console.WriteLine("Check inventory then show your skills. ");
            Console.WriteLine("1: Weather Condition");
        Console.WriteLine("2. See Wallet");
        Console.WriteLine("3. Go To Store.");
        Console.WriteLine("4. Recipe");
            string value = Console.ReadLine();
            switch (value)
            {
              
                //Weather
                case "1":
                    Console.Clear();
                    day.weather.randomConditions();
                    Console.WriteLine("please hit [enter] to go to the main menu.");
                    Console.ReadLine();
                    Console.Clear();
                   
                    break;

                //Wallet
                case "2":
                    Console.Clear();
                    player.wallet.balance();
                    Console.ReadLine();
                    Console.Clear();
                    break;

                //store
                case "3":
                    Console.Clear();
                    store.inventory;
                    Console.ReadLine();
                    Console.Clear();
                    break;

               
                //pitchers
                case "4":
                    Console.Clear();
                    player.Inventory();
                    player.recipe.();
                    Console.ReadLine();
                    Console.Clear();
                    break;

                //Set price and Play Game
                case "5":
                    Console.Clear();
                    day.PriceOfCup();
                    for (int d = 1; d <= 7; d++)
                    {

                        for (int i = 0; i < day; i++)
                        {
                            day.customers[i].DeterminesCustomerBuys(day.randomconditions, day, randomValue);
                        }
                        day.Lemonade();
                        
                    }
                    player.wallet.Earnings();
                    Console.ReadLine();
                  
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine("try again");
                    break;
            }
        }
       
        }
        public void RestartGame()
        {
            Console.WriteLine("Replay the game? [Y] or [N]");
            string answer = Console.ReadLine().ToUpper();
            switch (answer)
            {
                case "Y":
                    Welcome();
                    break;
                case "N":
                    Exit()
                    break;
                default:
                    Console.WriteLine("Try Again");
                    break;

            }
        }


    }
    }
}
