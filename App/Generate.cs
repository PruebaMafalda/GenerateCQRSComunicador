using GenerateCQRSComunicador.App.GenerateApplication;
using GenerateCQRSComunicador.App.GenerateDomain;
using GenerateCQRSComunicador.App.GenerateInfrastructure;
using GenerateCQRSComunicador.App.GeneratePostman;
using GenerateCQRSComunicador.App.GenerateTest;
using GenerateCQRSComunicador.Utils;

namespace GenerateCQRSComunicador.App;
public class Generate
{
    private GenerateInfrastructureMain _generateInfrastructure = new GenerateInfrastructureMain();
    private GenerateDomainMain _generateDomain = new GenerateDomainMain();
    private GenerateApplicationMain _generateApplication = new GenerateApplicationMain();
    private GenerateTestMain _generateTest = new GenerateTestMain();
    private GeneratePostmanMain _generatePostmanMain = new GeneratePostmanMain();
    public void Execute(GenerateParams model)
    {
        // GENERATE DOMAIN
        _generateDomain.Generate(model);
        // GENERATE INFRAESTRUCTURE
        _generateInfrastructure.Generate(model);
        // GENERATE APPLICATION
        _generateApplication.Generate(model);
        // GENERATE TEST
        _generateTest.Generate(model);
        if (!model.GenerateOnlyModel)
        {
            // GENERATE Postman        
            _generatePostmanMain.Generate(model);    
        }
    }

}