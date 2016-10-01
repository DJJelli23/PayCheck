using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Collections;
using PayCheck.States.Utah;

namespace PayCheck
{
    public class UtahDS : UtahDSInterface
    {
        private UtahDAO UTDAO = new UtahDAO();

        public UtahDS()
        {
        }

        public decimal SomeMethod(String sql, String sql3, int guess)
        {
            String sql2 = "Select " + sql + " from [Utah State Tax] where year=2016";
            if (guess == 0)
            {
                return UTDAO.SelectMethodInt(sql2, sql3);
            }
            return UTDAO.SelectMethod(sql2, sql3);
        }
    }
}
