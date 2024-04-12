using ICTPossibilityDomainCore.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ICTPossibilityDomainCore.Configuration
{
    /// <summary>
    /// نشان دهنده  مپینگ کلاس کاربر
    /// </summary>
    public class NewsConfig : IEntityTypeConfiguration<News>
    {
        public void Configure(EntityTypeBuilder<News> builder)
        {
            builder.ToTable(nameof(News), StaticVariables.PossibilitySchema);
            builder.Property(t => t.Id).IsRequired();
            builder.Property(t => t.Title).IsRequired();
            builder.Property(t => t.Summary).IsRequired();
            builder.Property(t => t.Text).IsRequired();
            builder.Property(t => t.Publish).IsRequired();


        }
    }
}
