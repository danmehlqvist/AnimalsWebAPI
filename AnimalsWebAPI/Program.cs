using AnimalsWebAPI.Data;
using AnimalsWebAPI.Repos;
using Microsoft.EntityFrameworkCore;





var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

string _connectionString = "server=.;database=Animals;Trusted_Connection=True;";
builder.Services.AddDbContext<ApplicationContext>(options =>
    options.UseSqlServer(_connectionString));
builder.Services.AddScoped<IAnimalRepo, AnimalRepo>();

var app = builder.Build();






// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
