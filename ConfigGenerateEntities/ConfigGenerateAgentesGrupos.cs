using GenerateCQRSComunicador.Utils;

namespace GenerateCQRSComunicador.ConfigGenerateEntities;

public class ConfigGenerateAgentesGrupos
{
    public static GenerateParams GetConfig()
    {
        var config = new GenerateParams();
        config.GenerateOnlyModel = true;
        config.ConrollerRoute = "agentes-grupos";
        config.AgregateModel = "Agentes";
        config.SpanishName = "AgenteGrupo";
        config.EnglishName = "AgentGroup";
        config.SingularName = "AgenteGrupo";
        config.PluralName = "AgentesGrupos";
        config.auditable = null;
        config.HasLogicDeleted = false;
        config.CrudTypes = new List<CrudType>(); // Solo modelo

        config.Fields = new List<EntityField>
        {
            new EntityField
            {
                Name = "Id",
                Type = FieldType.Int,
                Description = "Identificador del agente-grupo",
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
                TestExample = "5"
            },
            new EntityField
            {
                Name = "Activo",
                Type = FieldType.Bool,
                Description = "Indica si el agente está activo en el grupo",
                IsRequired = true,
                SpanishName = "Activo",
                EnglishName = "Active",
                TestExample = "true"
            }
        };

        return config;
    }
}
