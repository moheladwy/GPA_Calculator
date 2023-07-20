using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using GPA_Calculator_Library.Connectors;

namespace GPA_Calculator_Library
{
    public class GlobalConfig
    {
        public static SqlConnector connection { get; private set; }

        public static void InitializeConnection()
        {
            connection = new SqlConnector();
        }

        public static string ConnectionString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
