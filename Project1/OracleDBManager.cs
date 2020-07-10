using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;

namespace Project1
{
    class OracleDBManager
    {
        public string LastExceptionString = string.Empty;
        public string ConnectionString = string.Empty;
        public string Address = string.Empty;
        public string Port = string.Empty;

        public OracleConnection Connection { get; private set; }



        public bool GetConnection()
        {
            try
            {
                if (this.Connection != null)
                {
                    this.Connection.Close();
                    this.Connection.Dispose();
                    this.Connection = null;
                }

                if (ConnectionString == string.Empty)
                    SetConnectionString();

                Connection = new OracleConnection(ConnectionString);

                if (this.Address != string.Empty)
                    Connection.Open();
            }
            catch (Exception ex)
            {
                System.Reflection.MemberInfo info = System.Reflection.MethodInfo.GetCurrentMethod();
                string id = string.Format("{0}.{1}", info.ReflectedType.Name, info.Name);
                Console.WriteLine(id);
                Console.WriteLine(ex);
                return false;
            }

            if (Connection.State == ConnectionState.Open)
                return true;
            else
                return false;
        }

        private void SetConnectionString()
        {
            string user = ConfigManager.GetValue("DATABASE", "USER");
            string pwd = ConfigManager.GetValue("DATABASE", "PWD");
            string port = ConfigManager.GetValue("DATABASE", "PORT");
            string sid = ConfigManager.GetValue("DATABASE", "SID");
            string svr = ConfigManager.GetValue("DATABASE", "SERVICE_NAME");
            string addr01 = ConfigManager.GetValue("DATABASE", "D_ADDR01");
            string addr02 = ConfigManager.GetValue("DATABASE", "D_ADDR02");

            string address01 = string.Format("(ADDRESS = (PROTOCOL = TCP)(HOST = {0})(PORT = {1}))", addr01, port);
            string address02 = string.Format("(ADDRESS = (PROTOCOL = TCP)(HOST = {0})(PORT = {1}))", addr02, port);
            string dataSource = string.Format(@"(DESCRIPTION =(ADDRESS_LIST ={0}{1})(CONNECT_DATA =(", address01, address02);

            dataSource += svr == string.Empty ? string.Format("SID = {0})))", sid) : string.Format("SERVICE_NAME = {0})))", svr);

            this.Address = addr01;
            this.Port = port;
            this.ConnectionString = "User Id=" + user + ";Password=" + pwd + ";Data Source=" + dataSource;
        }
    }
}
