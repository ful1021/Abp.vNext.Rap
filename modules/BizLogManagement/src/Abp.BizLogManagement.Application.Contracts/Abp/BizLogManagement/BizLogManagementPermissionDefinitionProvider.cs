using Abp.BizLogManagement.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Abp.BizLogManagement
{
    public class BizLogManagementPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            //var moduleGroup = context.AddGroup(BizLogManagementPermissions.GroupName, L("Permission:BizLogManagement"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<BizLogManagementResource>(name);
        }
    }
}