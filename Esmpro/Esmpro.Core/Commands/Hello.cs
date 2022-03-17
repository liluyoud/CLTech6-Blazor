using Esmpro.Core.Responses;
using ServiceStack;

namespace Esmpro.Core.Commands;

[Route("/hello")]
[Route("/hello/{Name}")]
public class Hello : IReturn<HelloResponse>
{
    public string? Name { get; set; }
}


