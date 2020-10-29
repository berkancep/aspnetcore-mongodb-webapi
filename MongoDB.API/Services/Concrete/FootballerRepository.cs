using MongoDB.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MongoDB.API.Services
{
    public class FootballerRepository : BaseRepository<Footballer>, IFootballerRepository
    {
        public FootballerRepository(IFootballMarketDatabaseSettings settings) : base(settings, "Footballers")
        {

        }
    }
}
