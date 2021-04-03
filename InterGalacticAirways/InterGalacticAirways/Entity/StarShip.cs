using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterGalacticAirways.Entity
{
    public class StarShip 
    {


        [JsonProperty]
        public string name { get; set; }

        [JsonProperty(PropertyName = "passengers")]
        public string passengersRaw { get; set; }

        public List<string> pilots { get; set; }

        public int Passengers
        {
            get
            {
                int n;
                return int.TryParse(passengersRaw, out n) ? n : 0;
            }
        }

    }
    public class StarShipList : BaseEntity
    {
        private const string UrlToEntity = "starships";
        protected override string Path
        {
            get
            {
                return UrlToEntity;

            }

        }
        [JsonProperty]
        public string next { get; set; }

        [JsonProperty]
        public List<StarShip> results { get; set; }


    }
}
