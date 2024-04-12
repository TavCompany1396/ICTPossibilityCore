
using ICTCommonServiceCore;
using ICTDBContextCore;
using ICTPossibilityDomainCore.Model;
using ICTPossibilityServiceCore.IService;

namespace ICTPossibilityServiceCore.Service
{
    public class ArchiveFileService : CommonService<ArchiveFile>, IArchiveFileService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ArchiveFileService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void DeleteFile(string PathName, string FileName)
        {
            //FileService<ArchiveFile> fileServices = new FileService<ArchiveFile>(_unitOfWork);
            //fileServices.DeleteFile(PathName, FileName);
        }

        public bool CanDelete(int key, ref string msg)
        {
            return true;
        }

        public async Task<bool> Delete(int? Id = null, int? ProductId = null)
        {
            var qDel = this.FindBy(p => (Id == null ? true : p.Id == Id) && (ProductId == null ? true : p.EntityId == ProductId)).ToList();
            foreach (var item in qDel)
            {
                await this.DeleteAsync(Id);
            }

            return true;
        }
    }
}
