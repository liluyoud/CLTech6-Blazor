using CLTech.Core.Extensions;
using Esmpro.Core.Entities;
using ServiceStack.Data;
using ServiceStack.OrmLite;

[assembly: HostingStartup(typeof(Esmpro.Api.ConfigureDb))]

namespace Esmpro.Api
{
    public class ConfigureDb : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder) => builder
            .ConfigureServices((context, services) => {
                services.AddSingleton<IDbConnectionFactory>(new OrmLiteConnectionFactory(
                    context.Configuration.GetConnectionString("EsmproConnection")
                    ?? "Server=localhost;Database=test;User Id=test;Password=test;MultipleActiveResultSets=True;",
                    SqlServer2019Dialect.Provider));
            })
           .ConfigureAppHost(appHost => {
                using var db = appHost.Resolve<IDbConnectionFactory>().Open();
                if (db.CreateTableIfNotExists<Conference>())
                {
                   var conference = new Conference
                   {
                       Name = "Teste de Evento",
                   };
                   conference.FillAuditWithDefault();
                   db.Insert(conference);
                }
           });
        
    }
}
