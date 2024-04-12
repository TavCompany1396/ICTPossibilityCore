

using ICTCommonServiceCore;
using ICTDBContextCore;
using ICTPossibilityDomainCore.Model;
using ICTPossibilityServiceCore.IService;

namespace ICTPossibilityServiceCore.Service
{
    public class NewsFileService : CommonService<NewsFile>, INewsFileService
    {
        private readonly IUnitOfWork _unitOfWork;

        public NewsFileService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void DeleteFile(string PathName, string FileName)
        {
            //FileService<NewsFile> fileServices = new FileService<NewsFile>(_unitOfWork);
            //fileServices.DeleteFile(PathName, FileName);
        }

        public bool CanDelete(int key, ref string msg)
        {
            return true;
        }

        public async Task<bool> Delete(int? Id = null, int? NewsId = null)
        {
            var qDel = this.FindBy(p => (Id == null ? true : p.Id == Id) && (NewsId == null ? true : p.EntityId == NewsId)).ToList();
            foreach (var item in qDel)
            {
                await this.DeleteAsync(item.Id);
            }

            return true;
        }
    }
}
