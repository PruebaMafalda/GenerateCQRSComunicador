using GenerateCQRSComunicador.Utils;

namespace GenerateCQRSComunicador.ConfigGenerateEntities;

public class ConfigGenerateProyectosJira
{
    public static GenerateParams GetConfig()
    {
        var proyectoJira = new GenerateParams();
        proyectoJira.GenerateOnlyModel = false;
        proyectoJira.ConrollerRoute = "proyectos-jira";
        proyectoJira.AgregateModel = "ProyectosJira";
        proyectoJira.SpanishName = "ProyectoJira";
        proyectoJira.EnglishName = "JiraProyect";
        proyectoJira.SingularName = "ProyectoJira";
        proyectoJira.PluralName = "ProyectosJira";
        proyectoJira.auditable = Auditable.Full;
        proyectoJira.CrudTypes = new List<CrudType>
        {
            CrudType.Create,
            CrudType.Update,
            CrudType.GetById,
            CrudType.GetByFilter
        };
        proyectoJira.Fields = new List<EntityField>
        {
            new EntityField
            {
                Name = "Id",
                Type = FieldType.Int,
                Description = "Identificador del proyecto",
                IsPrimaryKey = true,
                IsAutoIncrement = true // No autoincremental
            },
            new EntityField
            {
                Name = "Key",
                Type = FieldType.Int,
                Description = "key del proyecto",
                IsRequired = false,
                SpanishName = "Key",
                EnglishName = "Key",
                TestExample = "10013"
            },
            new EntityField
            {
                Name = "Nombre",
                Type = FieldType.String,
                Description = "Nombre del proyecto",
                Length = 100,
                IsRequired = false,
                IsEspecification = true,
                SpanishName = "Nombre",
                EnglishName = "Name",
                TestExample = "AAAA"
            },
            new EntityField
            {
                Name = "Activo",
                Type = FieldType.Bool,
                Description = "Indica si el proyecto está activo",
                IsRequired = true,
                IsEspecification = true,
                SpanishName = "Activo",
                EnglishName = "Active",
                TestExample = "true"
            }
        };

        return proyectoJira;
    }
}
