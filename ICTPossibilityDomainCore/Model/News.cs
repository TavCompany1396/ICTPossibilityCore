

using System.ComponentModel.DataAnnotations.Schema;
using ICTBaseModelCore.Model;
using ICTSecurityDomainCore.Model;

namespace ICTPossibilityDomainCore.Model
{
    public class News : TavModelAudit
    {
        public virtual ICollection<NewsFile> NewsFiles { set; get; }



        public int? NewsGroupId { set; get; }
        [ForeignKey(nameof(NewsGroupId))]
        public virtual NewsGroup NewsGroup { set; get; }

        public string Title { get; set; }
        public string Summary { get; set; }
        public string Text { get; set; }
        public bool Publish { get; set; }
        public string StartDate { get; set; }
        public string StartClock { get; set; }
        public string EndDate { get; set; }
        public string EndClock { get; set; }
        public bool IsActive { get; set; }
        public DateTime ExpireDate { get; set; }

        [ForeignKey(nameof(CreatedById))]
        public virtual User CreatedByUser { set; get; }

        [ForeignKey(nameof(ModifiedById))]
        public virtual User ModifiedByUser { set; get; }

    }
}
