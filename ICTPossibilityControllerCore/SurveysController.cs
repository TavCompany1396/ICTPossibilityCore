
using AutoMapper;
using ICTDBContextCore;
using ICTOdataBaseControllerCore;
using ICTPossibilityDomainCore.Model;
using ICTPossibilityServiceCore.IService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;

namespace ICTPossibilityControllerCore
{
    [Route("odata/surveys")]
    [EnableQuery]
    public class SurveysController : OdataBaseController<Survey>
    {
        private readonly IMapper _mapper;
        private readonly ISurveyService _service;
        private readonly IUnitOfWork _unitOfWork;
       

        public SurveysController(IMapper mapper, ISurveyService service, IUnitOfWork unitOfWork) : base(mapper, service, unitOfWork)
        {
            _service = service;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

       
    }
}
