using GenerateCQRSComunicador.Utils;

namespace GenerateCQRSComunicador.ConfigGenerateEntities;

public class ConfigGenerateCasosVentasCobros
{
    public static GenerateParams GetConfig()
    {
        var config = new GenerateParams();
        config.GenerateOnlyModel = true;
        config.ConrollerRoute = "casos-ventas-cobros";
        config.AgregateModel = "Casos";
        config.SpanishName = "CasoVentaCobro";
        config.EnglishName = "CaseSalesPayment";
        config.SingularName = "CasoVentaCobro";
        config.PluralName = "CasosVentasCobros";
        config.auditable = null;
        config.HasLogicDeleted = false;
        config.CrudTypes = new List<CrudType>(); // Solo modelo

        config.Fields = new List<EntityField>
        {
            new EntityField
            {
                Name = "Id",
                Type = FieldType.Int,
                Description = "Identificador del registro (mismo que IdCaso)",
                IsPrimaryKey = true,
                IsAutoIncrement = false
            },
            new EntityField
            {
                Name = "IdCaso",
                Type = FieldType.Int,
                Description = "Identificador del caso",
                IsRequired = true,
                IsForeignKey = true,
                ForeignKeyObject = "Caso",
                ForeignKeyTable = "Casos",
                IsEspecification = true,
                SpanishName = "Caso",
                EnglishName = "Case",
                TestExample = "501"
            },
            new EntityField
            {
                Name = "IdVentaCobro",
                Type = FieldType.Int,
                Description = "Identificador del cobro o venta",
                IsRequired = true,
                IsForeignKey = true,
                ForeignKeyObject = "VentaCobro",
                ForeignKeyTable = "VentasCobros",
                IsEspecification = true,
                SpanishName = "VentaCobro",
                EnglishName = "SalesPayment",
                TestExample = "302"
            }
        };

        return config;
    }
}
