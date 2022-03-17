using ServiceStack;

[assembly: HostingStartup(typeof(Esmpro.Api.ConfigureAutoQuery))]

namespace Esmpro.Api
{
    public class ConfigureAutoQuery : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder) => builder
            .ConfigureAppHost(appHost => {
                appHost.Plugins.Add(new AutoQueryFeature {
                    MaxLimit = 1000,
                    IncludeTotal = true
                });
            });
    }
}