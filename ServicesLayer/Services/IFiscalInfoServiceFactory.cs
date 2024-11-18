using System;
using DataLayer.Services;
using Microsoft.Extensions.DependencyInjection;

namespace ServicesLayer.Services;

public interface IFiscalInfoServiceFactory
{
    IDataService Create();
}

public class FiscalInfoServiceFactory : IFiscalInfoServiceFactory
{
    private readonly IServiceProvider _serviceProvider;

    public FiscalInfoServiceFactory(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public IDataService Create()
    {
        using (var scope = _serviceProvider.CreateScope())
        {
            return scope.ServiceProvider.GetRequiredService<IDataService>();
        }
    }
}