var builder = WebApplication.CreateBuilder(args);
builder.Configuration.AddUserSecrets<Program>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var configuration = builder.Configuration;
builder.Services.AddDbContext<MyDbContext>();


var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();


app.Run();
