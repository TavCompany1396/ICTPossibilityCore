
using ICTPossibilityDomainCore.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ICTPossibilityDomainCore.Configuration
{
    /// <summary>
    /// نشان دهنده  مپینگ کلاس کاربر
    /// </summary>
    public class ArchiveFileConfig : IEntityTypeConfiguration<ArchiveFile>
    {
        /// <summary>
        /// سازنده پیش فرض
        /// </summary>
        public ArchiveFileConfig()
        {
            
        }

        public void Configure(EntityTypeBuilder<ArchiveFile> builder)
        {
            builder.ToTable(nameof(ArchiveFile), StaticVariables.PossibilitySchema);
             builder.Property(t => t.Id).IsRequired();
             builder.Property(t => t.FileName).IsRequired();
             builder.Property(t => t.TypeFile).IsRequired();
             builder.Property(t => t.TypeMIME).IsRequired();

        }
    }
}
