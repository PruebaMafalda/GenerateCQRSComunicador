using GenerateCQRSComunicador.Utils;

namespace GenerateCQRSComunicador.ConfigGenerateEntities;

public class ConfigGenerateCorreosBuzones
{
    public static GenerateParams GetConfig()
    {
        var config = new GenerateParams();
        config.GenerateOnlyModel = false;
        config.ConrollerRoute = "correos-buzones";
        config.AgregateModel = "CorreosBuzones";
        config.SpanishName = "CorreoBuzon";
        config.EnglishName = "Mailbox";
        config.SingularName = "CorreoBuzon";
        config.PluralName = "CorreosBuzones";
        config.auditable = null;

        config.CrudTypes = new List<CrudType>
        {
            CrudType.Create,
            CrudType.Update,
            CrudType.GetByFilter,
            CrudType.GetById
        };

        config.Fields = new List<EntityField>
        {
            new EntityField
            {
                Name = "Id",
                Type = FieldType.Int,
                Description = "Identificador del buzón de correo",
                IsPrimaryKey = true,
                IsAutoIncrement = true,
                SpanishName = "Id",
                EnglishName = "Id"
            },
            new EntityField
            {
                Name = "Nombre",
                Type = FieldType.String,
                Description = "Nombre del buzón",
                IsRequired = true,
                IsEspecification = true,
                SpanishName = "Nombre",
                EnglishName = "Name",
                TestExample = "Soporte"
            },
            new EntityField
            {
                Name = "IdCorreoIntegracion",
                Type = FieldType.Int,
                Description = "Identificador de la integración de correo asociada",
                IsRequired = true,
                IsEspecification = true,
                SpanishName = "Integración de Correo",
                EnglishName = "Mail Integration",
                TestExample = "1"
            },
            new EntityField
            {
                Name = "Color",
                Type = FieldType.String,
                Description = "Color asociado al buzón (código o nombre)",
                IsRequired = false,
                SpanishName = "Color",
                EnglishName = "Color",
                TestExample = "#FF9900"
            },
            new EntityField
            {
                Name = "Abreviatura",
                Type = FieldType.String,
                Description = "Abreviatura del buzón",
                IsRequired = false,
                SpanishName = "Abreviatura",
                EnglishName = "Abbreviation",
                TestExample = "SUP"
            },
            new EntityField
            {
                Name = "Activo",
                Type = FieldType.Bool,
                Description = "Indica si el buzón está activo",
                IsRequired = true,
                SpanishName = "Activo",
                EnglishName = "Active",
                TestExample = "true"
            }
        };

        return config;
    }
}
