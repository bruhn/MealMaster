using MongoDB.Driver;

namespace MealMaster.Infrastructure.Mongo
{
    public abstract class MongoManager
    {
        private readonly MongoClient _client;

        protected MongoManager()
        {
            _client = new MongoClient("mongodb://mealmasteruser:Meal4Free@ds041758.mongolab.com:41758/mealmaster");
        }

        protected MongoDatabase Database
        {
            get
            {
                var server = _client.GetServer();
                var database = server.GetDatabase("mealmaster");
                return database;
            }
        }
    }
}
