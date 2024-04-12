
using ICTPossibilityServiceCore.IService;
using ICTPossibilityServiceCore.Service;
using Microsoft.Extensions.DependencyInjection;

namespace ICTPossibilityIOCCore
{
    public static class StaticMethods
    {
         public static void SetIOC(IServiceCollection service)
        {
             service.AddScoped<INewsSevice ,NewsService>();
             service.AddScoped<INewsFileService ,NewsFileService>();
             service.AddScoped<INewsGroupService ,NewsGroupService>();
             service.AddScoped<IQAService ,QAService>();
             service.AddScoped<IQAFileService ,QAFileService>();
             service.AddScoped<IQAGroupService ,QAGroupService>();
             service.AddScoped<ILinkGroupService ,LinkGroupService>();
             service.AddScoped<ILinkService ,LinkService>();
             service.AddScoped<ILinkFileService ,LinkFileService>();
             service.AddScoped<IBackgroundFileService ,BackgroundFileService>();
             service.AddScoped<IArchiveFileService ,ArchiveFileService>();
             service.AddScoped<IRulesService ,RulesService>();
             service.AddScoped<ISurveyService ,SurveyService>();

        }
    }
}
