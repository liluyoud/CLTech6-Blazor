using Esmpro.Api.GraphQL;
using Esmpro.Core.Contexts;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("EsmproConnection");

builder.Services.AddPooledDbContextFactory<EsmproContext>(options =>
    options.UseSqlServer(connectionString, opt => opt.MigrationsAssembly("Esmpro.Api")));

builder.Services.AddScoped<EsmproContext>(
    sp => sp.GetRequiredService<IDbContextFactory<EsmproContext>>().CreateDbContext()
);

builder.Services.AddGraphQLServer()
    .AddQueryType<Query>()
    .AddMutationType<Mutation>()
    .AddProjections()
    .AddFiltering()
    .AddSorting();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();
app.MapGraphQL("/graphql");

app.Run();
