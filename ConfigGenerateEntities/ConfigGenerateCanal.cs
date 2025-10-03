using GenerateCQRSComunicador.Utils;

namespace GenerateCQRSComunicador.ConfigGenerateEntities;

public class ConfigGenerateCanales
{
    public static GenerateParams GetConfig()
    {
        var canal = new GenerateParams
        {
            GenerateOnlyModel = false,
            ConrollerRoute = "canales",
            AgregateModel = "Canales",
            SpanishName = "Canal",
            EnglishName = "Channel",
            SingularName = "Canal",
            PluralName = "Canales",
            auditable = Auditable.Full,
            HasLogicDeleted = false,
            CrudTypes = new List<CrudType>
            {
                CrudType.Create,
                CrudType.Update,
                CrudType.GetByFilter
            },
            Fields = new List<EntityField>
            {
                new EntityField
                {
                    Name = "Id",
                    Type = FieldType.Int,
                    Description = "Identificador del canal",
                    IsPrimaryKey = true,
                    IsAutoIncrement = true
                },
                new EntityField
                {
                    Name = "Nombre",
                    Type = FieldType.String,
                    Description = "Nombre del canal",
                    Length = 100,
                    IsRequired = true,
                    IsEspecification = true,
                    EspecificationType = EspecificationType.Contains,
                    SpanishName = "Nombre",
                    EnglishName = "Name",
                    TestExample = "Canal Web"
                },
                new EntityField
                {
                    Name = "TipoCanal",
                    Type = FieldType.Int,
                    Description = "Tipo de canal",
                    IsRequired = true,
                    IsEspecification = true,
                    EspecificationType = EspecificationType.Equal,
                    SpanishName = "Tipo Canal",
                    EnglishName = "ChannelType",
                    TestExample = "1"
                },
                new EntityField
                {
                    Name = "IdTipoCanal",
                    Type = FieldType.Int,
                    Description = "Identificador del tipo de canal",
                    IsRequired = true,
                    IsEspecification = true,
                    EspecificationType = EspecificationType.Equal,
                    SpanishName = "Id Tipo Canal",
                    EnglishName = "ChannelTypeId",
                    TestExample = "10"
                },
                new EntityField
                {
                    Name = "Activo",
                    Type = FieldType.Bool,
                    Description = "Indica si el canal está activo",
                    IsRequired = true,
                    SpanishName = "Activo",
                    EnglishName = "Active",
                    TestExample = "true"
                }
            }
        };

        return canal;
    }
}
