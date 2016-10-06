using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAO
{
    //Part 6 of ADO.NET will show a better way to access the database.
    public abstract class BaseDAO
    {
        SqlConnection connection;
        string defaultCon = "Data Source=.;Integrated Security=true";
        
        // String defaultCon = "Data Source=DJJELLINGS\\SQLExpress;AttachDbFilename=C:\\Program Files\\Microsoft SQL Server
        // \\MSSQL10_50.SQLEXPRESS\\MSSQL\\DATA\\State and Fed Taxes.mdf;Integrated Security=true";

        public SqlConnection connect(string database)
        {
            return connect(defaultCon, database);
        }

        public SqlConnection connect(string connectionStr, string dbName)
        {
            connection = new SqlConnection(connectionStr);
            connection.Open();
            connection.ChangeDatabase(dbName);
            return connection;
        }

        public void close()
        {
            if (connection != null)
                connection.Close();
        }
    }
}