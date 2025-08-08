using AbpLoginTest.Localization;
using Volo.Abp.Application.Services;

namespace AbpLoginTest;

/* Inherit your application services from this class.
 */
public abstract class AbpLoginTestAppService : ApplicationService
{
    protected AbpLoginTestAppService()
    {
        LocalizationResource = typeof(AbpLoginTestResource);
    }
}
