using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MongoDB.API.Models
{
    public abstract class BaseEntity : IBaseEntity
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
    }
}
