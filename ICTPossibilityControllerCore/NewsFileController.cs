
using AutoMapper;
using ICTDBContextCore;
using ICTFileControllerCore;
using ICTOdataBaseControllerCore;
using ICTPossibilityDomainCore.Model;
using ICTPossibilityServiceCore.IService;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;

namespace ICTPossibilityControllerCore
{
    [Route("odata/newsfiles")]
    [EnableQuery]
    public class NewsFilesController : BaseFileController<NewsFile>
    {
        private readonly IMapper _mapper;
        private readonly INewsFileService _service;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _env;
       
        public NewsFilesController(IMapper mapper, INewsFileService service, IUnitOfWork unitOfWork,IWebHostEnvironment env) : base(mapper, service, unitOfWork,env)
        {
            _service = service;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _env= env;
        }

        [HttpPost]
        [Route("Default.upload")]
        public async Task<IEnumerable<NewsFile>> uploadFile()
        {
            try
            {
                var res = await base.AddUpload("news");
                await _unitOfWork.SaveChangesAsync();
                return res;
            }
            catch (Exception ex)
            {
                throw new ControllerHttpResponse().getExceptionResponse(ex);
            }
        }

    }
}
