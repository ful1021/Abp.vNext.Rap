namespace Abp.DataDictionaryManagement
{
    public class DataDictionaryManagementPermissions
    {
        public const string GroupName = "DataDictionaryManagement";

        public static string[] GetAll()
        {
            return new[]
            {
                GroupName
            };
        }
    }
}