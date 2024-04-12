using ICTPossibilityDomainCore.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ICTPossibilityDomainCore.Configuration
{
    /// <summary>
    /// 
    /// </summary>
    public class SurveyConfig : IEntityTypeConfiguration<Survey>
    {
        public void Configure(EntityTypeBuilder<Survey> builder)
        {
            builder.ToTable(nameof(Survey), StaticVariables.PossibilitySchema);
            builder.Property(t => t.Id).IsRequired();
        }
    }
}
