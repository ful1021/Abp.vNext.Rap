namespace Abp.BizLogManagement
{
    public class BizLogManagementPermissions
    {
        public const string GroupName = "BizLogManagement";

        public static string[] GetAll()
        {
            return new[]
            {
                GroupName
            };
        }
    }
}