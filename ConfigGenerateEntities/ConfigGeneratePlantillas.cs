using GenerateCQRSComunicador.Utils;

namespace GenerateCQRSComunicador.ConfigGenerateEntities;

public class ConfigGeneratePlantillas
{
    public static GenerateParams GetConfig()
    {
        var plantillas = new GenerateParams();
        plantillas.GenerateOnlyModel = false;
        plantillas.ConrollerRoute = "plantillas";
        plantillas.AgregateModel = "Plantillas";
        plantillas.SpanishName = "Plantilla";
        plantillas.EnglishName = "Template";
        plantillas.SingularName = "Plantilla";
        plantillas.PluralName = "Plantillas";
        plantillas.auditable = Auditable.Full;
        plantillas.CrudTypes = new List<CrudType>
        {
            CrudType.Create,
            CrudType.Update,
            CrudType.GetById,
            CrudType.GetByFilter  
        };
        plantillas.Fields = new List<EntityField>
        {
            new EntityField
            {
                Name = "Id",
                Type = FieldType.Int,
                Description = "Identificador de la Plantilla",
                IsPrimaryKey = true,
                IsAutoIncrement = true
            },            
            new EntityField
            {
                Name = "Nombre",
                Type = FieldType.String,
                Description = "Nombre de la Plantilla",
                Length = 200,
                IsRequired = false,                
                SpanishName = "Nombre",
                EnglishName = "Name",
                TestExample = "AAAA"
            },

            new EntityField
            {
                Name = "Asunto",
                Type = FieldType.String,
                Description = "Asunto de la Plantilla",
                Length = 250,
                IsRequired = false,                
                SpanishName = "Nombre",
                EnglishName = "Name",
                TestExample = "AAAA"
            },

            new EntityField
            {
                Name = "CuerpoHtml",
                Type = FieldType.String,
                Description = "Body html de la Plantilla",            
                IsRequired = false,                
                SpanishName = "Nombre",
                EnglishName = "Name",
                TestExample = "AAAA"
            },

            new EntityField
            {
                Name = "Activo",
                Type = FieldType.Bool,
                Description = "Estado de la Plantilla",
                IsRequired = true,                
                SpanishName = "Activo",
                EnglishName = "Active",
                TestExample = "true"
            }
        };

        return plantillas;
    }
}
