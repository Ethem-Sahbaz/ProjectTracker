using ProjectTracker.Api.Abstractions.Endpoints;

namespace ProjectTracker.Api.Features.Projects;

internal sealed class GetProjects : IEndpoint
{
    public void MapEndpoint(IEndpointRouteBuilder app)
    {
        app.MapGet("/projects", () =>
        {
            return "Testprojects...";
        });
    }
}
