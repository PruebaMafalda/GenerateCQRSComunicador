using GenerateCQRSComunicador.Utils;

namespace GenerateCQRSComunicador.ConfigGenerateEntities
{
    public class ConfigGenerateCasosHistorialAsignaciones
    {
        public static GenerateParams GetConfig()
        {
            var config = new GenerateParams();

            config.GenerateOnlyModel = true;
            config.ConrollerRoute = "casos-historial-asignaciones";
            config.AgregateModel  = "Casos";
            config.SpanishName    = "CasoHistorialAsignacion";
            config.EnglishName    = "CaseAssignmentHistory";
            config.SingularName   = "CasoHistorialAsignacion";
            config.PluralName     = "CasosHistorialAsignaciones";
            config.auditable      = Auditable.Full;

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
                    Name = "IdCasoOrigen",
                    Type = FieldType.Int,
                    Description = "Identificador del Caso Origen",
                    IsRequired = false,
                    IsEspecification = true,
                    IsForeignKey = true,
                    ForeignKeyEntity = "Caso",
                    ForeignKeyObject = "CasoOrigen",
                    ForeignKeyTable  = "Casos",
                    ForeignKeyField = "Id",
                    SpanishName = "Caso Origen",
                    EnglishName = "Source Case",
                    TestExample = "1001"
                },
                new EntityField
                {
                    Name = "IdCasoDestino",
                    Type = FieldType.Int,
                    Description = "Identificador del Caso Destino",
                    IsRequired = false,
                    IsEspecification = true,
                    IsForeignKey = true,
                    ForeignKeyEntity = "Caso",
                    ForeignKeyObject = "CasoDestino",
                    ForeignKeyTable  = "Casos",
                    ForeignKeyField = "Id",
                    SpanishName = "Caso Destino",
                    EnglishName = "Target Case",
                    TestExample = "1002"
                }
            };

            return config;
        }
    }
}