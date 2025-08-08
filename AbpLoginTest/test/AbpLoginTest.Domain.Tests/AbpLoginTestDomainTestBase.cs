using Volo.Abp.Modularity;

namespace AbpLoginTest;

/* Inherit from this class for your domain layer tests. */
public abstract class AbpLoginTestDomainTestBase<TStartupModule> : AbpLoginTestTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
