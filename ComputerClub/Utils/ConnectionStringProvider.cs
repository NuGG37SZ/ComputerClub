using System.Configuration;

namespace ComputerClub.Utils
{
    public class ConnectionStringProvider
    {
        public static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["connectionStr"].ConnectionString;
        }
    }
}
