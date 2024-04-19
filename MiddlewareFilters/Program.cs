using MiddlewareFilters.Filters;
using MiddlewareFilters.Middleware;

var builder = WebApplication.CreateBuilder(args);



// Add services to the container.
builder.Services.AddScoped<FiltersExample>();




builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}




// Agregar el Middleware
app.UseMiddleware<MiddlewareExample>();




app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
