using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace InterGalacticAirways.DataProvider
{
    public class BaseDataProvider
    {
        public static readonly HttpClient client = new HttpClient();

    }
}
