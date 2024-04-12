
using ICTCommonServiceCore;
using ICTPossibilityDomainCore.Model;
using ICTPossibilityDTOCore.Model;

namespace ICTPossibilityServiceCore.IService
{
    public interface INewsSevice : ICommonService<News> 
    {
        Task<bool> Delete(int? Id = null);
        IEnumerable<NewsDTO> GetForList(int? Id = 0);
    }
}
