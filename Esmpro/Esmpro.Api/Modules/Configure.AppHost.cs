using Esmpro.Services;
using Funq;

[assembly: HostingStartup(typeof(Esmpro.Api.AppHost))]

namespace Esmpro.Api;

public class AppHost : AppHostBase, IHostingStartup
{
    public void Configure(IWebHostBuilder builder) => builder
        .ConfigureServices(services => {
            // Configure ASP.NET Core IOC Dependencies
        });

    public AppHost() : base("Esmpro.Api", typeof(EsmproServices).Assembly) {}

    public override void Configure(Container container)
    {
        // Configure ServiceStack only IOC, Config & Plugins
        SetConfig(new HostConfig {
            UseSameSiteCookies = true,
        });
    }
}
