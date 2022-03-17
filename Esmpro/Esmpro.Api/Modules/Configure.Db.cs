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
                    context.Configuration.GetConnectionString("EsmproConnection"),
                    SqlServer2019Dialect.Provider));
            });

    }
}
