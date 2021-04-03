using InterGalacticAirways.Entity;
using InterGalacticAirways.Helper;
using InterGalacticAirways.Interface;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace InterGalacticAirways.Repository
{

    public class Repository<T> : IRepository<T> where T : BaseEntity 
    {
        /// <summary>
        /// The default  URL for needed data.
        /// </summary>
        /// 
        private const string Api = "https://swapi.dev/api/";

        private T entity;
        

        private readonly HttpClient client;


        public Repository(HttpClient client)
        {
            this.client = client;
            this.entity = EntityInstance<T>.Instance();
        }

 

        public async Task<T> GetByUrl(string url=null)
        {
            T entity = null;
            url = string.IsNullOrEmpty(url) ? Api + this.entity.GetPath() : url;
                HttpResponseMessage response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    entity = await response.Content.ReadAsAsync<T>();
                }


            return entity;
        }


        



    }
}
