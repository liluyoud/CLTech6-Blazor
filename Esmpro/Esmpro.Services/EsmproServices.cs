using Esmpro.Core.Commands;
using Esmpro.Core.Responses;
using ServiceStack;

namespace Esmpro.Services;

public class EsmproServices : Service
{
    public object Any(Hello command)
    {
        return new HelloResponse { Result = "Services OK " + command.Name };
    }
}
