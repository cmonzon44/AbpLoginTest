using AbpLoginTest.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace AbpLoginTest.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(AbpLoginTestEntityFrameworkCoreModule),
    typeof(AbpLoginTestApplicationContractsModule)
)]
public class AbpLoginTestDbMigratorModule : AbpModule
{
}
