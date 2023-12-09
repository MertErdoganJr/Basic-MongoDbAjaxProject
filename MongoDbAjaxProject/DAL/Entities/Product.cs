using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MongoDbAjaxProject.DAL.Entities
{
    public class Product
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? ProductID { get; set; }
        public string? ProductName { get; set; }
        public int Stock { get; set; }

        [BsonRepresentation(BsonType.Decimal128)]
        public decimal Price { get; set; }
        public string CategoryID { get; set; }
    }
}
