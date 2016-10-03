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

namespace PayCheck.Federal
{
    class FederalDAO : BaseDAO
    {
        public decimal SelectMethod(string sql2, string sql)
        {
            SqlConnection con;
            string sqlState = "";
            decimal matchingTaxInformation = 0;
            con = connect("State and Fed Taxes");
            sqlState = sql;
            SqlCommand com = new SqlCommand(sql2, con);
            SqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                matchingTaxInformation = Convert.ToDecimal(reader[sqlState]);
            }
            con.Close();
            return matchingTaxInformation;
        }

        public int SelectMethodInt(string sql2, string sql)
        {
            SqlConnection con;
            string sqlState = "";
            int matchingTaxInformation = 0;
            con = connect("State and Fed Taxes");
            sqlState = sql;
            SqlCommand com = new SqlCommand(sql2, con);
            SqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                matchingTaxInformation = Convert.ToInt32(reader[sqlState]);
            }
            con.Close();
            return matchingTaxInformation;
        }
    }
}
