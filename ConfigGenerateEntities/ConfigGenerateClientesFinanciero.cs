using GenerateCQRSComunicador.Utils;

namespace GenerateCQRSComunicador.ConfigGenerateEntities;

public class ConfigGenerateClientesFinanciero
{
    public static GenerateParams GetConfig()
    {
        var config = new GenerateParams
        {
            GenerateOnlyModel = true,
            AgregateModel = "VentasCobros",
            SpanishName = "Cliente Financiero",
            EnglishName = "Financial Client",
            SingularName = "ClienteFinanciero",
            PluralName = "ClientesFinancieros",
            auditable = Auditable.Create,
            Fields = new List<EntityField>
            {
                new EntityField
                {
                    Name = "Id",
                    Type = FieldType.Int,
                    Description = "Identificador del cliente financiero",
                    IsPrimaryKey = true,
                    IsAutoIncrement = true
                },
                new EntityField
                {
                    Name = "CodigoCliente",
                    Type = FieldType.String,
                    Description = "Código del cliente",
                    Length = 50,
                    IsRequired = true,
                    SpanishName = "Código Cliente",
                    EnglishName = "ClientCode",
                    TestExample = "CL12345"
                },
                new EntityField
                {
                    Name = "IdAlumnmoIntegracion",
                    Type = FieldType.Int,
                    Description = "Identificador del alumno en integración",
                    IsRequired = true,
                    IsEspecification = true,
                    SpanishName = "Id Alumno Integración",
                    EnglishName = "StudentIntegrationId",
                    TestExample = "10001"
                }
            }
        };

        return config;
    }
}
