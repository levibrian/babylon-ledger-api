using Babylon.Ledger.Domain.Features.Incomes.Services;
using Babylon.Ledger.Domain.Features.Incomes.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Babylon.Ledger.Domain.Features.Incomes.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddIncomesFeature(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddScoped<IIncomeService, IncomeService>();
        
        return serviceCollection;
    }
}