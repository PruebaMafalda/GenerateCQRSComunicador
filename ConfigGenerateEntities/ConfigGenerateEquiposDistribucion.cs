using GenerateCQRSComunicador.Utils;

namespace GenerateCQRSComunicador.ConfigGenerateEntities;

public class ConfigGenerateEquiposDistribucion
{
    public static GenerateParams GetConfig()
    {
        var config = new GenerateParams();
        config.GenerateOnlyModel = true;
        config.AgregateModel = "EquiposDistribucion";
        config.ConrollerRoute = "equipos-distribucion";
        config.SpanishName = "EquipoDistribucin";
        config.EnglishName = "DistributionTeam";
        config.SingularName = "EquipoDistribucion";
        config.PluralName = "EquiposDistribucion";
        config.auditable =null;
        config.HasLogicDeleted = false;
        config.CrudTypes = new List<CrudType>(); // No CRUD porque es solo modelo

        config.Fields = new List<EntityField>
        {
            new EntityField
            {
                Name = "Id",
                Type = FieldType.Int,
                Description = "Identificador del equipo de distribución",
                IsPrimaryKey = true,
                IsAutoIncrement = false
            },
            new EntityField
            {
                Name = "Nombre",
                Type = FieldType.String,
                Description = "Nombre del equipo de distribución",
                Length = 50,
                IsRequired = true,
                SpanishName = "Nombre",
                EnglishName = "Name",
                TestExample = "Equipo Norte"
            }
        };

        return config;
    }
}
