using GenerateCQRSComunicador.Utils;

namespace GenerateCQRSComunicador.ConfigGenerateEntities
{
    public class ConfigGenerateIssueAdjuntosJira
    {
        public static GenerateParams GetConfig()
        {
            var adjuntosJira = new GenerateParams();
            adjuntosJira.GenerateOnlyModel = true;
            adjuntosJira.ConrollerRoute = "issues-adjuntos-jiras";
            adjuntosJira.AgregateModel = "JirasIssues";
            adjuntosJira.SpanishName = "IssueAdjuntoJira";
            adjuntosJira.EnglishName = "IssueAdjuntoJira";
            adjuntosJira.SingularName = "IssueAdjuntoJira";
            adjuntosJira.PluralName = "IssuesAdjuntosJiras";
            adjuntosJira.auditable = null;

            adjuntosJira.CrudTypes = new List<CrudType>();

            adjuntosJira.Fields = new List<EntityField>
            {
                new EntityField
                {
                    Name = "Id",
                    Type = FieldType.Int,
                    Description = "Identificador del adjunto",
                    IsPrimaryKey = true,
                    IsAutoIncrement = true,
                    SpanishName = "Id",
                    EnglishName = "Id"
                },
                new EntityField
                {
                    Name = "UrlAdjunto",
                    Type = FieldType.String,
                    Description = "URL del adjunto",
                    IsRequired = true,
                    SpanishName = "UrlAdjunto",
                    EnglishName = "AttachmentUrl",
                    TestExample = "https://example.com/adjunto.pdf"
                },
                new EntityField
                {
                    Name = "IdJiraIssue",
                    Type = FieldType.Int,
                    Description = "Id Jira Issue",
                    IsRequired = true,
                    IsForeignKey = true,
                    ForeignKeyEntity = "JiraIssue",
                    ForeignKeyObject = "JiraIssue",
                    ForeignKeyTable = "JirasIssues",
                    ForeignKeyField = "Id",
                    SpanishName = "IdJiraIssue",
                    EnglishName = "IdJiraIssue",
                    TestExample = "1"
                },
                new EntityField
                {
                    Name = "Activo",
                    Type = FieldType.Bool,
                    Description = "Indica si el adjunto está activo",
                    IsRequired = true,
                    SpanishName = "Activo",
                    EnglishName = "Active",
                    TestExample = "true"
                },
            };

            return adjuntosJira;
        }
    }
}
