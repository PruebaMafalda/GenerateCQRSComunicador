using GenerateCQRSComunicador.Utils;

namespace GenerateCQRSComunicador.ConfigGenerateEntities;

public class ConfigGenerateVentaCobrosGestores
{
    public static GenerateParams GetConfig()
    {
        var config = new GenerateParams();
        config.GenerateOnlyModel = false;
        config.ConrollerRoute = "venta-cobros-gestores";
        config.AgregateModel = "VentasCobros";
        config.SpanishName = "VentaCobroGestor";
        config.EnglishName = "SalesPaymentAgent";
        config.SingularName = "VentaCobroGestor";
        config.PluralName = "VentasCobrosGestores";
        config.auditable = Auditable.Full;
        config.HasLogicDeleted = false;
        config.CrudTypes = new List<CrudType>
        {
            CrudType.Create,
            CrudType.Update,
            CrudType.GetByFilter
        };

        config.Fields = new List<EntityField>
        {
            new EntityField
            {
                Name = "Id",
                Type = FieldType.Int,
                Description = "Identificador del registro",
                IsPrimaryKey = true,
                IsAutoIncrement = true
            },
            new EntityField
            {
                Name = "IdEmpleado",
                Type = FieldType.Int,
                Description = "Identificador del empleado",
                IsRequired = true,
                IsEspecification = true,
                SpanishName = "Empleado",
                EnglishName = "Empleyee",
                TestExample = "1001"
            },
            new EntityField
            {
                Name = "CodigoGestor",
                Type = FieldType.String,
                Description = "Código del gestor",
                Length = 500,
                IsRequired = true,
                SpanishName = "CódigoGestor",
                EnglishName = "ManagerCode",
                TestExample = "G12345"
            }
        };

        return config;
    }
}
