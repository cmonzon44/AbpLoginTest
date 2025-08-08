using AbpLoginTest.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace AbpLoginTest.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class AbpLoginTestController : AbpControllerBase
{
    protected AbpLoginTestController()
    {
        LocalizationResource = typeof(AbpLoginTestResource);
    }
}
