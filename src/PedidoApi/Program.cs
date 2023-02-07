using BackOffice.Domain.Entities.Configuration;
using PedidoApi;
using BackOffice.Infra.Sql;

var builder = WebApplication.CreateBuilder(args);
IConfiguration configuration = builder.Configuration;

builder.Services.AddInfraSql(configuration);
// Add services to the container.

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.Configure<RabbitMqConfiguration>(configuration.GetSection("RabbitMqConfig"));

builder.Services.AddSingleton<QueueService>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapPedidosEndpoints();

app.Run();
