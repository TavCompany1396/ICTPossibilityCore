
using AutoMapper;
using ICTDBContextCore;
using ICTOdataBaseControllerCore;
using ICTPossibilityDomainCore.Model;
using ICTPossibilityServiceCore.IService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;

namespace ICTPossibilityControllerCore
{
    [Route("odata/qagroups")]
    [EnableQuery]
    public class QAGroupsController : OdataBaseController<QAGroup>
    {
        private readonly IMapper _mapper;
        private readonly IQAGroupService _service;
        private readonly IUnitOfWork _unitOfWork;
        public QAGroupsController(IMapper mapper, IQAGroupService service, IUnitOfWork unitOfWork) : base(mapper, service, unitOfWork)
        {
            _service = service;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

      
    }
}
