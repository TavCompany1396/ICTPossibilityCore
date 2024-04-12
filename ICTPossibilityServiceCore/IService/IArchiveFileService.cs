using System.Threading.Tasks;
using ICTFileServiceCore.IService;
using ICTPossibilityDomainCore.Model;


namespace ICTPossibilityServiceCore.IService
{
    public interface IArchiveFileService : IFileSevice<ArchiveFile>
    {
        void DeleteFile(string PathName, string FileName);
        
        bool CanDelete(int key, ref string msg);

        Task<bool> Delete(int? Id = null, int? ProductId = null);
    }
}
