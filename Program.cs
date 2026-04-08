using GenerateCQRSComunicador.App;
using GenerateCQRSComunicador.ConfigGenerateEntities;

namespace GenerateCQRSComunicador;
class Program
{
    static void Main(string[] args)
    {
        var generator = new Generate();
        Console.WriteLine($">>>>>>>>>>>>>>>> Init Generate:  {DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}");
        //var entity = ConfigGenerateParametrosConfig.GetConfig();
        //var entity = ConfigGenerateAgentes.GetConfig(); 
        //var entity = ConfigGenerateGrupos.GetConfig(); 
        //var entity = ConfigGenerateProcesos.GetConfig(); 
        //var entity = ConfigGenerateEtapas.GetConfig(); 
        //var entity = ConfigGenerateEtapasRelaciones.GetConfig();
        //var entity = ConfigGenerateAlumnosInfo.GetConfig();
        //var entity = ConfigGenerateOrigenesAtencion.GetConfig(); 
        //var entity = ConfigGenerateFinalidades.GetConfig(); 
        //var entity = ConfigGenerateFinalidadesGrupos.GetConfig(); 
        //var entity = ConfigGenerateAcciones.GetConfig(); 
        //var entity = ConfigGenerateCasos.GetConfig(); 
        //var entity = ConfigGenerateCasosEtapas.GetConfig(); 
        //var entity = ConfigGenerateCasosAgentes.GetConfig();         
        //var entity = ConfigGenerateCasosLogs.GetConfig(); 
        //var entity = ConfigGenerateTiposClasificaciones.GetConfig(); 
        //var entity = ConfigGenerateEquiposDistribucion.GetConfig(); 
        //var entity = ConfigGenerateEquiposDistribucionAgentes.GetConfig(); 
        //var entity = ConfigGenerateClasificaciones.GetConfig();
        //var entity = ConfigGenerateEquiposDistribucionAgentesAsignaciones.GetConfig();  
        //var entity = ConfigGenerateEquiposDistribucionGrupos.GetConfig();
        //var entity = ConfigGenerateEquiposDistribucionTiposClasificaciones.GetConfig();
        //var entity = ConfigGenerateAgentesGrupos.GetConfig();
        //var entity = ConfigGenerateAreas.GetConfig();
        //var entity = ConfigGenerateAgentesAreas.GetConfig();
        //var entity = ConfigGenerateCorreosBuzones.GetConfig();
        //var entity = ConfigGenerateCorreosMensajes.GetConfig();
        //var entity = ConfigGenerateCorreosMensajesDestinos.GetConfig();
        //var entity = ConfigGenerateCorreosMensajesAdjuntos.GetConfig();
        //var entity = ConfigGenerateCanales.GetConfig();
        //var entity = ConfigGenerateGruposCanales.GetConfig();
        //var entity = ConfigGenerateAgentesCanales.GetConfig();
        //var entity = ConfigGenerateCasosCorreosMensajes.GetConfig();
        //var entity = ConfigGenerateProyectosJira.GetConfig();
        //var entity = ConfigGenerateTiposJira.GetConfig();
        //var entity = ConfigGenerateEstadosJira.GetConfig();
        //var entity = ConfigGenerateJiraIssues.GetConfig();
        //var entity = ConfigGenerateIssueComentariosJira.GetConfig();
        //var entity = ConfigGenerateCasosJirasMensajes.GetConfig();
        //var entity = ConfigGenerateJirasMensajesResumenIA.GetConfig();
        //var entity = ConfigGenerateAgentesCorreosBuzones.GetConfig();
        //var entity = ConfigGenerateMensajesAlumnoIA.GetConfig();
        //var entity = ConfigGenerateMensajesResumenIA.GetConfig();
        //var entity = ConfigGenerateEtiquetas.GetConfig();
        //var entity = ConfigGeneratePlantillas.GetConfig();
        //var entity = ConfigGenerateDepartamentosExternos.GetConfig();
        //var entity = ConfigGenerateCasosHistorialAsignaciones.GetConfig();
        var entity = ConfigGenerateIssueAdjuntosJira.GetConfig();
        
        generator.Execute(entity);
        Console.WriteLine($">>>>>>>>>>>>>>>> Finish Generate {DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}");
    }
}