using GenerateCQRSComunicador.Utils;

namespace GenerateCQRSComunicador.ConfigGenerateEntities;

public class ConfigGenerateAgentesAreas
{
    public static GenerateParams GetConfig()
    {
        var config = new GenerateParams();
        config.GenerateOnlyModel = true;
        config.ConrollerRoute = "agentes-areas";
        config.AgregateModel = "Agentes";
        config.SpanishName = "AgenteArea";
        config.EnglishName = "AgentArea";
        config.SingularName = "AgenteArea";
        config.PluralName = "AgentesAreas";
        config.auditable = null;
        config.HasLogicDeleted = false;
        config.CrudTypes = new List<CrudType>(); // Solo modelo

        config.Fields = new List<EntityField>
        {
            new EntityField
            {
                Name = "Id",
                Type = FieldType.Int,
                Description = "Identificador del agente-area",
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
                Name = "IdArea",
                Type = FieldType.Int,
                Description = "Identificador del area",
                IsRequired = true,
                IsForeignKey = true,
                ForeignKeyObject = "Area",
                ForeignKeyTable = "areas",
                IsEspecification = true,
                SpanishName = "Area",
                EnglishName = "Area",
                TestExample = "5"
            },
            new EntityField
            {
                Name = "Activo",
                Type = FieldType.Bool,
                Description = "Indica si el agente está activo en el area",
                IsRequired = true,
                SpanishName = "Activo",
                EnglishName = "Active",
                TestExample = "true"
            }
        };

        return config;
    }
}
