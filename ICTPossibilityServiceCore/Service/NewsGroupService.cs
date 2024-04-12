

using ICTCommonServiceCore;
using ICTDBContextCore;
using ICTPossibilityDomainCore.Model;
using ICTPossibilityServiceCore.IService;

namespace ICTPossibilityServiceCore.Service
{
    public class NewsGroupService : CommonService<NewsGroup> , INewsGroupService
    {
        private readonly IUnitOfWork _unitOfWork;

        public NewsGroupService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

       
    }
}
