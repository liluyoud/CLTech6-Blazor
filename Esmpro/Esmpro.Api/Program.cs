using Esmpro.Core.Contexts;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("EsmproConnection");
builder.Services.AddDbContext<EsmproContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddControllers();

builder.Services.AddDbContextFactory<EsmproContext>(opt => 
    opt.UseSqlServer("Data Source=esmpro.db", o => o.MigrationsAssembly("Esmpro.Api")));
builder.Services.AddScoped<EsmproContext>(sp => 
    sp.GetRequiredService<IDbContextFactory<EsmproContext>>().CreateDbContext());

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

await EsmproContext.CheckAndSeedDatabaseAsync(
    app.Services.GetRequiredService<IDbContextFactory<EsmproContext>>().CreateDbContext());

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
