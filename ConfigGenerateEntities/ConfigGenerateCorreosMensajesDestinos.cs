using GenerateCQRSComunicador.Utils;

namespace GenerateCQRSComunicador.ConfigGenerateEntities
{
    public class ConfigGenerateCorreosMensajesDestinos
    {
        public static GenerateParams GetConfig()
        {
            var correosMensajesDestinos = new GenerateParams();
            correosMensajesDestinos.GenerateOnlyModel = false;
            correosMensajesDestinos.ConrollerRoute = "correos-mensajes-destinos";
            correosMensajesDestinos.AgregateModel = "CorreosMensajesDestinos";
            correosMensajesDestinos.SpanishName = "Correo Mensaje Destino";
            correosMensajesDestinos.EnglishName = "Mail Message Destination";
            correosMensajesDestinos.SingularName = "CorreoMensajeDestino";
            correosMensajesDestinos.PluralName = "CorreosMensajesDestinos";
            correosMensajesDestinos.auditable = null;

            correosMensajesDestinos.CrudTypes = new List<CrudType>();

            correosMensajesDestinos.Fields = new List<EntityField>
            {
                new EntityField
                {
                    Name = "Id",
                    Type = FieldType.Int,
                    Description = "Identificador del destino del correo mensaje",
                    IsPrimaryKey = true,
                    IsAutoIncrement = true,
                    SpanishName = "Id",
                    EnglishName = "Id"
                },
                new EntityField
                {
                    Name = "Correo",
                    Type = FieldType.String,
                    Description = "Correo del destinatario.",
                    IsRequired = false,
                    IsEspecification = true,
                    SpanishName = "Correo",
                    EnglishName = "Email",
                    TestExample = "destinatario@dominio.com"
                },
                new EntityField
                {
                    Name = "Nombre",
                    Type = FieldType.String,
                    Description = "Nombre del destinatario ",
                    IsRequired = false,
                    SpanishName = "Nombre",
                    EnglishName = "Name",
                    TestExample = "Juan Pérez"
                },
                new EntityField
                {
                    Name = "Tipo",
                    Type = FieldType.Int,
                    Description = "Tipo del destinatario del correo.",
                    IsRequired = true,
                    SpanishName = "Tipo",
                    EnglishName = "Type",
                    TestExample = "1"
                },
                new EntityField
                {
                    Name = "IdCorreoMensaje",
                    Type = FieldType.Int,
                    Description = "Id del correo mensaje relacionado",
                    IsRequired = true,
                    IsForeignKey = true,
                    ForeignKeyObject = "CorreoMensaje",
                    ForeignKeyTable = "CorreosMensajes",
                    SpanishName = "Correo Mensaje",
                    EnglishName = "Mail Message",
                    TestExample = "123"
                }
            };

            return correosMensajesDestinos;
        }
    }
}
