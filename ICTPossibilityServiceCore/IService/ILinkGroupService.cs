
using ICTCommonServiceCore;
using ICTPossibilityDomainCore.Model;
using ICTPossibilityDTOCore.Model;

namespace ICTPossibilityServiceCore.IService
{
    public interface ILinkGroupService : ICommonService<LinkGroup> 
    {
        LinkHomeIndexDTO GetListGroupWithLink();
    }
}
