
using ICTPossibilityDomainCore.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ICTPossibilityDomainCore.Configuration
{
    /// <summary>
    /// نشان دهنده  مپینگ کلاس کاربر
    /// </summary>
    public class BackgroundFileConfig : IEntityTypeConfiguration<BackgroundFile>
    {
        public void Configure(EntityTypeBuilder<BackgroundFile> builder)
        {
            builder.ToTable(nameof(BackgroundFile), StaticVariables.PossibilitySchema);
            builder.Property(t => t.Id).IsRequired();
            builder.Property(t => t.FileName).IsRequired();
            builder.Property(t => t.TypeFile).IsRequired();
            builder.Property(t => t.TypeMIME).IsRequired();
        }
    }
}
