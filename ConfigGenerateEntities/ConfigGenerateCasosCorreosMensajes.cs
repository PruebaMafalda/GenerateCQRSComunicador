using GenerateCQRSComunicador.Utils;

namespace GenerateCQRSComunicador.ConfigGenerateEntities
{
    public class ConfigGenerateCasosCorreosMensajes
    {
        public static GenerateParams GetConfig()
        {
            var config = new GenerateParams();

            //? Solo generar el modelo (sin CRUDs ni controller)
            config.GenerateOnlyModel = true;

            config.ConrollerRoute = "casos-correos-mensajes";
            config.AgregateModel  = "Casos"; // ? Hacer referencia al nombre de la carpeta
            config.SpanishName    = "CasoCorreoMensaje";
            config.EnglishName    = "CaseMailMessage";
            config.SingularName   = "CasoCorreoMensaje";
            config.PluralName     = "CasosCorreosMensajes";
            config.auditable      = null;

            config.CrudTypes = new List<CrudType>();

            config.Fields = new List<EntityField>
            {
                new EntityField
                {
                    Name = "Id",
                    Type = FieldType.Int,
                    Description = "Identificador del registro (PK, autoincremental)",
                    IsPrimaryKey = true,
                    IsAutoIncrement = true,
                    SpanishName = "Id",
                    EnglishName = "Id",
                    TestExample = "1"
                },
                new EntityField
                {
                    Name = "IdCaso",
                    Type = FieldType.Int,
                    Description = "Identificador del Caso",
                    IsRequired = false,
                    IsEspecification = true,
                    IsForeignKey = true,
                    ForeignKeyEntity = "Caso",
                    ForeignKeyObject = "Caso",
                    ForeignKeyTable  = "Casos",
                    ForeignKeyField = "Id",
                    SpanishName = "Caso",
                    EnglishName = "Case",
                    TestExample = "1001",
                    
                    
                },
                new EntityField
                {
                    Name = "IdMensaje",
                    Type = FieldType.Int,
                    Description = "Identificador del CorreoMensaje",
                    IsRequired = false,
                    IsEspecification = true,
                    IsForeignKey = true,
                    ForeignKeyObject = "CorreoMensaje",
                    ForeignKeyTable  = "CorreosMensajes",
                    SpanishName = "Mensaje",
                    EnglishName = "Message",
                    TestExample = "5005"
                }
            };

            return config;
        }
    }
}
