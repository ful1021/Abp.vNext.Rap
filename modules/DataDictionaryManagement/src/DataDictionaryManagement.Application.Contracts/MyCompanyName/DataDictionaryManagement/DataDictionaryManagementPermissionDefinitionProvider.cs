using DataDictionaryManagement.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace DataDictionaryManagement
{
    public class DataDictionaryManagementPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            //var moduleGroup = context.AddGroup(DataDictionaryManagementPermissions.GroupName, L("Permission:DataDictionaryManagement"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<DataDictionaryManagementResource>(name);
        }
    }
}