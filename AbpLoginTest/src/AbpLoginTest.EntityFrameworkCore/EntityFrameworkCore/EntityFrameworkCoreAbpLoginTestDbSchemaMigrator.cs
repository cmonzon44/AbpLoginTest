using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using AbpLoginTest.Data;
using Volo.Abp.DependencyInjection;

namespace AbpLoginTest.EntityFrameworkCore;

public class EntityFrameworkCoreAbpLoginTestDbSchemaMigrator
    : IAbpLoginTestDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreAbpLoginTestDbSchemaMigrator(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the AbpLoginTestDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<AbpLoginTestDbContext>()
            .Database
            .MigrateAsync();
    }
}
