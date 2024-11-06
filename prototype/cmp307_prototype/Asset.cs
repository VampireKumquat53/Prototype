using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cmp307_prototype
{
  public class Asset
  {
    [BsonGuidRepresentation(GuidRepresentation.Standard)]
    public Guid assetID { get; set; }
    public string deviceName { get; set; }
    public string model { get; set; }
    public string manufacturer { get; set; }
    public string type { get; set; }
    public string ipAddress { get; set; }
    public DateTime purchaseDate { get; set; }
    public string note { get; set; }


    DBConnection db = new DBConnection();
    public void addAsset(Asset asset)
    {
      MongoClient client = db.ConnectDB();

      var collection = client.GetDatabase("cmp307").GetCollection<BsonDocument>("asset");

      BsonDocument doc = new BsonDocument
      {
        { "deviceName", asset.deviceName},
        { "model", asset.model},
        { "manufacturer", asset.manufacturer},
        { "type", asset.type},
        { "ipAddress", asset.ipAddress},
        { "purchaseDate", asset.purchaseDate},
        { "note", asset.note}
      };

      collection.InsertOne(doc);
    }
  }
}
