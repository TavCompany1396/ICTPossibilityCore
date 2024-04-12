
using System.Data;
using Dapper;
using ICTCommonServiceCore;
using ICTDBContextCore;
using ICTPossibilityDomainCore.Model;
using ICTPossibilityServiceCore.IService;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;

namespace ICTPossibilityServiceCore.Service
{
    public class QAService : CommonService<QA>, IQAService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IQAFileService _qaFileService;

        IConfiguration _configuration;

        public QAService(IUnitOfWork unitOfWork, IQAFileService newsFileService , IConfiguration configuration) : base(unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _qaFileService = newsFileService;
            _configuration = configuration;
        }

        public async Task<bool> Delete(int? Id = null)
        {
            var qDel = this.FindBy(p => (Id == null ? true : p.Id == Id));

            foreach (var item in qDel)
            {

                await _qaFileService.Delete(NewsId: item.Id);

                await this.DeleteAsync(item.Id);
            }
            return true;
        }
        public IEnumerable<QADTO> GetForList(int? Id = 0)
        {
            using (IDbConnection con = new SqlConnection(ICTCommonServiceCore.DataBaseService.GetConnectionDefault(_configuration)))
            {
                string cond = " where IsActive=1 ";
                if (Id.HasValue && Id != 0)
                    cond += " and Pos.News.Id=@Id";
                string newquery = @"select Pos.News.*,Sec.[User].DisplayName,Pos.NewsGroup.Title as GroupName  from Pos.News inner join Sec.[User] on Pos.News.CreatedById=Sec.[User].Id
inner join Pos.NewsGroup on Pos.NewsGroup.Id=Pos.News.NewsGroupId

" + cond + " order by Pos.News.CreatedOn desc";



                string newFilequery = @" select FileName,TypeMIME,TypeFile,TypeConfirm,EntityId,Description,Title,RealFileName from Pos.NewsFile " + ((Id.HasValue && Id != 0) ? " where EntityId=@Id" : "");

                var rpt = con.QueryMultiple(newquery + newFilequery, new { Id = Id });
                var news = rpt.Read<QADTO>();
                var newsFile = rpt.Read<QAFileDTO>();

                foreach (var item in news)
                {
                    //item.NewsFiles = newsFile.Where(n => n.EntityId == item.Id);
                    //item.TotalTime = Tav.Utility.CalculateReadingTime.MinReadTime(item.Text);
                    //item.CreatedOnPersian = Tav.Utility.PersianDateExtensions.ToPersianDateString(item.CreatedOn);
                }

                return news;
            }
        }
    }
}
