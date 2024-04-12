
using ICTCommonServiceCore;
using ICTDBContextCore;
using ICTPossibilityDomainCore.Model;
using ICTPossibilityServiceCore.IService;

namespace ICTPossibilityServiceCore.Service
{
    public class LinkFileService : CommonService<LinkFile>, ILinkFileService
    {
        private readonly IUnitOfWork _unitOfWork;

        public LinkFileService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void DeleteFile(string PathName, string FileName)
        {
            //FileService<LinkFile> fileServices = new FileService<LinkFile>(_unitOfWork);
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
