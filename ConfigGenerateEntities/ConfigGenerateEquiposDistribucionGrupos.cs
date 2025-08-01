using GenerateCQRSComunicador.Utils;

namespace GenerateCQRSComunicador.ConfigGenerateEntities;

public class ConfigGenerateEquiposDistribucionGrupos
{
    public static GenerateParams GetConfig()
    {
        var config = new GenerateParams();
        config.GenerateOnlyModel = false;
        config.ConrollerRoute = "equipos-distribucion-grupos";
        config.AgregateModel = "EquiposDistribucion";
        config.SpanishName = "EquipoDistribucionGrupo";
        config.EnglishName = "DistributionTeamGroup";
        config.SingularName = "EquipoDistribucionGrupo";
        config.PluralName = "EquiposDistribucionGrupos";
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
                Description = "Identificador de la relación equipo-grupo",
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
                TestExample = "33"
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
                TestExample = "8"
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
