using Volo.Abp.Modularity;

namespace AbpLoginTest;

[DependsOn(
    typeof(AbpLoginTestDomainModule),
    typeof(AbpLoginTestTestBaseModule)
)]
public class AbpLoginTestDomainTestModule : AbpModule
{

}
