using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectTracker.Domain.Clients;
using ProjectTracker.Domain.Projects;

namespace ProjectTracker.Infrastructure.Database.Configurations;
internal sealed class ProjectConfiguration : IEntityTypeConfiguration<Project>
{
    public void Configure(EntityTypeBuilder<Project> builder)
    {
        builder.HasKey(p =>  p.Id);

        builder.HasOne<Client>().WithMany().HasForeignKey(c => c.ClientId);

        builder.Property(p => p.Name).HasMaxLength(200);

        builder.Property(p => p.Status);
        builder.Property(p => p.Budget);
        builder.Property(p => p.CreatedAt);

    }
}
