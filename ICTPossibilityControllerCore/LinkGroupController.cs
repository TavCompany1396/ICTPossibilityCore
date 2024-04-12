
using AutoMapper;
using ICTDBContextCore;
using ICTOdataBaseControllerCore;
using ICTPossibilityDomainCore.Model;
using ICTPossibilityServiceCore.IService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;

namespace ICTPossibilityControllerCore
{
    [Route("odata/linkgroups")]
    [EnableQuery]
    public class LinkGroupsController : OdataBaseController<LinkGroup>
    {
        private readonly IMapper _mapper;
        private readonly ILinkGroupService _service;
        private readonly IUnitOfWork _unitOfWork;
         public LinkGroupsController(IMapper mapper, ILinkGroupService service, IUnitOfWork unitOfWork) : base(mapper, service, unitOfWork)
        {
            _service = service;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

      
    }
}
