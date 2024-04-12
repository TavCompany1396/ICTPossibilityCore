

using System.ComponentModel.DataAnnotations.Schema;
using ICTBaseModelCore.Model;
using ICTSecurityDomainCore.Model;

namespace ICTPossibilityDomainCore.Model
{
    public class Link : TavModelAudit
    {

        public virtual ICollection<LinkFile> LinkFiles { set; get; }



        public int? LinkGroupId { set; get; }
        [ForeignKey(nameof(LinkGroupId))]
        public virtual LinkGroup LinkGroup { set; get; }

        public string Title { get; set; }
        public string Url { get; set; }
        public bool IsActive { get; set; }
        public DateTime? ExpireDate { get; set; }

        [ForeignKey(nameof(CreatedById))]
        public virtual User CreatedByUser { set; get; }

        [ForeignKey(nameof(ModifiedById))]
        public virtual User ModifiedByUser { set; get; }

    }
}
