
using ICTCommonServiceCore;
using ICTDBContextCore;
using ICTPossibilityDomainCore.Model;
using ICTPossibilityServiceCore.IService;

namespace ICTPossibilityServiceCore.Service
{
    public class QAGroupService : CommonService<QAGroup> , IQAGroupService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IQAService _qAService;
        public QAGroupService(IUnitOfWork unitOfWork,IQAService qAService) : base(unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _qAService = qAService;
        }
        public List<QAGroupDTO> GetListGroupWithQuestion()
        {
            List<QAGroupDTO> lst = new List<QAGroupDTO>();
            var gList = this.GetAll();
            foreach (var item in gList)
            {
                var newgroup = new QAGroupDTO { Id = item.Id, Title = item.Title };
                var qlist = _qAService.FindBy(g => g.QAGroupId == item.Id && g.IsActive).ToList();
                List<QADTO> lstd = new List<QADTO>();
                foreach (var itemdetail in qlist)
                {
                    lstd.Add(new QADTO { Id= itemdetail.Id,  Answer = itemdetail.Answer,ExpireDate= itemdetail.ExpireDate,IsActive= itemdetail.IsActive,Question= itemdetail.Question });
                }
                newgroup.QAs = lstd;
                lst.Add(newgroup);
            }
            return lst;
        }
       
    }
}
