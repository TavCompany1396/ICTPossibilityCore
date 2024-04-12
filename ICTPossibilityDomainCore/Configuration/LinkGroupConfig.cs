
using ICTPossibilityDomainCore.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ICTPossibilityDomainCore.Configuration
{
    /// <summary>
    /// نشان دهنده  مپینگ کلاس کاربر
    /// </summary>
    public class LinkGroupConfig : IEntityTypeConfiguration<LinkGroup>
    {
        public void Configure(EntityTypeBuilder<LinkGroup> builder)
        {
            builder.ToTable(nameof(LinkGroup), StaticVariables.PossibilitySchema);
            builder.Property(t => t.Id).IsRequired();
            builder.Property(t => t.Title).IsRequired();
        }
    }
}
