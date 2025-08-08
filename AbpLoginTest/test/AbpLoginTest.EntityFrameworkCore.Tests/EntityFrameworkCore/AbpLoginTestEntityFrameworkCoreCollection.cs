using Xunit;

namespace AbpLoginTest.EntityFrameworkCore;

[CollectionDefinition(AbpLoginTestTestConsts.CollectionDefinitionName)]
public class AbpLoginTestEntityFrameworkCoreCollection : ICollectionFixture<AbpLoginTestEntityFrameworkCoreFixture>
{

}
