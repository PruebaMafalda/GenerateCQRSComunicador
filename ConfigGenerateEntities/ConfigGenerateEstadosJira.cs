using GenerateCQRSComunicador.Utils;

namespace GenerateCQRSComunicador.ConfigGenerateEntities;

public class ConfigGenerateEstadosJira
{
    public static GenerateParams GetConfig()
    {
        var estadoJira = new GenerateParams();
        estadoJira.GenerateOnlyModel = false;
        estadoJira.ConrollerRoute = "estados-jira";
        estadoJira.AgregateModel = "EstadosJira";
        estadoJira.SpanishName = "EstadoJira";
        estadoJira.EnglishName = "JiraState";
        estadoJira.SingularName = "EstadoJira";
        estadoJira.PluralName = "EstadosJira";
        estadoJira.auditable = Auditable.Full;
        estadoJira.CrudTypes = new List<CrudType>
        {
            CrudType.Create,
            CrudType.Update
        };
        estadoJira.Fields = new List<EntityField>
        {
            new EntityField
            {
                Name = "Id",
                Type = FieldType.Int,
                Description = "Identificador del estado del jira",
                IsPrimaryKey = true,
                IsAutoIncrement = true // No autoincremental
            },
            new EntityField
            {
                Name = "Nombre",
                Type = FieldType.String,
                Description = "Nombre del estado jira", // ? nueva,bloqueada, desestimada, resuelta
                Length = 50,
                IsRequired = true,
                IsEspecification = true,
                SpanishName = "Nombre",
                EnglishName = "Name",
                TestExample = "Bloqueada"
            },
            new EntityField
            {
                Name = "Activo",
                Type = FieldType.Bool,
                Description = "Indica si el estado esta activo",
                IsRequired = true,
                IsEspecification = true,
                SpanishName = "Activo",
                EnglishName = "Active",
                TestExample = "true"
            }
        };

        return estadoJira;
    }
}
