using GenerateCQRSComunicador.Utils;

namespace GenerateCQRSComunicador.ConfigGenerateEntities
{
    public class ConfigGenerateMensajesAlumnoIA // ? Resumen ConjuntoMensaje by Alumno
    {
        public static GenerateParams GetConfig()
        {
            var config = new GenerateParams();

            //? Solo generar el modelo (sin CRUDs ni controller)
            config.GenerateOnlyModel = false;

            config.ConrollerRoute = "mensajes-alumnos-ia";
            config.AgregateModel  = "MensajesAlumnosIA"; // ? Hacer referencia al nombre de la carpeta
            config.SpanishName    = "MensajeAlumnoIA";
            config.EnglishName    = "StudenMessageIAs";
            config.SingularName   = "MensajeAlumnoIA";
            config.PluralName     = "MensajesAlumnosIA";
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
                    Name = "Resumen",
                    Type = FieldType.String,
                    Description = "Resumen respuesta IA",
                    Length = 1000,
                    IsRequired = false,
                    SpanishName = "Resumen",
                    EnglishName = "Resume",
                    TestExample = "Resumen"
                },

                new EntityField
                {
                    Name = "Prioridad",
                    Type = FieldType.String,
                    Description = "Prioridad respuesta IA",
                    Length = 200,
                    IsRequired = false,
                    SpanishName = "Prioridad",
                    EnglishName = "Priority",
                    TestExample = "Baja"
                },

                new EntityField
                {
                    Name = "Mensaje",
                    Type = FieldType.String,
                    Description = "Mensaje respuesta IA",
                    Length = 20000,
                    IsRequired = false,
                    SpanishName = "Mensaje",
                    EnglishName = "Message",
                    TestExample = "Resumen"
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
                }
            };

            return config;
        }
    }
}
