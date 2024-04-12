
using System.ComponentModel.DataAnnotations.Schema;
using ICTSecurityDomainCore.Model;

namespace ICTPossibilityDomainCore.Model
{
    public class ArchiveFile : ICTFileDomainCore.Model.BaseFile
    {
        [ForeignKey(nameof(CreatedById))]
        public virtual User CreatedByUser { set; get; }

        [ForeignKey(nameof(ModifiedById))]
        public virtual User ModifiedByUser { set; get; }
    }
}
