using GenerateCQRSComunicador.Utils;

namespace GenerateCQRSComunicador.ConfigGenerateEntities;

public class ConfigGenerateEtiquetas
{
    public static GenerateParams GetConfig()
    {
        var proyectoJira = new GenerateParams();
        proyectoJira.GenerateOnlyModel = false;
        proyectoJira.ConrollerRoute = "etiquetas";
        proyectoJira.AgregateModel = "Etiquetas";
        proyectoJira.SpanishName = "Etiqueta";
        proyectoJira.EnglishName = "Label";
        proyectoJira.SingularName = "Etiqueta";
        proyectoJira.PluralName = "Etiquetas";
        proyectoJira.auditable = null;
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
                Description = "Identificador de la Etiqueta",
                IsPrimaryKey = true,
                IsAutoIncrement = true
            },            
            new EntityField
            {
                Name = "Nombre",
                Type = FieldType.String,
                Description = "Nombre de la etiqueta",
                Length = 200,
                IsRequired = false,                
                SpanishName = "Nombre",
                EnglishName = "Name",
                TestExample = "AAAA"
            },
            new EntityField
            {
                Name = "Activo",
                Type = FieldType.Bool,
                Description = "Estado de la Etiqueta",
                IsRequired = true,                
                SpanishName = "Activo",
                EnglishName = "Active",
                TestExample = "true"
            }
        };

        return proyectoJira;
    }
}
