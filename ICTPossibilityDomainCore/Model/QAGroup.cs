

using System.ComponentModel.DataAnnotations.Schema;
using ICTBaseModelCore.Model;
using ICTSecurityDomainCore.Model;

namespace ICTPossibilityDomainCore.Model
{
    public class QAGroup : TavModelAudit
    {
        public virtual ICollection<QA> QAs { set; get; }
        public string Title { get; set; }
      
[ForeignKey(nameof(CreatedById))]
        public virtual User CreatedByUser { set; get; }

        [ForeignKey(nameof(ModifiedById))]
        public virtual User ModifiedByUser { set; get; }


    }
}
