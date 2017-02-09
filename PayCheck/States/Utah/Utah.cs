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
            decimal grossIncome;
            decimal timesStateAmount;
            decimal numWithAllowances;
            decimal timesAllowanceBy;
            decimal baseAllowance;
            decimal sumOfAllowances;
            decimal diffOfGross;
            decimal diffGrossTimesPercent;
            decimal diffOfAllowandGrossPercent;
            decimal statePre = utahDS.SomeMethod("[State Tax Amount]", "State Tax Amount", 1);

            //this is where the if statement would go to see which pay period the user has.
            switch (MaritalStatus)
            {
                case 1:
                case 3:
                    grossIncome = IncomeAmount;
                    timesStateAmount = statePre * grossIncome;
                    numWithAllowances = AllowenceAmount;
                    timesAllowanceBy = numWithAllowances * 5;
                    baseAllowance = utahDS.SomeMethod("[Biweekly Base Allowence Single]", "Biweekly Base Allowence Single", 0);
                    sumOfAllowances = timesAllowanceBy + baseAllowance;
                    diffOfGross = grossIncome - utahDS.SomeMethod("[Biweekly Amount Single]", "Biweekly Amount Single", 0);
                    diffGrossTimesPercent = diffOfGross * utahDS.SomeMethod("[Multiply by a Percent]", "Multiply by a Percent", 1);
                    diffOfAllowandGrossPercent = sumOfAllowances - diffGrossTimesPercent;
                    StateWith = timesStateAmount - diffOfAllowandGrossPercent;
                    break;
                case 2:
                case 4:
                    grossIncome = IncomeAmount;
                    timesStateAmount = statePre * grossIncome;
                    numWithAllowances = AllowenceAmount;
                    timesAllowanceBy = numWithAllowances * 5;
                    baseAllowance = utahDS.SomeMethod("[Biweekly Base Allowence Married]","Biweekly Base Allowence Married", 0);
                    sumOfAllowances = timesAllowanceBy + baseAllowance;
                    diffOfGross = grossIncome - utahDS.SomeMethod("[Biweekly Amount Married]", "Biweekly Amount Married", 0);
                    diffGrossTimesPercent = diffOfGross * utahDS.SomeMethod("[Multiply by a Percent]", "Multiply by a Percent", 1);
                    diffOfAllowandGrossPercent = sumOfAllowances - diffGrossTimesPercent;
                    StateWith = timesStateAmount - diffOfAllowandGrossPercent;
                    break;
                default:
                    grossIncome = IncomeAmount;
                    timesStateAmount = statePre * grossIncome;
                    numWithAllowances = AllowenceAmount;
                    timesAllowanceBy = numWithAllowances * 5;
                    baseAllowance = utahDS.SomeMethod("[Biweekly Base Allowence Single]", "Biweekly Base Allowence Single", 0);
                    sumOfAllowances = timesAllowanceBy + baseAllowance;
                    diffOfGross = grossIncome - utahDS.SomeMethod("[Biweekly Amount Single]","Biweekly Amount Single", 0);
                    diffGrossTimesPercent = diffOfGross * utahDS.SomeMethod("[Multiply by a Percent]", "Multiply by a Percent", 1);
                    diffOfAllowandGrossPercent = sumOfAllowances - diffGrossTimesPercent;
                    StateWith = timesStateAmount - diffOfAllowandGrossPercent;
                    break;
            }
            return StateWith;
        }
    }
}