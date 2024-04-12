
using System.Data;
using System.Data.SqlClient;
using Dapper;
using ICTCommonServiceCore;
using ICTCommonUtilityCore;
using ICTDBContextCore;
using ICTPossibilityDomainCore.Model;
using ICTPossibilityDTOCore.Model;
using ICTPossibilityServiceCore.IService;
using Microsoft.Extensions.Configuration;

namespace ICTPossibilityServiceCore.Service
{
    public class NewsService : CommonService<News> , INewsSevice
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly INewsFileService _newsFileService;
        private readonly IConfiguration _configuration;

        public NewsService(IUnitOfWork unitOfWork , INewsFileService newsFileService , IConfiguration configuration) : base(unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _newsFileService = newsFileService;
            _configuration = configuration;
        }

        public async Task<bool> Delete(int? Id = null)
        {
            var qDel = this.FindBy(p => (Id == null ? true : p.Id == Id));

            foreach (var item in qDel)
            {
              
                await _newsFileService.Delete(NewsId: item.Id);

                await this.DeleteAsync(item.Id);
            }
            return true;
        }
        public IEnumerable<NewsDTO> GetForList(int? Id=0)
        {
            using (IDbConnection con = new SqlConnection(ICTCommonServiceCore.DataBaseService.GetConnectionDefault(_configuration)))
            {
                string cond = " where IsActive=1 ";
                if (Id.HasValue && Id != 0)
                    cond += " and Pos.News.Id=@Id";
                string newquery = @"select Pos.News.*,Sec.[User].DisplayName,Pos.NewsGroup.Title as GroupName  from Pos.News inner join Sec.[User] on Pos.News.CreatedById=Sec.[User].Id
inner join Pos.NewsGroup on Pos.NewsGroup.Id=Pos.News.NewsGroupId

" + cond+ " order by Pos.News.CreatedOn desc";

               

                string newFilequery = @" select FileName,TypeMIME,TypeFile,TypeConfirm,EntityId,Description,Title,RealFileName from Pos.NewsFile " + ((Id.HasValue && Id != 0)? " where EntityId=@Id" : "");

                var rpt = con.QueryMultiple(newquery+ newFilequery, new { Id=Id });
                var news = rpt.Read<NewsDTO>();
                var newsFile = rpt.Read<NewsFileDTO>();

                foreach (var item in news)
                {
                    item.NewsFiles = newsFile.Where(n => n.EntityId == item.Id);
                    item.TotalTime = CalculateReadingTime.MinReadTime(item.Text);
                    item.CreatedOnPersian = PersianDateExtensions.ToPersianDateString(item.CreatedOn);
                }



                return news;
            }
        }
    }
}
