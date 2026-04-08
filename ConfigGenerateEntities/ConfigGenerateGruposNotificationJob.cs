using GenerateCQRSComunicador.Utils;

namespace GenerateCQRSComunicador.ConfigGenerateEntities;

public class ConfigGenerateGruposNotificationJob
{
    public static GenerateParams GetConfig()
    {
        var config = new GenerateParams();
        config.GenerateOnlyModel = false;
        config.ConrollerRoute = "grupo-notification-job";
        config.AgregateModel = "Grupos";
        config.SpanishName = "GrupoNotificationJob";
        config.EnglishName = "GroupJobNotification";
        config.SingularName = "GrupoNotificationJob";
        config.PluralName = "GrupoNotificationJobs";
        config.auditable = Auditable.Full;
        config.HasLogicDeleted = false;
        config.CrudTypes = new List<CrudType>
        {
            CrudType.Create,
            CrudType.Update,
            CrudType.GetById,
            CrudType.GetByFilter
        };
        config.Fields = new List<EntityField>
        {
            new EntityField
            {
                Name = "IdGrupo",
                Type = FieldType.Int,
                Description = "Identificador del grupo (PK y FK a Grupos)",
                IsPrimaryKey = true,
                IsAutoIncrement = false,
                IsRequired = true,
                SpanishName = "IdGrupo",
                EnglishName = "GroupId",
                TestExample = "1"
            },
            new EntityField
            {
                Name = "DiasParaNotificacion",
                Type = FieldType.Int,
                Description = "Días sin respuesta antes de enviar notificación al departamento",
                IsRequired = true,
                IsEspecification = true,
                SpanishName = "DiasParaNotificacion",
                EnglishName = "DaysForNotification",
                TestExample = "3"
            },            
            new EntityField
            {
                Name = "EmailNotificacion",
                Type = FieldType.String,
                Description = "Email del departamento al que se notifica (no al cliente)",
                Length = 200,
                IsRequired = false,
                IsEspecification = true,
                SpanishName = "EmailNotificacion",
                EnglishName = "NotificationEmail",
                TestExample = "secretaria@unir.net"
            },

            new EntityField
            {
                Name = "Activo",
                Type = FieldType.Bool,
                Description = "Indica si el job está activo para este grupo",
                IsRequired = true,
                IsEspecification = true,
                SpanishName = "Activo",
                EnglishName = "Active",
                TestExample = "true"
            },
        };

        return config;
    }
}