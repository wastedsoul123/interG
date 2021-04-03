using InterGalacticAirways.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterGalacticAirways.Interface
{
    public interface IRepository<T> where T : BaseEntity
    {

        Task<T> GetByUrl(string url = null);

    }
}
