using GenerateCQRSComunicador.Utils;

namespace GenerateCQRSComunicador.ConfigGenerateEntities;

public class ConfigGenerateDepartamentosExternos
{
    public static GenerateParams GetConfig()
    {
        var departamentosExternos = new GenerateParams();
        departamentosExternos.GenerateOnlyModel = false;
        departamentosExternos.ConrollerRoute = "departamentosExternos";
        departamentosExternos.AgregateModel = "DepartamentosExternos";
        departamentosExternos.SpanishName = "DepartamentoExterno";
        departamentosExternos.EnglishName = "ExternalApartment";
        departamentosExternos.SingularName = "DepartamentoExterno";
        departamentosExternos.PluralName = "DepartamentosExternos";
        departamentosExternos.auditable = Auditable.Full;
        departamentosExternos.CrudTypes = new List<CrudType>
        {
            CrudType.Create,
            CrudType.Update,
            CrudType.GetById,
            CrudType.GetByFilter  
        };
        departamentosExternos.Fields = new List<EntityField>
        {
            new EntityField
            {
                Name = "Id",
                Type = FieldType.Int,
                Description = "Identificador del Departamento",
                IsPrimaryKey = true,
                IsAutoIncrement = true
            },            
            new EntityField
            {
                Name = "Nombre",
                Type = FieldType.String,
                Description = "Nombre del Departamento",
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
                Description = "Estado de la Plantilla",
                IsRequired = true,                
                SpanishName = "Activo",
                EnglishName = "Active",
                TestExample = "true"
            }
        };

        return departamentosExternos;
    }
}
