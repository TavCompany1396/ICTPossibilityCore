
using System.ComponentModel.DataAnnotations.Schema;
using ICTBaseModelCore.Model;
using ICTSecurityDomainCore.Model;

namespace ICTPossibilityDomainCore.Model
{
    public class Rules : TavModelAudit
    {
    
        public string Title { get; set; }
        public string Summary { get; set; }
        public string Text { get; set; }
        public int TypeId{ get; set; }
        public bool? IsActive { get; set; }
        [ForeignKey(nameof(CreatedById))]
        public virtual User CreatedByUser { set; get; }

        [ForeignKey(nameof(ModifiedById))]
        public virtual User ModifiedByUser { set; get; }
    }
}
