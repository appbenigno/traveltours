using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Lib
{
    public class Connections
    {
        private string serverName;
        private string databaseName;

        public string ServerName
        {
            get
            {
                return serverName;
            }

            set
            {
                serverName = value;
            }
        }

        public string DatabaseName
        {
            get
            {
                return databaseName;
            }

            set
            {
                databaseName = value;
            }
        }

        public Connections()
        { }

        public Connections(string servName, string dataBName)
        {
            ServerName = servName;
            DatabaseName = dataBName;
        }
    }
}
