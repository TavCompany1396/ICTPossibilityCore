
using ICTPossibilityDomainCore.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ICTPossibilityDomainCore.Configuration
{
    /// <summary>
    /// </summary>
    public class RulesConfig : IEntityTypeConfiguration<Rules>
    {
        public void Configure(EntityTypeBuilder<Rules> builder)
        {
            builder.ToTable(nameof(Rules), StaticVariables.PossibilitySchema);
            builder.Property(t => t.Id).IsRequired();
          
        }
    }
}
