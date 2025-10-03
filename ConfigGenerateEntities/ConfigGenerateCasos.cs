using GenerateCQRSComunicador.Utils;

namespace GenerateCQRSComunicador.ConfigGenerateEntities;

public class ConfigGenerateCasos
{
    public static GenerateParams GetConfig()
    {
        var caso = new GenerateParams();
        caso.GenerateOnlyModel = false;
        caso.ConrollerRoute = "casos";
        caso.AgregateModel = "Casos";
        caso.SpanishName = "Caso";
        caso.EnglishName = "Case";
        caso.SingularName = "Caso";
        caso.PluralName = "Casos";
        caso.auditable = Auditable.Full;
        caso.CrudTypes = new List<CrudType>
        {
            CrudType.Create,
            CrudType.Update,
            CrudType.GetById,
            CrudType.GetByFilter
        };

        caso.Fields = new List<EntityField>
        {
            new EntityField
            {
                Name = "Id",
                Type = FieldType.Int,
                Description = "Identificador del caso",
                IsPrimaryKey = true,
                IsAutoIncrement = true,
                SpanishName = "Id",
                EnglishName = "Id"
            },
            new EntityField
            {
                Name = "IdAlumnoInfo",
                Type = FieldType.Int,
                Description = "Identificador del alumno",
                IsRequired = true,
                IsForeignKey = true,
                ForeignKeyObject = "AlumnoInfo",
                ForeignKeyTable = "AlumnosInfo",
                IsEspecification = true,
                SpanishName = "Alumno",
                EnglishName = "Student",
                TestExample = "123"
            },

            //? Nuevos Campos
            new EntityField
            {
                Name = "IdEtapaActual",
                Type = FieldType.Int,
                Description = "Etapa Actual del Caso",
                IsRequired = true,
                SpanishName = "IdEtapaActual",
                EnglishName = "IdActualState",
                TestExample = "101"
            },

            new EntityField
            {
                Name = "FechaCambioEtapa",
                Type = FieldType.DateTime,
                Description = "Fecha cambio etapa del caso",
                IsRequired = false,
                SpanishName = "FechaCambioEtapa",
                EnglishName = "StateDate",
                TestExample = "2025-01-15T09:45:00"
            },

             new EntityField
            {
                Name = "IdAgenteAsignado",
                Type = FieldType.Int,
                Description = "Identificador del agente Asignado",
                IsRequired = true,
                IsForeignKey = true,
                ForeignKeyObject = "Agente",
                ForeignKeyTable = "Agentes",
                IsEspecification = true,
                SpanishName = "Agente",
                EnglishName = "Agent",
                TestExample = "30"
            },

            new EntityField
            {
                Name = "FechaAgenteAsignado",
                Type = FieldType.DateTime,
                Description = "Fecha asignacion agente",
                IsRequired = false,
                SpanishName = "FechaAgenteAsignado",
                EnglishName = "AgentAssignDate",
                TestExample = "2025-01-15T09:45:00"
            },


            new EntityField
            {
                Name = "IdProceso",
                Type = FieldType.Int,
                Description = "Identificador del proceso asociado",
                IsRequired = true,
                IsForeignKey = true,
                ForeignKeyObject = "Proceso",
                ForeignKeyTable = "Procesos",
                IsEspecification = true,
                SpanishName = "Proceso",
                EnglishName = "Process",
                TestExample = "10"
            },
            new EntityField
            {
                Name = "IdGrupo",
                Type = FieldType.Int,
                Description = "Identificador del grupo al que pertenece",
                IsRequired = true,
                IsForeignKey = true,
                ForeignKeyObject = "Grupo",
                ForeignKeyTable = "Grupos",
                IsEspecification = true,
                SpanishName = "Grupo",
                EnglishName = "Group",
                TestExample = "5"
            },
            new EntityField
            {
                Name = "Anulado",
                Type = FieldType.Bool,
                Description = "Indica si el caso está anulado",
                IsRequired = true,
                SpanishName = "Anulado",
                EnglishName = "Canceled",
                TestExample = "false"
            }
        };

        return caso;
    }
}
