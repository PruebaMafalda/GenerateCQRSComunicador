using GenerateCQRSComunicador.Utils;

namespace GenerateCQRSComunicador.ConfigGenerateEntities
{
    public class ConfigGenerateIssueComentariosJira
    {
        public static GenerateParams GetConfig()
        {
            var comentariosJira = new GenerateParams();
            comentariosJira.GenerateOnlyModel = true;
            comentariosJira.ConrollerRoute = "isssues-comentarios-jiras";
            comentariosJira.AgregateModel = "JirasIssues";
            comentariosJira.SpanishName = "IssueComentarioJira";
            comentariosJira.EnglishName = "IssueComentarioJira";
            comentariosJira.SingularName = "IssueComentarioJira";
            comentariosJira.PluralName = "IssuesComentariosJiras";
            comentariosJira.auditable = null;

            comentariosJira.CrudTypes = new List<CrudType>();
            

            comentariosJira.Fields = new List<EntityField>
            {
                new EntityField
                {
                    Name = "Id",
                    Type = FieldType.Int,
                    Description = "Identificador del comentario",
                    IsPrimaryKey = true,
                    IsAutoIncrement = true,
                    SpanishName = "Id",
                    EnglishName = "Id"
                },
                
                new EntityField
                {
                    Name = "IdUsuarioComentario",
                    Type = FieldType.Int,
                    Description = "Id Usuario que realizo el comentario",
                    IsRequired = false,
                    SpanishName = "IdUsuarioComentario",
                    EnglishName = "UserCommentedId",
                    TestExample = "1"
                },
                new EntityField
                {
                    Name = "Comentario",
                    Type = FieldType.String,
                    Description = "Comentario",
                    Length = 150,
                    IsRequired = true,
                    SpanishName = "Comentario",
                    EnglishName = "Commentary",
                    TestExample = "Test"
                },
                new EntityField
                {
                    Name = "FechaHoraComentario",
                    Type = FieldType.DateTime,
                    Description = "Fecha en la que se hizo el comentario",
                    IsRequired = false,
                    SpanishName = "FechaHoraComentario",
                    EnglishName = "CommentaryDateTime",
                    TestExample = "TEST"
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
            };

            return comentariosJira;
        }
    }
}
