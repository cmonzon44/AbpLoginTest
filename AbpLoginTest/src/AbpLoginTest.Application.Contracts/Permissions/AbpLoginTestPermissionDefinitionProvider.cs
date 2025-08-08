using AbpLoginTest.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.MultiTenancy;

namespace AbpLoginTest.Permissions;

public class AbpLoginTestPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(AbpLoginTestPermissions.GroupName);

        //Define your own permissions here. Example:
        //myGroup.AddPermission(AbpLoginTestPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<AbpLoginTestResource>(name);
    }
}
