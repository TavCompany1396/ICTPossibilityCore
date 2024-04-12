
using AutoMapper;
using ICTDBContextCore;
using ICTOdataBaseControllerCore;
using ICTPossibilityDomainCore.Model;
using ICTPossibilityServiceCore.IService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Formatter;
using Microsoft.AspNetCore.OData.Query;

namespace ICTPossibilityControllerCore
{
    [Route("odata/qas")]
    [EnableQuery]
    public class QAsController : OdataBaseController<QA>
    {
        private readonly IMapper _mapper;
        private readonly IQAService _service;
        private readonly IUnitOfWork _unitOfWork;
        public QAsController(IMapper mapper, IQAService service, IUnitOfWork unitOfWork) : base(mapper, service, unitOfWork)
        {
            _service = service;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        [HttpDelete]
        public override async Task<IActionResult> Delete([FromODataUri] int key)
        {
            try
            {
                string msg = "";

                //if (!_service.CanDelete(key, ref msg))
                //{
                //    CustomException cex = new CustomException() { exceptionType = (int)odaExecptionType.پیام_دلخواه, title = "امکان حذف وجود ندارد.", message = msg };
                //    throw new ControllerHttpResponse().getMessageResponse(cex);
                //}

                //حذف کالا
                await _service.Delete(key);

                await _unitOfWork.SaveChangesAsync();

                return Ok();
            }
            catch (Exception ex)
            {
                throw new ControllerHttpResponse().getExceptionResponse(ex);
            }
        }
    }
}
