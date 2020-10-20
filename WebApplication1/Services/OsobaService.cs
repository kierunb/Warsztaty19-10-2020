using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Services
{
    public interface IOsobaService
    {
        string GetById(int id);
    }


    public class OsobaService : IOsobaService
    {
        public string GetById(int id)
        {
            return $"Osoba o id: {id}";
        }
    }
}
