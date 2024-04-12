
using ICTPossibilityDomainCore.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ICTPossibilityDomainCore.Configuration
{
    /// <summary>
    /// نشان دهنده  مپینگ کلاس کاربر
    /// </summary>
    public class LinkConfig : IEntityTypeConfiguration<Link>
    {

        public void Configure(EntityTypeBuilder<Link> builder)
        {
            builder.ToTable(nameof(Link), StaticVariables.PossibilitySchema);
            builder.Property(t => t.Id).IsRequired();
            builder.Property(t => t.Title).IsRequired();
        }
    }
}
