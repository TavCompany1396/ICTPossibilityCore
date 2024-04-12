
using ICTPossibilityDomainCore.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ICTPossibilityDomainCore.Configuration
{
    /// <summary>
    /// نشان دهنده  مپینگ کلاس کاربر
    /// </summary>
    public class LinkFileConfig : IEntityTypeConfiguration<LinkFile>
    {

        public void Configure(EntityTypeBuilder<LinkFile> builder)
        {
            builder.ToTable(nameof(LinkFile), StaticVariables.PossibilitySchema);
            builder.Property(t => t.Id).IsRequired();
            builder.HasOne(at => at.Link).WithMany().HasForeignKey(at => at.EntityId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
