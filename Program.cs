using TaskManaerAPI.Models;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// serviços 
builder.Services.Configure<MongoDbSettings>(builder.Configuration.GetSection("MongoDbSettings"));

app.MapGet("/", () => "Hello World!");




app.Run();
