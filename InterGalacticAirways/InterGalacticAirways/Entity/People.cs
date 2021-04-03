using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterGalacticAirways.Entity
{
    public class People:BaseEntity 
    {
        private const string UrlToEntity = "people";
        protected override string Path
        {
            get
            {
                return UrlToEntity;

            }

        }

        [JsonProperty]
        public string name { get; set; }


    }

}
