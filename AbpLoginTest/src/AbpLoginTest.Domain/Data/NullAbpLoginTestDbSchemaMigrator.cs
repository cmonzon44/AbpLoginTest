using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace AbpLoginTest.Data;

/* This is used if database provider does't define
 * IAbpLoginTestDbSchemaMigrator implementation.
 */
public class NullAbpLoginTestDbSchemaMigrator : IAbpLoginTestDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
