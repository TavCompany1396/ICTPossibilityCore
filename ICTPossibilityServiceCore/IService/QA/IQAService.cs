

using ICTCommonServiceCore;
using ICTPossibilityDomainCore.Model;

namespace ICTPossibilityServiceCore.IService
{
    public interface IQAService : ICommonService<QA> 
    {
        Task<bool> Delete(int? Id = null);
        IEnumerable<QADTO> GetForList(int? Id = 0);
    }
}
