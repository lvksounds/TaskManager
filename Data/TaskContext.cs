using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System.Security.Cryptography.X509Certificates;

namespace TaskManaerAPI.Data
{
    public class TaskContext
    {
        private readonly IMongoDatabase _database;

        public TaskContext(IConfiguration configuration)
        {
            var client = new MongoClient(configuration.GetConnectionString("MongoDB"));
            _database = client.GetDatabase("TaskManagerDB");
        }

        public IMongoCollection<Task> Tasks => _database.GetCollection<Task>("Tarefas");
    }
}
