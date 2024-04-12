

using ICTCommonServiceCore;
using ICTPossibilityDomainCore.Model;

namespace ICTPossibilityServiceCore.IService
{
    public interface IQAGroupService : ICommonService<QAGroup> 
    {
        List<QAGroupDTO> GetListGroupWithQuestion();
    }
}
