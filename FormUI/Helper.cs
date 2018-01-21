using System.Configuration;

namespace FormUI
{
    public static class Helper
    {
        public static string ConnString(string name)
        {
           return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
