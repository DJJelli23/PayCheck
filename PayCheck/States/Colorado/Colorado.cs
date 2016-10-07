using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayCheck
{
    class Colorado : StateClass
    {
        ColoradoDS coloDS = new ColoradoDS();
        public new decimal CalculateStateTax()
        {
            decimal grossAmount;
            decimal numWithAllowances = 0;
            decimal diffOfAllowandGross;
            decimal totalAfterPerWithTableandStatePre;
            decimal statePre = coloDS.SomeMethod("[State Percentage]", "State Percentage", 1);
            //this is where the if statement would go to see which payperiod the user has.
            switch (MaritalStatus)
            {
                case 1:
                case 3:
                    grossAmount = IncomeAmount;
                    switch (AllowenceAmount)
                    {
                        case 0:
                            numWithAllowances = 0;
                            break;
                        case 1:
                            numWithAllowances = 154;
                            break;
                        case 2:
                            numWithAllowances = 308;
                            break;
                        case 3:
                            numWithAllowances = 462;
                            break;
                        case 4:
                            numWithAllowances = 615;
                            break;
                        case 5:
                            numWithAllowances = 769;
                            break;
                        case 6:
                            numWithAllowances = 923;
                            break;
                        case 7:
                            numWithAllowances = 1077;
                            break;
                        case 8:
                            numWithAllowances = 1231;
                            break;
                        case 9:
                            numWithAllowances = 1365;
                            break;
                        case 10:
                            numWithAllowances = 1538;
                            break;
                        default:
                            if (AllowenceAmount > 10)
                            {
                                int temp = AllowenceAmount - 10;
                                temp *= 154;
                                numWithAllowances = temp;
                            }
                            break;
                    }
                    diffOfAllowandGross = grossAmount - numWithAllowances;
                    if (diffOfAllowandGross > 44)
                    {
                        totalAfterPerWithTableandStatePre = (diffOfAllowandGross - 44) * statePre;
                    }
                    else
                    {
                        totalAfterPerWithTableandStatePre = 0;
                    }
                    StateWith = totalAfterPerWithTableandStatePre;
                    break;
                case 2:
                case 4:
                    grossAmount = IncomeAmount;
                    switch (AllowenceAmount)
                    {
                        case 0:
                            numWithAllowances = 0;
                            break;
                        case 1:
                            numWithAllowances = 154;
                            break;
                        case 2:
                            numWithAllowances = 308;
                            break;
                        case 3:
                            numWithAllowances = 462;
                            break;
                        case 4:
                            numWithAllowances = 615;
                            break;
                        case 5:
                            numWithAllowances = 769;
                            break;
                        case 6:
                            numWithAllowances = 923;
                            break;
                        case 7:
                            numWithAllowances = 1077;
                            break;
                        case 8:
                            numWithAllowances = 1231;
                            break;
                        case 9:
                            numWithAllowances = 1365;
                            break;
                        case 10:
                            numWithAllowances = 1538;
                            break;
                        default:
                            if (AllowenceAmount > 10)
                            {
                                int temp = AllowenceAmount - 10;
                                temp *= 154;
                                numWithAllowances = temp;
                            }
                            break;
                    }
                    diffOfAllowandGross = grossAmount - numWithAllowances;
                    if (diffOfAllowandGross > 165)
                    {
                        totalAfterPerWithTableandStatePre = (diffOfAllowandGross - 165) * statePre;
                    }
                    else
                    {
                        totalAfterPerWithTableandStatePre = 0;
                    }
                    StateWith = totalAfterPerWithTableandStatePre;
                    break;
                default:
                    grossAmount = IncomeAmount;
                    switch (AllowenceAmount)
                    {
                        case 0:
                            numWithAllowances = 0;
                            break;
                        case 1:
                            numWithAllowances = 154;
                            break;
                        case 2:
                            numWithAllowances = 308;
                            break;
                        case 3:
                            numWithAllowances = 462;
                            break;
                        case 4:
                            numWithAllowances = 615;
                            break;
                        case 5:
                            numWithAllowances = 769;
                            break;
                        case 6:
                            numWithAllowances = 923;
                            break;
                        case 7:
                            numWithAllowances = 1077;
                            break;
                        case 8:
                            numWithAllowances = 1231;
                            break;
                        case 9:
                            numWithAllowances = 1365;
                            break;
                        case 10:
                            numWithAllowances = 1538;
                            break;
                        default:
                            if (AllowenceAmount > 10)
                            {
                                int temp = AllowenceAmount - 10;
                                temp *= 154;
                                numWithAllowances = temp;
                            }
                            break;
                    }
                    diffOfAllowandGross = grossAmount - numWithAllowances;
                    if (diffOfAllowandGross > 44)
                    {
                        totalAfterPerWithTableandStatePre = (diffOfAllowandGross - 44) * statePre;
                    }
                    else
                    {
                        totalAfterPerWithTableandStatePre = 0;
                    }
                    StateWith = totalAfterPerWithTableandStatePre;
                    break;
            }
            return StateWith;
        }
    }
}
