using GenerateCQRSComunicador.Utils;

namespace GenerateCQRSComunicador.ConfigGenerateEntities
{
    public class ConfigGenerateCorreosMensajesAdjuntos
    {
        public static GenerateParams GetConfig()
        {
            var correosMensajesAdjuntos = new GenerateParams();
            correosMensajesAdjuntos.GenerateOnlyModel = false;
            correosMensajesAdjuntos.ConrollerRoute = "correos-mensajes-adjuntos";
            correosMensajesAdjuntos.AgregateModel = "CorreosMensajesAdjuntos";
            correosMensajesAdjuntos.SpanishName = "Correo Mensaje Adjunto";
            correosMensajesAdjuntos.EnglishName = "Mail Message Attachment";
            correosMensajesAdjuntos.SingularName = "CorreoMensajeAdjunto";
            correosMensajesAdjuntos.PluralName = "CorreosMensajesAdjuntos";
            correosMensajesAdjuntos.auditable = null;

            correosMensajesAdjuntos.CrudTypes = new List<CrudType>();
            

            correosMensajesAdjuntos.Fields = new List<EntityField>
            {
                new EntityField
                {
                    Name = "Id",
                    Type = FieldType.Int,
                    Description = "Identificador del adjunto",
                    IsPrimaryKey = true,
                    IsAutoIncrement = true,
                    SpanishName = "Id",
                    EnglishName = "Id"
                },
                new EntityField
                {
                    Name = "FileName",
                    Type = FieldType.String,
                    Description = "Nombre del archivo adjunto",
                    Length = 200,
                    IsRequired = true,
                    SpanishName = "NombreArchivo",
                    EnglishName = "FileName",
                    TestExample = "documento.pdf"
                },
                new EntityField
                {
                    Name = "Url",
                    Type = FieldType.String,
                    Description = "URL del archivo adjunto",
                    Length = 200,
                    IsRequired = true,
                    SpanishName = "Url",
                    EnglishName = "Url",
                    TestExample = "https://example.com/documento.pdf"
                },
                new EntityField
                {
                    Name = "Tipo",
                    Type = FieldType.String,
                    Description = "Tipo del archivo adjunto (int)",
                    Length = 50,
                    IsRequired = false,
                    SpanishName = "Tipo",
                    EnglishName = "Type",
                    TestExample = "1"
                },
                new EntityField
                {
                    Name = "EsAdjunto",
                    Type = FieldType.Bool,
                    Description = "Si tiene adjunto",
                    IsRequired = true,
                    SpanishName = "EsAdjunto",
                    EnglishName = "IsAttached",
                    TestExample = "true"
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
                    SpanishName = "CorreoMensaje",
                    EnglishName = "MailMessage",
                    TestExample = "123"
                }
            };

            return correosMensajesAdjuntos;
        }
    }
}
