using AzureFunctions.InProc.NotWorking;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;

[assembly: FunctionsStartup(typeof(Startup))]
namespace AzureFunctions.InProc.NotWorking;

public class Startup : FunctionsStartup
{

    public override void Configure(IFunctionsHostBuilder builder)
    {
        var context = builder.GetContext();
        builder.AddGraphQLFunction(b => b.AddQueryType<Query>());


    }
}
