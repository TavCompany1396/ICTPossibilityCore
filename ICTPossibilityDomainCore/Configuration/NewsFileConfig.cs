
using ICTPossibilityDomainCore.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ICTPossibilityDomainCore.Configuration
{
    /// <summary>
    /// نشان دهنده  مپینگ کلاس کاربر
    /// </summary>
    public class NewsFileConfig : IEntityTypeConfiguration<NewsFile>
    {
        /// <summary>
        /// سازنده پیش فرض
        /// </summary>
        public NewsFileConfig()
        {
            
        }

        public void Configure(EntityTypeBuilder<NewsFile> builder)
        {
            builder.ToTable(nameof(NewsFile), StaticVariables.PossibilitySchema);
            builder.Property(t => t.Id).IsRequired();
            builder.Property(t => t.Title).IsRequired();
            builder.HasOne(at => at.New).WithMany().HasForeignKey(at => at.EntityId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
