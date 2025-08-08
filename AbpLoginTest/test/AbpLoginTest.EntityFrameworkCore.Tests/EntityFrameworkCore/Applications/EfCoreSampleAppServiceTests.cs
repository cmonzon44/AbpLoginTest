using AbpLoginTest.Samples;
using Xunit;

namespace AbpLoginTest.EntityFrameworkCore.Applications;

[Collection(AbpLoginTestTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<AbpLoginTestEntityFrameworkCoreTestModule>
{

}
