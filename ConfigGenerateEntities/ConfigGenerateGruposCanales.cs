using GenerateCQRSComunicador.Utils;

namespace GenerateCQRSComunicador.ConfigGenerateEntities;

public class ConfigGenerateGruposCanales
{
    public static GenerateParams GetConfig()
    {
        var config = new GenerateParams
        {
            GenerateOnlyModel = true,
            ConrollerRoute = "grupos-canales",
            AgregateModel = "Grupos",
            SpanishName = "GrupoCanal",
            EnglishName = "GroupChannel",
            SingularName = "GrupoCanal",
            PluralName = "GruposCanales",
            auditable = Auditable.Full,
            CrudTypes = new List<CrudType>()
        };

        config.Fields = new List<EntityField>
        {
            new EntityField
            {
                Name = "Id",
                Type = FieldType.Int,
                Description = "Identificador del registro Grupo-Canal",
                IsPrimaryKey = true,
                IsAutoIncrement = true,
                SpanishName = "Id",
                EnglishName = "Id"
            },
            new EntityField
            {
                Name = "IdGrupo",
                Type = FieldType.Int,
                Description = "Identificador del Grupo",
                IsRequired = true,
                IsForeignKey = true,
                ForeignKeyEntity = "Grupo",
                ForeignKeyObject = "Grupo",
                ForeignKeyTable = "Grupos",
                ForeignKeyField = "Id",
                IsEspecification = true,
                EspecificationType = EspecificationType.Equal,
                SpanishName = "Id Grupo",
                EnglishName = "Group Id",
                TestExample = "1"
            },
            new EntityField
            {
                Name = "IdCanal",
                Type = FieldType.Int,
                Description = "Identificador del Canal",
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
