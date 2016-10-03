using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Collections;
using DAO;

namespace PayCheck
{
    class UtahDAO : BaseDAO
    {
        SqlConnection con;
        string sql = "";
        public decimal SelectMethod(string sql2, string sql)
        {
            decimal matchingTaxInformation = 0;
            con = connect("State and Fed Taxes");
            this.sql = sql;
            SqlCommand com = new SqlCommand(sql2, con);
            SqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                matchingTaxInformation = Convert.ToDecimal(reader[sql]);
            }
            con.Close();
            return matchingTaxInformation;
        }

        public int SelectMethodInt(string sql2, string sql)
        {
            int matchingTaxInformation = 0;
            con = connect("State and Fed Taxes");
            this.sql = sql;
            SqlCommand com = new SqlCommand(sql2, con);
            SqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                matchingTaxInformation = Convert.ToInt16(reader[sql]);
            }
            con.Close();
            return matchingTaxInformation;
        }
    }
}
