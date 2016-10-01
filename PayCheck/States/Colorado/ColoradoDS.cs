using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Collections;
using PayCheck.States.Colorado;

namespace PayCheck
{
    public class ColoradoDS : ColoradoDSInterface
    {
        private ColoradoDAO CODAO = new ColoradoDAO();

        public ColoradoDS()
        {
        }

        public decimal SomeMethod(String sql, String sql3, int guess)
        {
            String sql2 = "Select " + sql + " from [Colorado State Tax] where year=2015";
            if (guess == 0)
            {
                return CODAO.SelectMethodInt(sql2, sql3);
            }
            return CODAO.SelectMethod(sql2, sql3);
        }
    }
}

