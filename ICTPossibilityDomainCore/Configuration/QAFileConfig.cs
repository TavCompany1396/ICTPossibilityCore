using ICTPossibilityDomainCore.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ICTPossibilityDomainCore.Configuration
{
    /// <summary>
    /// نشان دهنده  مپینگ کلاس کاربر
    /// </summary>
    public class QAFileConfig : IEntityTypeConfiguration<QAFile>
    {
        public void Configure(EntityTypeBuilder<QAFile> builder)
        {
            builder.ToTable(nameof(QAFile), StaticVariables.PossibilitySchema);
            builder.Property(t => t.Id).IsRequired();
            builder.HasOne(at => at.QA).WithMany().HasForeignKey(at => at.EntityId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
