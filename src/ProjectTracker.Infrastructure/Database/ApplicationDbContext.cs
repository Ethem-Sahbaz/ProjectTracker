using Microsoft.EntityFrameworkCore;
using ProjectTracker.Domain.Clients;
using ProjectTracker.Domain.Projects;

namespace ProjectTracker.Infrastructure.Database;
public sealed class ApplicationDbContext : DbContext
{
    internal DbSet<Client> Clients { get; set; }
    internal DbSet<Project> Projects { get; set; }
    public ApplicationDbContext(DbContextOptions options)
        : base(options)
    {
        
    }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);

        base.OnModelCreating(modelBuilder);
    }
}
