using GenerateCQRSComunicador.Utils;

namespace GenerateCQRSComunicador.ConfigGenerateEntities;

public class ConfigGenerateTiposJira
{
    public static GenerateParams GetConfig()
    {
        var tipoJira = new GenerateParams();
        tipoJira.GenerateOnlyModel = false;
        tipoJira.ConrollerRoute = "tipos-jira";
        tipoJira.AgregateModel = "TiposJira";
        tipoJira.SpanishName = "TipoJira";
        tipoJira.EnglishName = "JiraType";
        tipoJira.SingularName = "TipoJira";
        tipoJira.PluralName = "TiposJira";
        tipoJira.auditable = Auditable.Full;
        tipoJira.CrudTypes = new List<CrudType>
        {
            CrudType.Create,
            CrudType.Update
        };
        tipoJira.Fields = new List<EntityField>
        {
            new EntityField
            {
                Name = "Id",
                Type = FieldType.Int,
                Description = "Identificador del tipo jira",
                IsPrimaryKey = true,
                IsAutoIncrement = true // No autoincremental
            },
            new EntityField
            {
                Name = "Tipo",
                Type = FieldType.String,
                Description = "Tipo del jira", // ? userHistoria,tarea,error,hito etc
                Length = 70,
                IsRequired = true,
                IsEspecification = true,
                SpanishName = "Tipo",
                EnglishName = "Type",
                TestExample = "FFFFF"
            },
            new EntityField
            {
                Name = "Activo",
                Type = FieldType.Bool,
                Description = "Indica si el tipo esta activo",
                IsRequired = true,
                IsEspecification = true,
                SpanishName = "Activo",
                EnglishName = "Active",
                TestExample = "true"
            }
        };

        return tipoJira;
    }
}
