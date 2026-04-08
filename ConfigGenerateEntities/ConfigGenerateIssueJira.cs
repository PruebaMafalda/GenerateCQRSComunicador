using GenerateCQRSComunicador.Utils;

namespace GenerateCQRSComunicador.ConfigGenerateEntities
{
    public class ConfigGenerateJiraIssues
    {
        public static GenerateParams GetConfig()
        {
            var jiraIssue = new GenerateParams();
            jiraIssue.GenerateOnlyModel = false;
            jiraIssue.ConrollerRoute = "jiras-issues";
            jiraIssue.AgregateModel = "JirasIssues";
            jiraIssue.SpanishName = "JiraIssue";
            jiraIssue.EnglishName = "JiraIssue";
            jiraIssue.SingularName = "JiraIssue";
            jiraIssue.PluralName = "JirasIssues";
            jiraIssue.auditable = Auditable.Full;

            jiraIssue.CrudTypes = new List<CrudType>
            {
                CrudType.Create,
                CrudType.Update,
                CrudType.GetById,
                CrudType.GetByFilter
            };

            jiraIssue.Fields = new List<EntityField>
            {
                new EntityField
                {
                    Name = "Id",
                    Type = FieldType.Int,
                    Description = "Identificador del Jira Issue",
                    IsPrimaryKey = true,
                    IsAutoIncrement = true,
                    SpanishName = "Id",
                    EnglishName = "Id"
                },
                new EntityField
                {
                    Name = "IdIssueIntegracion",
                    Type = FieldType.String, // ? Debe ser string no int
                    Description = "Id del issue en el sistema de integración",
                    IsRequired = true,
                    IsEspecification = true,
                    SpanishName = "Id Integración",
                    EnglishName = "Integration Id",
                    TestExample = "1001"
                },
                new EntityField
                {
                    Name = "Resumen",
                    Type = FieldType.String,
                    Description = "Resumen del Jira Issue (varchar(200))",
                    Length = 200,
                    IsRequired = false,
                    IsEspecification = true,
                    SpanishName = "Resumen",
                    EnglishName = "Summary",
                    TestExample = "Resumen breve del issue"
                },
                new EntityField
                {
                    Name = "Descripcion",
                    Type = FieldType.String,
                    Description = "Descripción del Jira Issue (varchar(250))",
                    Length = 250,
                    IsRequired = false,
                    IsEspecification = true,
                    SpanishName = "Descripción",
                    EnglishName = "Description",
                    TestExample = "Descripción detallada del issue"
                },
                new EntityField
                {
                    Name = "Prioridad",
                    Type = FieldType.Int,
                    Description = "Prioridad del Jira Issue",
                    IsRequired = false,
                    SpanishName = "Prioridad",
                    EnglishName = "Priority",
                    TestExample = "1"
                },
                new EntityField
                {
                    Name = "Informador",
                    Type = FieldType.String,
                    Description = "Informacion de donde salio el ticket",
                    Length = 100,
                    IsRequired = false,
                    IsEspecification = true,
                    SpanishName = "Informador",
                    EnglishName = "Informer",
                    TestExample = "JIRAUSER10605"
                },
                new EntityField
                {
                    Name = "Responsable",
                    Type = FieldType.String,
                    Description = "Informacion de que usuario solicito el ticket",
                    Length = 100,
                    IsRequired = false,
                    IsEspecification = true,
                    SpanishName = "Responsable",
                    EnglishName = "Responsable",
                    TestExample = "JIRAUSER345446"
                },
                new EntityField
                {
                    Name = "Url",
                    Type = FieldType.String,
                    Description = "Url del ticket",
                    Length = 250,
                    IsRequired = false,
                    IsEspecification = true,
                    SpanishName = "Url",
                    EnglishName = "Url",
                    TestExample = "https://jira.preunir.net/"
                },
                new EntityField
                {
                    Name = "IdAgenteAsignadoDepartamento",
                    Type = FieldType.Int,
                    Description = "Id del agente asignado al departamento",
                    IsRequired = false,
                    SpanishName = "Agente Asignado Departamento",
                    EnglishName = "Assigned Agent Department",
                    TestExample = "5"
                },
                new EntityField
                {
                    Name = "DepartamentoResolutor",
                    Type = FieldType.String,
                    Description = "Departamento asignado al ticket",
                    Length = 150,
                    IsRequired = false,
                    IsEspecification = true,
                    SpanishName = "DepartamentoResolutor",
                    EnglishName = "DepartamentoResolutor",
                    TestExample = "Reconocimientos"
                },
                new EntityField
                {
                    Name = "FechaInicio",
                    Type = FieldType.DateTime,
                    Description = "Fecha de inicio del Jira Issue",
                    IsRequired = false,
                    SpanishName = "Fecha Inicio",
                    EnglishName = "Start Date",
                    TestExample = "2025-01-01T10:00:00"
                },
                new EntityField
                {
                    Name = "FechaVencimiento",
                    Type = FieldType.DateTime,
                    Description = "Fecha de vencimiento del Jira Issue",
                    IsRequired = false,
                    SpanishName = "Fecha Vencimiento",
                    EnglishName = "Due Date",
                    TestExample = "2025-02-01T10:00:00"
                },
                new EntityField
                {
                    Name = "IdEmpleadoSolicitante",
                    Type = FieldType.Int,
                    Description = "Id del empleado que solicitó el Jira Issue",
                    IsRequired = false,
                    SpanishName = "Empleado Solicitante",
                    EnglishName = "Requesting Employee",
                    TestExample = "10"
                },
                new EntityField
                {
                    Name = "IdJiraProyect",
                    Type = FieldType.Int,
                    Description = "Id del proyecto Jira al que pertenece el issue",
                    IsRequired = true,
                    IsForeignKey = true,
                    ForeignKeyEntity = "ProyectoJira",
                    ForeignKeyObject = "ProyectoJira",
                    ForeignKeyTable = "ProyectosJira",
                    ForeignKeyField = "Id",
                    SpanishName = "Proyecto Jira",
                    EnglishName = "Jira Project",
                    TestExample = "15"
                },
                new EntityField
                {
                    Name = "IdAgenteAsignado",
                    Type = FieldType.Int,
                    Description = "Id del agente asignado al Jira Issue",
                    IsRequired = false,
                    IsForeignKey = true,
                    ForeignKeyEntity = "Agente",
                    ForeignKeyObject = "Agente",
                    ForeignKeyTable = "Agentes",
                    ForeignKeyField = "Id",
                    SpanishName = "Agente Asignado",
                    EnglishName = "Assigned Agent",
                    TestExample = "7"
                },
                new EntityField
                {
                    Name = "IdJiraTipo",
                    Type = FieldType.Int,
                    Description = "Id del tipo de Jira Issue",
                    IsRequired = true,
                    IsForeignKey = true,
                    ForeignKeyEntity = "TipoJira",
                    ForeignKeyObject = "TipoJira",
                    ForeignKeyTable = "TiposJira",
                    ForeignKeyField = "Id",
                    SpanishName = "Tipo Jira",
                    EnglishName = "Jira Type",
                    TestExample = "3"
                },
                new EntityField
                {
                    Name = "IdJiraEstado",
                    Type = FieldType.Int,
                    Description = "Id del estado del Jira Issue",
                    IsRequired = true,
                    IsForeignKey = true,
                    ForeignKeyEntity = "EstadoJira",
                    ForeignKeyObject = "EstadoJira",
                    ForeignKeyTable = "EstadosJira",
                    ForeignKeyField = "Id",
                    SpanishName = "Estado Jira",
                    EnglishName = "Jira State",
                    TestExample = "2"
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
                    Name = "Estado",
                    Type = FieldType.Int,
                    Description = "Estado de la comunicacion",
                    IsRequired = false,
                    SpanishName = "Estado",
                    EnglishName = "State",
                    TestExample = "103"
                },
            };

            return jiraIssue;
        }
    }
}
