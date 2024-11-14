using System;
using DataLayer.Services;

namespace VSDCAPIApiClient.Services;

public interface IFiscalInfoServiceFactory
{
    IFiscalInfoService Create();
}

public class FiscalInfoServiceFactory : IFiscalInfoServiceFactory
{
    private readonly IServiceProvider _serviceProvider;

    public FiscalInfoServiceFactory(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public IFiscalInfoService Create()
    {
        return _serviceProvider.GetRequiredService<IFiscalInfoService>();
    }
}