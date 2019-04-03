using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>();
        ///only methods inside of the global config class can change the values of Connections
        ///as a private set; but everyone can read the value of Connections
        ///made a list if Idataconnection, for the possibility to save to the database as well
        ///as the textfiles

        public static void InitializeConnections(bool database, bool textFiles)
        {
            if (database)
            {
                // ToDo -- Set up Sql Connector properly. 
                SqlConnector sql = new SqlConnector();
                Connections.Add(sql);
            }
            if (textFiles)
            {
                //ToDo -- Create the Text Connection
                TextConnection text = new TextConnection();
                Connections.Add(text);
            }
        }
    }
}
