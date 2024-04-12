

using ICTCommonServiceCore;
using ICTDBContextCore;
using ICTPossibilityDomainCore.Model;
using ICTPossibilityServiceCore.IService;

namespace ICTPossibilityServiceCore.Service
{
    public class SurveyService : CommonService<Survey> , ISurveyService
    {
        private readonly IUnitOfWork _unitOfWork;
   

        public SurveyService(IUnitOfWork unitOfWork ) : base(unitOfWork)
        {
            _unitOfWork = unitOfWork;
           
        }
       

    }
}
