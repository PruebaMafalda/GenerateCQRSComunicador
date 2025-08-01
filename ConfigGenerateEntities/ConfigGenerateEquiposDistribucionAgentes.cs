using GenerateCQRSComunicador.Utils;

namespace GenerateCQRSComunicador.ConfigGenerateEntities;

public class ConfigGenerateEquiposDistribucionAgentes
{
    public static GenerateParams GetConfig()
    {
        var config = new GenerateParams();
        config.GenerateOnlyModel = false;
        config.ConrollerRoute = "equipos-distribucion-agentes";
        config.AgregateModel = "EquiposDistribucion";
        config.SpanishName = "EquipoDistribucionAgente";
        config.EnglishName = "DistributionTeamAgent";
        config.SingularName = "EquipoDistribucionAgente";
        config.PluralName = "EquiposDistribucionAgentes";
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
                Description = "Identificador",
                IsPrimaryKey = true,
                IsAutoIncrement = true
            },
            new EntityField
            {
                Name = "IdAgente",
                Type = FieldType.Int,
                Description = "Identificador del agente",
                IsRequired = true,
                IsForeignKey = true,
                ForeignKeyObject = "Agente",
                ForeignKeyTable = "Agentes",
                IsEspecification = true,
                SpanishName = "Agente",
                EnglishName = "Agent",
                TestExample = "101"
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
                TestExample = "100"
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
                TestExample = "55"
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
