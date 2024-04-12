using ICTPossibilityDomainCore.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ICTPossibilityDomainCore.Configuration
{
    /// <summary>
    /// نشان دهنده  مپینگ کلاس کاربر
    /// </summary>
    public class QAGroupConfig : IEntityTypeConfiguration<QAGroup>
    {
        public void Configure(EntityTypeBuilder<QAGroup> builder)
        {
            builder.ToTable(nameof(QAGroup), StaticVariables.PossibilitySchema);
            builder.Property(t => t.Id).IsRequired();
            builder.Property(t => t.Title).IsRequired();
        }
    }
}
