using MongoDB.API.Models.Concrete;

namespace MongoDB.API.Models
{
    public class Footballer : BaseEntity, IEntity
    {
        public string Name { get; set; }
        public Position Position { get; set; }
        public int Age { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public int Goals { get; set; }
        public int Assists { get; set; }
        public FootballerClub CurrentClub { get; set; }
        public FootballerClub[] PlayedClubs { get; set; }
        public string[] Citizenships { get; set; }
        
    }
}
