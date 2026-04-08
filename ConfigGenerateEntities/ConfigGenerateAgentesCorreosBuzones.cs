using GenerateCQRSComunicador.Utils;

namespace GenerateCQRSComunicador.ConfigGenerateEntities;

public class ConfigGenerateAgentesCorreosBuzones
{
    public static GenerateParams GetConfig()
    {
        var config = new GenerateParams
        {
            GenerateOnlyModel = true,
            ConrollerRoute = "agentes-correos-buzones",
            AgregateModel = "Agentes", 
            SpanishName = "AgenteCorreoBuzon",
            EnglishName = "AgentMailBox",
            SingularName = "AgenteCorreoBuzon",
            PluralName = "AgentesCorreosBuzones",
            auditable = null,
            CrudTypes = new List<CrudType>()
        };

        config.Fields = new List<EntityField>
        {
            new EntityField
            {
                Name = "Id",
                Type = FieldType.Int,
                Description = "Identificador del registro Agente-CorreoBuzon",
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
                Name = "IdCorreoBuzon",
                Type = FieldType.Int,
                Description = "Identificador del CorreoBuzon asociado",
                IsRequired = true,
                IsForeignKey = true,
                ForeignKeyEntity = "CorreoBuzon",
                ForeignKeyObject = "CorreoBuzon",
                ForeignKeyTable = "CorreosBuzones",
                ForeignKeyField = "Id",
                SpanishName = "Id CorreoBuzon",
                EnglishName = "MailBox Id",
                TestExample = "1"
            }
        };

        return config;
    }
}
