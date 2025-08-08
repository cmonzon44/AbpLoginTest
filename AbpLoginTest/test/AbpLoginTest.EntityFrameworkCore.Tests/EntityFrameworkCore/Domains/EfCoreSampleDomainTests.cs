using AbpLoginTest.Samples;
using Xunit;

namespace AbpLoginTest.EntityFrameworkCore.Domains;

[Collection(AbpLoginTestTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<AbpLoginTestEntityFrameworkCoreTestModule>
{

}
