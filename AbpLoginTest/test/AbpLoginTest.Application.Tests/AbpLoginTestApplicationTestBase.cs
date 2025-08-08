using Volo.Abp.Modularity;

namespace AbpLoginTest;

public abstract class AbpLoginTestApplicationTestBase<TStartupModule> : AbpLoginTestTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
