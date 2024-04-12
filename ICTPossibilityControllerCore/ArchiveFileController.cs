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
    [Route("odata/archivefiles")]
    [EnableQuery]
    public class ArchiveFilesController : BaseFileController<ArchiveFile>
    {
        private readonly IMapper _mapper;
        private readonly IArchiveFileService _service;
        private readonly IUnitOfWork _unitOfWork;

        private readonly IWebHostEnvironment _env;

        public ArchiveFilesController(IMapper mapper, IArchiveFileService service, IUnitOfWork unitOfWork , IWebHostEnvironment env) : base(mapper, service, unitOfWork , env)
        {
            _service = service;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _env = env;
        }

        [HttpPost]
        [Route("Default.upload")]
        public async Task<IEnumerable<ArchiveFile>> uploadFile()
        {
            try
            {
                var res = await base.AddUpload("archive");
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
