using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Collections;
using PayCheck.Federal;

namespace PayCheck.Federal
{
    public class FederalDS : FederalDSInterface
    {
        private FederalDAO FedDAO = new FederalDAO();

        public FederalDS()
        {
        }

        public decimal SomeMethod(String sql, String sql3, int guess)
        {
            String sql2 = "Select " + sql + " from [Federal Tax] where year=2015";
            if (guess == 0)
            {
                return FedDAO.SelectMethodInt(sql2, sql3);
            }
            return FedDAO.SelectMethod(sql2, sql3);
        }
    }
}