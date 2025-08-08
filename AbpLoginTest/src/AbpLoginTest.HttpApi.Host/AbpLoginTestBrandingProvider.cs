using Microsoft.Extensions.Localization;
using AbpLoginTest.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace AbpLoginTest;

[Dependency(ReplaceServices = true)]
public class AbpLoginTestBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<AbpLoginTestResource> _localizer;

    public AbpLoginTestBrandingProvider(IStringLocalizer<AbpLoginTestResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
