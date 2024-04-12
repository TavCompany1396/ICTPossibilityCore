
using AutoMapper;
using ICTDBContextCore;
using ICTOdataBaseControllerCore;
using ICTPossibilityDomainCore.Model;
using ICTPossibilityServiceCore.IService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;

namespace ICTPossibilityControllerCore
{
    [Route("odata/newsgroups")]
    [EnableQuery]
    public class NewsGroupsController : OdataBaseController<NewsGroup>
    {
        private readonly IMapper _mapper;
        private readonly INewsGroupService _service;
        private readonly IUnitOfWork _unitOfWork;

        public NewsGroupsController(IMapper mapper, INewsGroupService service, IUnitOfWork unitOfWork) : base(mapper, service, unitOfWork)
        {
            _service = service;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

      
    }
}
