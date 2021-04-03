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
    public class PeopleDataProvider:BaseDataProvider
    {
        public People GetSingle(string url)
        {

            IRepository<People> peopleRepo = new Repository<People>(client);
            People returnedObj = new People();
            var people = peopleRepo.GetByUrl(url);
            returnedObj = people.Result;
            return returnedObj;

        }
    }
}
