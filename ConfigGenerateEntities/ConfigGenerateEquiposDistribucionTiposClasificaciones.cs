using GenerateCQRSComunicador.Utils;

namespace GenerateCQRSComunicador.ConfigGenerateEntities;

public class ConfigGenerateEquiposDistribucionTiposClasificaciones
{
    public static GenerateParams GetConfig()
    {
        var config = new GenerateParams();
        config.GenerateOnlyModel = true;
        config.ConrollerRoute = "equipos-distribucion-tipos-clasificaciones";
        config.AgregateModel = "EquiposDistribucion";
        config.SpanishName = "EquipoDistribucionTipoClasificacion";
        config.EnglishName = "DistributionTeamClassificationType";
        config.SingularName = "EquipoDistribucionTipoClasificacion";
        config.PluralName = "EquiposDistribucionTiposClasificaciones";
        config.auditable = null;
        config.HasLogicDeleted = false;
        config.CrudTypes = new List<CrudType>(); // Solo modelo

        config.Fields = new List<EntityField>
        {
            new EntityField
            {
                Name = "Id",
                Type = FieldType.Int,
                Description = "Identificador",
                IsPrimaryKey = true,
                IsAutoIncrement = true
            },
            new EntityField
            {
                Name = "IdEquipoDistribucion",
                Type = FieldType.Int,
                Description = "Identificador del equipo de distribución",
                IsRequired = true,
                IsForeignKey = true,
                ForeignKeyObject = "EquipoDistribucion",
                ForeignKeyTable = "EquiposDistribucion",
                IsEspecification = true,
                SpanishName = "EquipoDistribucion",
                EnglishName = "DistributionTeam",
                TestExample = "20"
            },
            new EntityField
            {
                Name = "IdTipoClasificacion",
                Type = FieldType.Int,
                Description = "Identificador del tipo de clasificación",
                IsRequired = true,
                IsForeignKey = true,
                ForeignKeyObject = "TipoClasificacion",
                ForeignKeyTable = "TiposClasificaciones",
                IsEspecification = true,
                SpanishName = "TipoClasificacion",
                EnglishName = "ClassificationType",
                TestExample = "3"
            },
            new EntityField
            {
                Name = "Activo",
                Type = FieldType.Bool,
                Description = "Indica si está activo",
                IsRequired = true,
                SpanishName = "Activo",
                EnglishName = "Active",
                TestExample = "true"
            }
        };

        return config;
    }
}
