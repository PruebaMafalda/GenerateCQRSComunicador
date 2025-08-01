using GenerateCQRSComunicador.Utils;

namespace GenerateCQRSComunicador.ConfigGenerateEntities;

public class ConfigGenerateAreas
{
    public static GenerateParams GetConfig()
    {
        var grupo = new GenerateParams();
        grupo.GenerateOnlyModel = false;
        grupo.ConrollerRoute = "areas";
        grupo.AgregateModel = "Areas";
        grupo.SpanishName = "Area";
        grupo.EnglishName = "Area";
        grupo.SingularName = "Area";
        grupo.PluralName = "Areas";
        grupo.auditable = Auditable.Full;
        grupo.CrudTypes = new List<CrudType>
        {
            CrudType.Create,
            CrudType.Update,
            CrudType.GetById,
            CrudType.GetByFilter
        };
        grupo.Fields = new List<EntityField>
        {
            new EntityField
            {
                Name = "Id",
                Type = FieldType.Int,
                Description = "Identificador del area",
                IsPrimaryKey = true,
                IsAutoIncrement = true // No autoincremental
            },
            new EntityField
            {
                Name = "Nombre",
                Type = FieldType.String,
                Description = "Nombre del area",
                Length = 200,
                IsRequired = true,
                IsEspecification = true,
                EspecificationType = EspecificationType.Contains,
                SpanishName = "Nombre",
                EnglishName = "Name",
                TestExample = "Atencion al alumno"
            },
            new EntityField
            {
                Name = "Codigo",
                Type = FieldType.String,
                Description = "Codigo del area",
                Length = 50,
                IsRequired = false,
                IsUnique = true,
                IsEspecification = true,
                SpanishName = "Codigo",
                EnglishName = "Code",
                TestExample = "AAAA"
            },
            new EntityField
            {
                Name = "Abreviatura",
                Type = FieldType.String,
                Description = "Abreviatura del area",
                Length = 50,
                IsRequired = false,
                IsEspecification = true,
                SpanishName = "Abreviatura",
                EnglishName = "Abbreviation",
                TestExample = "AttAlumno"
            },
            new EntityField
            {
                Name = "IdGrupo",
                Type = FieldType.Int,
                Description = "Identificador del grupo",
                IsRequired = true,
                IsForeignKey = true,
                ForeignKeyObject = "Grupo",
                ForeignKeyTable = "Grupos",
                IsEspecification = true,
                SpanishName = "Grupo",
                EnglishName = "Group",
                TestExample = "5"
            },
            new EntityField
            {
                Name = "Activo",
                Type = FieldType.Bool,
                Description = "Indica si el area está activo",
                IsRequired = true,
                IsEspecification = true,
                SpanishName = "Activo",
                EnglishName = "Active",
                TestExample = "true"
            }
        };

        return grupo;
    }
}
