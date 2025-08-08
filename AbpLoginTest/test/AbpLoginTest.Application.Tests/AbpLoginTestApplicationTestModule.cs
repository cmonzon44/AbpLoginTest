using Volo.Abp.Modularity;

namespace AbpLoginTest;

[DependsOn(
    typeof(AbpLoginTestApplicationModule),
    typeof(AbpLoginTestDomainTestModule)
)]
public class AbpLoginTestApplicationTestModule : AbpModule
{

}
