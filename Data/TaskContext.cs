using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System.Security.Cryptography.X509Certificates;
using TaskManaerAPI.Models;

namespace TaskManaerAPI.Data
{
    public class TaskContext
    {
        private readonly IMongoDatabase _database;

        public TaskContext(IOptions<MongoDbSettings> mongoDbSettings)
        {
            var client = new MongoClient(mongoDbSettings.Value.ConnectionString);
            _database = client.GetDatabase(mongoDbSettings.Value.DatabaseName);
        }

        public IMongoCollection<TaskInfo> Tasks => _database.GetCollection<TaskInfo>("Tasks");
    }
}
