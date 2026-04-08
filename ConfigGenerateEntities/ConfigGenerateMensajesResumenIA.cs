using GenerateCQRSComunicador.Utils;

namespace GenerateCQRSComunicador.ConfigGenerateEntities
{
    public class ConfigGenerateMensajesResumenIA // ? Resumen Individual mensaje
    {
        public static GenerateParams GetConfig()
        {
            var config = new GenerateParams();

            //? Solo generar el modelo (sin CRUDs ni controller)
            config.GenerateOnlyModel = false;

            config.ConrollerRoute = "mensajes-resumen-ia";
            config.AgregateModel  = "MensajesResumenIA"; // ? Hacer referencia al nombre de la carpeta
            config.SpanishName    = "MensajeResumenIA";
            config.EnglishName    = "JiraMessageSummaryIA";
            config.SingularName   = "MensajeResumenIA";
            config.PluralName     = "MensajesResumenIA";
            config.auditable      = null;


            config.CrudTypes = new List<CrudType>
            {
                CrudType.Create,
            };

            config.Fields = new List<EntityField>
            {
                new EntityField
                {
                    Name = "Id",
                    Type = FieldType.Int,
                    Description = "Identificador del registro",
                    IsPrimaryKey = true,
                    IsAutoIncrement = true,
                    SpanishName = "Id",
                    EnglishName = "Id",
                    TestExample = "1"
                },
                new EntityField
                {
                    Name = "IdIdentificador",
                    Type = FieldType.String,
                    Description = "Identificador del Jira/Correo",
                    IsRequired = false,
                    SpanishName = "IdIdentificador",
                    EnglishName = "IdentifierId",
                    TestExample = "1001",

                },
                new EntityField
                {
                    Name = "IdAlumnoInfo",
                    Type = FieldType.Int,
                    Description = "Alumno relacionado",
                    IsRequired = false,
                    IsForeignKey = true,
                    ForeignKeyEntity = "AlumnoInfo",
                    ForeignKeyObject = "AlumnoInfo",
                    ForeignKeyTable = "AlumnosInfo",
                    ForeignKeyField = "Id",
                    SpanishName = "Alumno",
                    EnglishName = "Student",
                    TestExample = "1234"
                },

                new EntityField
                {
                    Name = "Descripcion",
                    Type = FieldType.String,
                    Description = "Descripcion respuesta IA",
                    Length = 2000,
                    IsRequired = false,
                    SpanishName = "Descripcion",
                    EnglishName = "Description",
                    TestExample = "Descripcion"
                },

                new EntityField
                {
                    Name = "Resumen",
                    Type = FieldType.String,
                    Description = "Resumen respuesta IA",
                    Length = 2000,
                    IsRequired = false,
                    SpanishName = "Resumen",
                    EnglishName = "Summary",
                    TestExample = "Resumen"
                },

                new EntityField
                {
                    Name = "Etiquetas",
                    Type = FieldType.String,
                    Description = "Etiquetas (JSON array)",
                    Length = 500,
                    IsRequired = false,
                    SpanishName = "Etiquetas",
                    EnglishName = "Labels",
                    TestExample = "[\"Matrícula\",\"Incidencia\",\"Consulta / Duda\"]"
                },

                new EntityField
                {
                    Name = "TipoMensaje",
                    Type = FieldType.Int,
                    Description = "Identificador si es Jira/Correo",
                    IsRequired = false,
                    SpanishName = "TipoMensaje",
                    EnglishName = "MessageType",
                    TestExample = "1",

                },
                new EntityField
                {
                    Name = "Activo",
                    Type = FieldType.Bool,
                    Description = "Si esta cerrado/abierto",
                    IsRequired = false,
                    SpanishName = "Activo",
                    EnglishName = "Active",
                    TestExample = "true",

                }
            };

            return config;
        }
    }
}
