namespace ProjectTracker.Domain.Projects;
public sealed class Project
{
    private Project() { }

    public Guid Id { get; private set; }
    public Guid ClientId { get; private set; }
    public string Name { get; private set; }
    public ProjectStatus Status { get; private set; }
    public double Budget { get; private set; }
    public DateTime CreatedAt { get; private set; }

    
    public static Project Create(Guid clientId, string name, double budget)
    {
        Project project = new()
        {
            Id = Guid.NewGuid(),
            ClientId = clientId,
            Name = name,
            Status = ProjectStatus.Planned,
            Budget = budget,
            CreatedAt = DateTime.UtcNow
        };

        return project;
    }

}
