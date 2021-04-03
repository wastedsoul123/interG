using InterGalacticAirways.Entity;
using InterGalacticAirways.Interface;
using InterGalacticAirways.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterGalacticAirways.DataProvider
{
    public class StarShipDataProvider: BaseDataProvider
    {

        public List<StarShip> GetAll()
        {

            IRepository<StarShipList> starshipRepo = new Repository<StarShipList>(client);
            List<StarShip> returnedObj = new List<StarShip>();
            string next = null;

            do
            {
                var ship = starshipRepo.GetByUrl(next);
                returnedObj.AddRange(ship.Result.results);
                next = ship.Result.next;

            } while (!string.IsNullOrEmpty(next));

            return returnedObj;

        }

    }
}
