using InterGalacticAirways.DataProvider;
using InterGalacticAirways.Entity;
using InterGalacticAirways.Interface;
using InterGalacticAirways.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace InterGalacticAirways
{
    class Program
    {
        static List<StarShip> starShipList = new List<StarShip>();
        static void Main(string[] args)
        {
            Console.WriteLine("Please wait...");
            GetStarship();
            Execute();

        }

        static void Execute()
        {
            Console.Write("Enter Passenger Count: ");
            string input = Console.ReadLine();
            int passenger = 0;

            if (!int.TryParse(input, out passenger) || passenger <= 0)
            {
                Console.WriteLine("Not an integer. Try again (Y/N)?");
                string tryInput = Console.ReadLine();
                if (tryInput.Equals("Y", StringComparison.CurrentCultureIgnoreCase))
                {
                    Execute();
                }

            }
            else
            {
                starShipList = starShipList.FindAll(a => passenger <=  a.Passengers );
                if (starShipList.Count() >= 0)
                {
                    foreach (var starShip in starShipList)
                    {
                        foreach (var pilot in starShip.pilots)
                        {
                            People people = GetPilot(pilot);
                            string strRes = starShip.name + " - " + people.name;
                            Console.WriteLine(strRes);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("No starship for that passenger count.");
                }
            }
            Console.WriteLine("That's all.");
            Console.ReadLine();


        }

        private static void GetStarship()
        {
            
            StarShipList starShips = new StarShipList();
            
            StarShipDataProvider sHipDataProvider = new StarShipDataProvider();
            starShipList = sHipDataProvider.GetAll();

        }

        private static People GetPilot( string url)
        {

            PeopleDataProvider peopleDataProvider = new PeopleDataProvider();
            return peopleDataProvider.GetSingle(url);

        }
    }
}
