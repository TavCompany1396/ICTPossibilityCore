
using ICTCommonServiceCore;
using ICTDBContextCore;
using ICTPossibilityDomainCore.Model;
using ICTPossibilityDTOCore.Model;
using ICTPossibilityServiceCore.IService;

namespace ICTPossibilityServiceCore.Service
{
    public class LinkGroupService : CommonService<LinkGroup> , ILinkGroupService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILinkService _linkService;
        private readonly ILinkFileService _linkFileService;
        public LinkGroupService(IUnitOfWork unitOfWork, ILinkService linkService,ILinkFileService linkFileService) : base(unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _linkService = linkService;
            _linkFileService = linkFileService;
        }
        public LinkHomeIndexDTO GetListGroupWithLink()
        {
            List<LinkGroupDTO> lst = new List<LinkGroupDTO>();
            LinkHomeIndexDTO lstHome = new LinkHomeIndexDTO();
            var gList = this.GetAll();
            foreach (var item in gList)
            {
                var newgroup = new LinkGroupDTO { Id = item.Id, Title = item.Title };
                var qlist = _linkService.FindBy(g => g.LinkGroupId == item.Id && g.IsActive).ToList();
                List<LinkDTO> lstd = new List<LinkDTO>();
                foreach (var itemdetail in qlist)
                {
                    string img = string.Empty;
                    if (itemdetail.LinkFiles!=null && itemdetail.LinkFiles.Count > 0)
                        img = itemdetail.LinkFiles.FirstOrDefault().FileName;
                    else
                    {
                        var imf=_linkFileService.FindBy(e => e.EntityId == itemdetail.Id).FirstOrDefault();
                        if(imf!=null)
                        {
                            img = imf.FileName;
                        }
                    }
                    lstd.Add(new LinkDTO { ImageUrl = img, Id = itemdetail.Id, Title = itemdetail.Title, Url = itemdetail.Url });
                }
                newgroup.Links = lstd;
                lst.Add(newgroup);
            }

            //var qLinklist = _linkService.FindBy(g => g.IsActive, "LinkFiles").ToList();
            //List<LinkDTO> lstdLink = new List<LinkDTO>();
            //foreach (var itemdetail in qLinklist)
            //{
            //    string img = string.Empty;
            //    if (itemdetail.LinkFiles.Count > 0)
            //        img = itemdetail.LinkFiles.FirstOrDefault().FileName;

            //    lstdLink.Add(new LinkDTO { GroupId= itemdetail.LinkGroupId, ImageUrl=img,  Id = itemdetail.Id, Title = itemdetail.Title, Url = itemdetail.Url, });
            //}
            //lstHome.Links = lstdLink;
            lstHome.Groups = lst;

            return lstHome;
        }

    }
}
