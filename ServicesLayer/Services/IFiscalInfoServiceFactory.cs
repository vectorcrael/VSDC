using Microsoft.Extensions.DependencyInjection;

namespace ServicesLayer.Services;

public interface IFiscalInfoServiceFactory
{
    IFiscalService Create();
}

public class FiscalInfoServiceFactory(IServiceProvider serviceProvider) : IFiscalInfoServiceFactory
{
    public IFiscalService Create()
    {
        using var scope = serviceProvider.CreateScope();
        return scope.ServiceProvider.GetRequiredService<IFiscalService>();
    }
}