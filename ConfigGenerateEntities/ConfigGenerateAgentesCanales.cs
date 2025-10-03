using GenerateCQRSComunicador.Utils;

namespace GenerateCQRSComunicador.ConfigGenerateEntities;

public class ConfigGenerateAgentesCanales
{
    public static GenerateParams GetConfig()
    {
        var config = new GenerateParams
        {
            GenerateOnlyModel = true,
            ConrollerRoute = "agentes-canales",
            AgregateModel = "Agente", 
            SpanishName = "AgenteCanal",
            EnglishName = "AgentChannel",
            SingularName = "AgenteCanal",
            PluralName = "AgentesCanales",
            auditable = Auditable.Full,
            CrudTypes = new List<CrudType>()
        };

        config.Fields = new List<EntityField>
        {
            new EntityField
            {
                Name = "Id",
                Type = FieldType.Int,
                Description = "Identificador del registro Agente-Canal",
                IsPrimaryKey = true,
                IsAutoIncrement = true,
                SpanishName = "Id",
                EnglishName = "Id"
            },
            new EntityField
            {
                Name = "IdAgente",
                Type = FieldType.Int,
                Description = "Identificador del Agente asignado",
                IsRequired = true,
                IsForeignKey = true,
                ForeignKeyEntity = "Agente",
                ForeignKeyObject = "Agente",
                ForeignKeyTable = "Agentes", 
                ForeignKeyField = "Id",
                IsEspecification = true,
                EspecificationType = EspecificationType.Equal,
                SpanishName = "Id Agente",
                EnglishName = "Agent Id",
                TestExample = "1"
            },
            new EntityField
            {
                Name = "IdCanal",
                Type = FieldType.Int,
                Description = "Identificador del Canal asociado",
                IsRequired = true,
                IsForeignKey = true,
                ForeignKeyEntity = "Canal",
                ForeignKeyObject = "Canal",
                ForeignKeyTable = "Canales",
                ForeignKeyField = "Id",
                IsEspecification = true,
                EspecificationType = EspecificationType.Equal,
                SpanishName = "Id Canal",
                EnglishName = "Channel Id",
                TestExample = "10"
            }
        };

        return config;
    }
}
