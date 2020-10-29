using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MongoDB.API.Models.Concrete
{
    public class FootballerClub
    {
        public string Name { get; set; }
        public int Championships { get; set; }
        public int YearOfEstablishment { get; set; }
    }
}
