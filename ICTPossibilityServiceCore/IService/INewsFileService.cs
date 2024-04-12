
using ICTFileServiceCore.IService;
using ICTPossibilityDomainCore.Model;

namespace ICTPossibilityServiceCore.IService
{
    public interface INewsFileService :IFileSevice<NewsFile> 
    {
        void DeleteFile(string PathName, string FileName);
        //void DeleteEntityFiles(string PathName, int EntityId);
        bool CanDelete(int key, ref string msg);

        Task<bool> Delete(int? Id = null, int? NewsId = null);
    }
}
