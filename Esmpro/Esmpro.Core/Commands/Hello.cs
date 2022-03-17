using Esmpro.Core.Responses;
using ServiceStack;

namespace Esmpro.Core.Commands;

[Route("/hello")]
[Route("/hello/{Name}")]
[Tag("esmpro")]
public class Hello : IReturn<HelloResponse>
{
    public string? Name { get; set; }
}


