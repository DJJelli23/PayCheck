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
    public class Utah : StateClass
    {
        UtahDS utahDS = new UtahDS();
        public new decimal CalculateStateTax()
        {
            decimal line1;
            decimal line2;
            decimal line3;
            decimal line4;
            decimal line5;
            decimal line6;
            decimal line7;
            decimal line8;
            decimal line9;
            decimal statePre = utahDS.SomeMethod("[State Tax Amount]", "State Tax Amount", 1);

            //this is where the if statement would go to see which payperiod the user has.
            switch (MaritalStatus)
            {
                case 1:
                case 3:
                    line1 = IncomeAmount;
                    line2 = statePre * line1;
                    line3 = AllowenceAmount;
                    line4 = line3 * 5;
                    line5 = utahDS.SomeMethod("[Biweekly Base Allowence Single]", "Biweekly Base Allowence Single", 0);
                    line6 = line4 + line5;
                    line7 = line1 - utahDS.SomeMethod("[Biweekly Amount Single]", "Biweekly Amount Single", 0);
                    line8 = line7 * utahDS.SomeMethod("[Multiply by a Percent]", "Multiply by a Percent", 1);
                    line9 = line6 - line8;
                    StateWith = line2 - line9;
                    break;
                case 2:
                case 4:
                    line1 = IncomeAmount;
                    line2 = statePre * line1;
                    line3 = AllowenceAmount;
                    line4 = line3 * 5;
                    line5 = utahDS.SomeMethod("[Biweekly Base Allowence Married]","Biweekly Base Allowence Married", 0);
                    line6 = line4 + line5;
                    line7 = line1 - utahDS.SomeMethod("[Biweekly Amount Married]", "Biweekly Amount Married", 0);
                    line8 = line7 * utahDS.SomeMethod("[Multiply by a Percent]", "Multiply by a Percent", 1);
                    line9 = line6 - line8;
                    StateWith = line2 - line9;
                    break;
                default:
                    line1 = IncomeAmount;
                    line2 = statePre * line1;
                    line3 = AllowenceAmount;
                    line4 = line3 * 5;
                    line5 = utahDS.SomeMethod("[Biweekly Base Allowence Single]", "Biweekly Base Allowence Single", 0);
                    line6 = line4 + line5;
                    line7 = line1 - utahDS.SomeMethod("[Biweekly Amount Single]","Biweekly Amount Single", 0);
                    line8 = line7 * utahDS.SomeMethod("[Multiply by a Percent]", "Multiply by a Percent", 1);
                    line9 = line6 - line8;
                    StateWith = line2 - line9;
                    break;
            }
            return StateWith;
        }
    }
}