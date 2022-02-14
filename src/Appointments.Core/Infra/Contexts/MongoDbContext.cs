using MongoDB.Driver;
using System.Security.Authentication;
using Appointments.Core.Domain.Interfaces.Contexts;

namespace Appointments.Core.Infra.Contexts
{
    public class MongoDbContext : IMongoDbContext
    {
        private readonly IMongoDatabase _mongoDatabase;

        public MongoDbContext(string connectionString, string databaseName)
        {
            MongoClientSettings settings = MongoClientSettings.FromUrl(new MongoUrl(connectionString));
            settings.SslSettings = new SslSettings { EnabledSslProtocols = SslProtocols.Tls12 };
            MongoClient mongoClient = new(settings);

            _mongoDatabase = mongoClient.GetDatabase(databaseName);
        }

        public IMongoCollection<T> GetCollection<T>(string collectionName)
        {
            return _mongoDatabase.GetCollection<T>(collectionName);
        }
    }
}
