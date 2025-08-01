using GenerateCQRSComunicador.Utils;

namespace GenerateCQRSComunicador.ConfigGenerateEntities;

public class ConfigGenerateEquiposDistribucionAgentesAsignaciones
{
    public static GenerateParams GetConfig()
    {
        var config = new GenerateParams();
        config.GenerateOnlyModel = true;
        config.ConrollerRoute = "equipos-distribucion-agentes-asignaciones";
        config.AgregateModel = "EquiposDistribucion";
        config.SpanishName = "EquipoDistribucionAgenteAsignacion";
        config.EnglishName = "DistributionTeamAgentAssignment";
        config.SingularName = "EquipoDistribucionAgenteAsignacion";
        config.PluralName = "EquiposDistribucionAgentesAsignaciones";
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
                Description = "Identificador de la asignación",
                IsPrimaryKey = true,
                IsAutoIncrement = true
            },
            new EntityField
            {
                Name = "IdEquipoDistribucionAgente",
                Type = FieldType.Int,
                Description = "Identificador del agente del equipo de distribución",
                IsRequired = true,
                IsForeignKey = true,
                ForeignKeyObject = "EquipoDistribucionAgente",
                ForeignKeyTable = "EquiposDistribucionAgentes",
                IsEspecification = true,
                SpanishName = "EquipoDistribucionAgente",
                EnglishName = "DistributionTeamAgent",
                TestExample = "201"
            },
            new EntityField
            {
                Name = "IdTipoClasificacion",
                Type = FieldType.Int,
                Description = "Identificador del tipo de clasificación",
                IsRequired = true,
                IsForeignKey = true,
                ForeignKeyObject = "TipoClasificacion",
                ForeignKeyTable = "TiposClasificacion",
                IsEspecification = true,
                SpanishName = "TipoClasificacion",
                EnglishName = "ClassificationType",
                TestExample = "1"
            },
            new EntityField
            {
                Name = "IdClasificacion",
                Type = FieldType.Int,
                Description = "Identificador de la clasificación",
                IsRequired = true,
                IsForeignKey = true,
                ForeignKeyObject = "Clasificacion",
                ForeignKeyTable = "Clasificaciones",
                IsEspecification = true,
                SpanishName = "Clasificacion",
                EnglishName = "Classification",
                TestExample = "10"
            },
            new EntityField
            {
                Name = "IdAsignacionPadre",
                Type = FieldType.Int,
                Description = "Identificador de la asignación padre (si aplica)",
                IsRequired = false,
                IsForeignKey = true,
                ForeignKeyObject = "EquipoDistribucionAgenteAsignacion",
                ForeignKeyTable = "EquiposDistribucionAgentesAsignaciones",
                IsEspecification = true,
                SpanishName = "AsignacionPadre",
                EnglishName = "ParentAssignment",
                TestExample = "100"
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
