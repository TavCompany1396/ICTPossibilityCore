
using ICTCommonServiceCore;
using ICTDBContextCore;
using ICTPossibilityDomainCore.Model;
using ICTPossibilityServiceCore.IService;

namespace ICTPossibilityServiceCore.Service
{
    public class RulesService : CommonService<Rules> , IRulesService
    {
        private readonly IUnitOfWork _unitOfWork;
   

        public RulesService(IUnitOfWork unitOfWork ) : base(unitOfWork)
        {
            _unitOfWork = unitOfWork;
           
        }
       

    }
}
