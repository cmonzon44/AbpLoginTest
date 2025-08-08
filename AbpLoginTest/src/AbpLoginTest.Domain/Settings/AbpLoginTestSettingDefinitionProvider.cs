using Volo.Abp.Settings;

namespace AbpLoginTest.Settings;

public class AbpLoginTestSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(AbpLoginTestSettings.MySetting1));
    }
}
