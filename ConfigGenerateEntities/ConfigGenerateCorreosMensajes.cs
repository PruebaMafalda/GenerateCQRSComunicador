using GenerateCQRSComunicador.Utils;

namespace GenerateCQRSComunicador.ConfigGenerateEntities;

public class ConfigGenerateCorreosMensajes
{
    public static GenerateParams GetConfig()
    {
        var config = new GenerateParams();
        config.GenerateOnlyModel = false;
        config.ConrollerRoute = "correos-mensajes";
        config.AgregateModel = "CorreosMensajes";
        config.SpanishName = "CorreoMensaje";
        config.EnglishName = "MailMessage";
        config.SingularName = "CorreoMensaje";
        config.PluralName = "CorreosMensajes";
        config.auditable = Auditable.Full;

        config.CrudTypes = new List<CrudType>
        {
            CrudType.Create,
            CrudType.Update,
            CrudType.GetByFilter,
            CrudType.GetById
        };

        config.Fields = new List<EntityField>
        {
            new EntityField
            {
                Name = "Id",
                Type = FieldType.Int,
                Description = "Identificador del correo-mensaje",
                IsPrimaryKey = true,
                IsAutoIncrement = true,
                SpanishName = "Id",
                EnglishName = "Id"
            },
            new EntityField
            {
                Name = "IdMensajeIntegracion",
                Type = FieldType.Int,
                Description = "Id del mensaje en el sistema de integración",
                IsRequired = true,
                IsEspecification = true,
                SpanishName = "Mensaje Integración",
                EnglishName = "Integration Message",
                TestExample = "1001"
            },
            new EntityField
            {
                Name = "Asunto",
                Type = FieldType.String,
                Description = "Asunto (varchar(500))",
                Length = 200,
                IsRequired = true,
                IsEspecification = true,
                SpanishName = "Asunto",
                EnglishName = "Subject",
                TestExample = "Consulta de matrícula"
            },
            new EntityField
            {
                Name = "Importancia",
                Type = FieldType.String,
                Description = "Importancia (varchar(20)). No requerido. Usable en especificación.",
                Length = 20,
                IsRequired = false,
                IsEspecification = true,
                SpanishName = "Importancia",
                EnglishName = "Importance",
                TestExample = "Alta"
            },
            new EntityField
            {
                Name = "Mensaje",
                Type = FieldType.String,
                Description = "Cuerpo del mensaje",
                Length = 210,
                IsRequired = true,
                SpanishName = "Mensaje",
                EnglishName = "Message",
                TestExample = "Necesito informacion sobre el proceso."
            },
            new EntityField
            {
                Name = "IdCorreoBuzon",
                Type = FieldType.Int,
                Description = "Id del correo buzon",
                IsRequired = false,
                IsForeignKey = true,
                ForeignKeyObject = "CorreoBuzon",
                ForeignKeyTable = "CorreosBuzones",
                SpanishName = "Correo Buzon",
                EnglishName = "Listener Mail",
                TestExample = "12"
            },
            new EntityField
            {
                Name = "CorreoRemitente",
                Type = FieldType.String,
                Description = "Correo del remitente (varchar(150))",
                IsRequired = true,
                SpanishName = "Correo Remitente",
                EnglishName = "Sender Email",
                TestExample = "remitente@dominio.com"
            },
            new EntityField
            {
                Name = "NombreRemitente",
                Type = FieldType.String,
                Description = "Nombre del remitente (varchar(150))",
                IsRequired = false,
                SpanishName = "Nombre Remitente",
                EnglishName = "Sender Name",
                TestExample = "Juan Pérez"
            },
            new EntityField
            {
                Name = "TieneAdjunto",
                Type = FieldType.Bool,
                Description = "Indica si tiene adjunto (default 0)",
                IsRequired = true,
                SpanishName = "Adjunto",
                EnglishName = "Has Attachment",
                TestExample = "false"
            },
            new EntityField
            {
                Name = "FechaRecepcionMensaje",
                Type = FieldType.DateTime,
                Description = "Fecha de recepcion del mensaje",
                IsRequired = false,
                SpanishName = "Fecha Recepcion",
                EnglishName = "Received Date",
                TestExample = "2025-01-15T09:45:00"
            },

            new EntityField
            {
                Name = "EsAsignado",
                Type = FieldType.Bool,
                Description = "Indica si el mensaje está asignado (default 0)",
                IsRequired = true,
                SpanishName = "Asignado",
                EnglishName = "Assigned",
                TestExample = "false"
            },

            new EntityField
            {
                Name = "IdAgenteAsignado",
                Type = FieldType.Int,
                Description = "Agente asignado",
                IsRequired = false,
                IsForeignKey = true,
                ForeignKeyObject = "Agente",
                ForeignKeyTable = "Agentes",
                SpanishName = "Agente Asignado",
                EnglishName = "Assigned Agent",
                TestExample = "4"
            },

            new EntityField
            {
                Name = "FechAsignacionMensaje",
                Type = FieldType.DateTime,
                Description = "Fecha de asignacion del mensaje",
                IsRequired = false,
                SpanishName = "Fecha Asignación",
                EnglishName = "Assignment Date",
                TestExample = "2025-01-15T10:30:00"
            },

             new EntityField
            {
                Name = "IdAsignador",
                Type = FieldType.Int,
                Description = "Agente que realizo la asignacion",
                IsRequired = false,
                IsForeignKey = true,
                ForeignKeyObject = "CasoAgente",
                ForeignKeyTable = "CasosAgentes",
                SpanishName = "Asignador",
                EnglishName = "Assigner",
                TestExample = "2"
            },

            new EntityField
            {
                Name = "EsLeido",
                Type = FieldType.Bool,
                Description = "Indica si el mensaje fue marcado como leido",
                IsRequired = true,
                SpanishName = "Mensaje Leído",
                EnglishName = "Message Read",
                TestExample = "false"
            },
            new EntityField
            {
                Name = "IdAgenteLeido",
                Type = FieldType.Int,
                Description = "Id del agente que leyo el mensaje",
                IsRequired = false,
                SpanishName = "Agente Lectura",
                EnglishName = "Read Agent",
                TestExample = "7"
            },
            new EntityField
            {
                Name = "FechaMensajeLeido",
                Type = FieldType.DateTime,
                Description = "Fecha en la que el agente marco como leido",
                IsRequired = false,
                SpanishName = "Fecha Mensaje Leído",
                EnglishName = "Message Read Date",
                TestExample = "2025-01-15T11:05:00"
            },

            new EntityField
            {
                Name = "EsAtendido",
                Type = FieldType.Bool,
                Description = "Indica si el mensaje fue atendido",
                IsRequired = true,
                SpanishName = "Atendido",
                EnglishName = "Handled",
                TestExample = "false"
            },
            new EntityField
            {
                Name = "FechaAtencionMensaje",
                Type = FieldType.DateTime,
                Description = "Fecha de atención del mensaje",
                IsRequired = false,
                SpanishName = "Fecha Atención",
                EnglishName = "Handled Date",
                TestExample = "2025-01-16T14:20:00"
            },
            new EntityField
            {
                Name = "IdAgenteAtencion",
                Type = FieldType.Int,
                Description = "Agente que atendió el mensaje",
                IsRequired = false,
                IsForeignKey = true,
                ForeignKeyObject = "Agente",
                ForeignKeyTable = "Agentes",
                SpanishName = "Agente Atención",
                EnglishName = "Handling Agent",
                TestExample = "3"
            },
                       
            new EntityField
            {
                Name = "IdAlumnoInfo",
                Type = FieldType.Int,
                Description = "Alumno relacionado",
                IsRequired = false,
                IsForeignKey = true,
                ForeignKeyObject = "AlumnoInfo",
                ForeignKeyTable = "AlumnosInfo",
                SpanishName = "Alumno",
                EnglishName = "Student",
                TestExample = "1234"
            },
            new EntityField
            {
                Name = "Estado",
                Type = FieldType.Int,
                Description = "Estado de la Comunicacion",
                IsRequired = false,                
                SpanishName = "Estado",
                EnglishName = "State",
                TestExample = "103"
            },
        };

        return config;
    }
}
