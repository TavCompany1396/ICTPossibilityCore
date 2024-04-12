

using ICTPossibilityDomainCore.Model;
using Microsoft.OData.ModelBuilder;

namespace ICTPossibilityControllerCore
{
    public class StaticMethods
    {
        public static void SetOdataModel(ODataModelBuilder builder)
        {

            var rulesEntityName = nameof(Rules).ToLower() + "s";
            var rulesEntity = builder.EntitySet<Rules>(rulesEntityName).EntityType;

            #region News
            var newsEntityName = nameof(News).ToLower() + "s";
            var newsEntity = builder.EntitySet<News>(newsEntityName).EntityType;


            var newsGroupEntityName = nameof(NewsGroup).ToLower() + "s";
            var newsGroupEntity = builder.EntitySet<NewsGroup>(newsGroupEntityName).EntityType;

            var newsFileEntityName = nameof(NewsFile).ToLower() + "s";
            var newsFileEntity = builder.EntitySet<NewsFile>(newsFileEntityName).EntityType;

            #endregion

            #region Link
            var linksGroupEntityName = nameof(LinkGroup).ToLower() + "s";
            var linksGroupEntity = builder.EntitySet<LinkGroup>(linksGroupEntityName).EntityType;

            var linksEntityName = nameof(Link).ToLower() + "s";
            var linksEntity = builder.EntitySet<Link>(linksEntityName).EntityType;

            var linkFileEntityName = nameof(LinkFile).ToLower() + "s";
            var linkFileEntity = builder.EntitySet<LinkFile>(linkFileEntityName).EntityType;


            ActionConfiguration uploadLinkFile = linkFileEntity.Collection.Action("upload");
            uploadLinkFile.Returns<IEnumerable<NewsFile>>();
            #endregion

            #region Qa
            var qaEntityName = nameof(QA).ToLower() + "s";
            var qaEntity = builder.EntitySet<QA>(qaEntityName).EntityType;


            var qaGroupEntityName = nameof(QAGroup).ToLower() + "s";
            var qaGroupEntity = builder.EntitySet<QAGroup>(qaGroupEntityName).EntityType;

            var qaFileEntityName = nameof(QAFile).ToLower() + "s";
            var qaFileEntity = builder.EntitySet<QAFile>(qaFileEntityName).EntityType;

            ActionConfiguration uploadqaFile = qaFileEntity.Collection.Action("upload");
            uploadqaFile.Returns<IEnumerable<QAFile>>();
            #endregion


            #region Survey
            var surveyEntityName = nameof(Survey).ToLower() + "s";
            var surveyEntity = builder.EntitySet<Survey>(surveyEntityName).EntityType;
            #endregion


            var backgroundFileEntityName = nameof(BackgroundFile).ToLower() + "s";
            var backgroundFileEntity = builder.EntitySet<BackgroundFile>(backgroundFileEntityName).EntityType;

            var archiveFileEntityName = nameof(ArchiveFile).ToLower() + "s";
            var archiveFileEntity = builder.EntitySet<ArchiveFile>(archiveFileEntityName).EntityType;

            ActionConfiguration uploadNewsFile = newsFileEntity.Collection.Action("upload");
            uploadNewsFile.Returns<IEnumerable<NewsFile>>();

            ActionConfiguration uploadBackgroundsFile = backgroundFileEntity.Collection.Action("upload");
            uploadBackgroundsFile.Returns<IEnumerable<NewsFile>>();

            ActionConfiguration uploadArchivesFile = archiveFileEntity.Collection.Action("upload");
            uploadArchivesFile.Returns<IEnumerable<ArchiveFile>>();


        }
    }
}
