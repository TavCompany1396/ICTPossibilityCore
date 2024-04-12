
using AutoMapper;
using ICTDBContextCore;
using ICTOdataBaseControllerCore;
using ICTPossibilityDomainCore.Model;
using ICTPossibilityServiceCore.IService;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.OData.Query;

namespace ICTPossibilityControllerCore
{
    [Route("odata/ruless")]
    [EnableQuery]
    public class RulessController : OdataBaseController<Rules>
    {
        private readonly IMapper _mapper;
        private readonly IRulesService _service;
        private readonly IUnitOfWork _unitOfWork;
       
        public RulessController(IMapper mapper, IRulesService service, IUnitOfWork unitOfWork) : base(mapper, service, unitOfWork)
        {
            _service = service;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

       
    }
}
