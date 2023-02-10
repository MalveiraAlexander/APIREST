using APIRest.Data;
using APIRest.Exceptions;
using APIRest.Interfaces;
using APIRest.Repositories;
using APIRest.Services;

var builder = WebApplication.CreateBuilder(args);

using (var client = new ContextDB())
{
    client.Database.EnsureCreated();
}

// Add services to the container.
builder.Services.AddEntityFrameworkSqlite().AddDbContext<ContextDB>();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<IAutoRepository, AutoRepository>();
builder.Services.AddTransient<IAutoService, AutoService>();

builder.Services.AddHealthChecks();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseExceptionHandlerMiddleware();
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
