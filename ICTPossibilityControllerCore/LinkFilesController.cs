

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
    [Route("linkfiles")]
    [EnableQuery]
    public class LinkFilesController : BaseFileController<LinkFile>
    {
        private readonly IMapper _mapper;
        private readonly ILinkFileService _service;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _env;
        public LinkFilesController(IMapper mapper, ILinkFileService service, IUnitOfWork unitOfWork ,IWebHostEnvironment env ) : base(mapper, service, unitOfWork , env)
        {
            _service = service;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
             _env = env;
        }

        [HttpPost]
        [Route("Default.upload")]
        public async Task<IEnumerable<LinkFile>> uploadFile()
        {
            try
            {
                var res = await base.AddUpload("link");
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
