
using System.ComponentModel.DataAnnotations.Schema;
using ICTBaseModelCore.Model;
using ICTSecurityDomainCore.Model;

namespace ICTPossibilityDomainCore.Model
{
    public class Survey : TavModelAudit
    {
        public string Comment { get; set; }
        public string Mobile { get; set; }
        public string UserName { get; set; }
        public byte SurveyType { get; set; }
        public DateTime? RegisterDate { get; set; }
        [ForeignKey(nameof(CreatedById))]
        public virtual User CreatedByUser { set; get; }

        [ForeignKey(nameof(ModifiedById))]
        public virtual User ModifiedByUser { set; get; }
    }
}
