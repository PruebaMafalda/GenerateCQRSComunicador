using GenerateCQRSComunicador.Utils;

namespace GenerateCQRSComunicador.ConfigGenerateEntities
{
    public class ConfigGenerateCasosJirasMensajes
    {
        public static GenerateParams GetConfig()
        {
            var config = new GenerateParams();

            //? Solo generar el modelo (sin CRUDs ni controller)
            config.GenerateOnlyModel = true;

            config.ConrollerRoute = "casos-jiras-mensajes";
            config.AgregateModel  = "Casos"; // ? Hacer referencia al nombre de la carpeta
            config.SpanishName    = "CasoJiraMensaje";
            config.EnglishName    = "CaseJiraMessage";
            config.SingularName   = "CasoJiraMensaje";
            config.PluralName     = "CasosJirasMensajes";
            config.auditable      = null;

            config.CrudTypes = new List<CrudType>();

            config.Fields = new List<EntityField>
            {
                new EntityField
                {
                    Name = "Id",
                    Type = FieldType.Int,
                    Description = "Identificador del registro",
                    IsPrimaryKey = true,
                    IsAutoIncrement = true,
                    SpanishName = "Id",
                    EnglishName = "Id",
                    TestExample = "1"
                },
                new EntityField
                {
                    Name = "IdCaso",
                    Type = FieldType.Int,
                    Description = "Identificador del Caso",
                    IsRequired = false,
                    IsEspecification = true,
                    IsForeignKey = true,
                    ForeignKeyEntity = "Caso",
                    ForeignKeyObject = "Caso",
                    ForeignKeyTable  = "Casos",
                    ForeignKeyField = "Id",
                    SpanishName = "Caso",
                    EnglishName = "Case",
                    TestExample = "1001",
                    
                    
                },
                new EntityField
                {
                    Name = "IdJira",
                    Type = FieldType.Int,
                    Description = "Identificador del Jira",
                    IsRequired = false,
                    IsEspecification = true,
                    IsForeignKey = true,
                    ForeignKeyObject = "JiraIssue",
                    ForeignKeyTable  = "JirasIssues",
                    SpanishName = "Jira",
                    EnglishName = "JiraIssue",
                    TestExample = "VUO-4455"
                }
            };

            return config;
        }
    }
}
