
using AutoMapper;
using ICTDBContextCore;
using ICTOdataBaseControllerCore;
using ICTPossibilityDomainCore.Model;
using ICTPossibilityServiceCore.IService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;

namespace ICTPossibilityControllerCore
{
    [Route("odata/links")]
    [EnableQuery]
    public class LinksController : OdataBaseController<Link>
    {
        private readonly IMapper _mapper;
        private readonly ILinkService _service;
        private readonly IUnitOfWork _unitOfWork;

        public LinksController(IMapper mapper, ILinkService service, IUnitOfWork unitOfWork) : base(mapper, service, unitOfWork)
        {
            _service = service;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }
    }
}
