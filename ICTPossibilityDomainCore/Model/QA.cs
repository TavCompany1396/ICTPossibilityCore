
using System.ComponentModel.DataAnnotations.Schema;
using ICTBaseModelCore.Model;
using ICTSecurityDomainCore.Model;

namespace ICTPossibilityDomainCore.Model
{
    public class QA : TavModelAudit
    {
        public virtual ICollection<QAFile> QAFiles { set; get; }



        public int? QAGroupId { set; get; }
        [ForeignKey(nameof(QAGroupId))]
        public virtual QAGroup QAGroup { set; get; }

        public string Question { get; set; }
        public string Answer { get; set; }
        public bool IsActive { get; set; }
        public DateTime? ExpireDate { get; set; }

        [ForeignKey(nameof(CreatedById))]
        public virtual User CreatedByUser { set; get; }

        [ForeignKey(nameof(ModifiedById))]
        public virtual User ModifiedByUser { set; get; }

    }
}
