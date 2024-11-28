using DataLayer.Services;
using Microsoft.Extensions.DependencyInjection;

namespace ServicesLayer.Services;

public interface IDataServiceFactory
{
    IDataService Create();
}

public class DataServiceFactory(IServiceProvider serviceProvider) : IDataServiceFactory
{
    public IDataService Create()
    {
        using var scope = serviceProvider.CreateScope();
        return scope.ServiceProvider.GetRequiredService<IDataService>();
    }
}