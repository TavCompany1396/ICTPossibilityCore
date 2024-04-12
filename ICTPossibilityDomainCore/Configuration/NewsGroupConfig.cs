
using ICTPossibilityDomainCore.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ICTPossibilityDomainCore.Configuration
{
    /// <summary>
    /// نشان دهنده  مپینگ کلاس کاربر
    /// </summary>
    public class NewsGroupConfig : IEntityTypeConfiguration<NewsGroup>
    {
        public void Configure(EntityTypeBuilder<NewsGroup> builder)
        {
            builder.ToTable(nameof(NewsGroup), StaticVariables.PossibilitySchema);
            builder.Property(t => t.Id).IsRequired();
            builder.Property(t => t.Title).IsRequired();
        }
    }
}
