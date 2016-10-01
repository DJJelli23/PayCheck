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
            decimal line1;
            decimal line2 = 0;
            decimal line3;
            decimal line4;
            decimal statePre = coloDS.SomeMethod("[State Percentage]", "State Percentage", 1);
            //this is where the if statement would go to see which payperiod the user has.
            switch (MaritalStatus)
            {
                case 1:
                case 3:
                    line1 = IncomeAmount;
                    switch (AllowenceAmount)
                    {
                        case 0:
                            line2 = 0;
                            break;
                        case 1:
                            line2 = 154;
                            break;
                        case 2:
                            line2 = 308;
                            break;
                        case 3:
                            line2 = 462;
                            break;
                        case 4:
                            line2 = 615;
                            break;
                        case 5:
                            line2 = 769;
                            break;
                        case 6:
                            line2 = 923;
                            break;
                        case 7:
                            line2 = 1077;
                            break;
                        case 8:
                            line2 = 1231;
                            break;
                        case 9:
                            line2 = 1365;
                            break;
                        case 10:
                            line2 = 1538;
                            break;
                        default:
                            if (AllowenceAmount > 10)
                            {
                                int temp = AllowenceAmount - 10;
                                temp *= 154;
                                line2 = temp;
                            }
                            break;
                    }
                    line3 = line1 - line2;
                    if (line3 >= 44)
                    {
                        line4 = (line3 - 44) * statePre;
                    }
                    else
                    {
                        line4 = 0;
                    }
                    StateWith = line4;
                    break;
                case 2:
                case 4:
                    line1 = IncomeAmount;
                    switch (AllowenceAmount)
                    {
                        case 0:
                            line2 = 0;
                            break;
                        case 1:
                            line2 = 154;
                            break;
                        case 2:
                            line2 = 308;
                            break;
                        case 3:
                            line2 = 462;
                            break;
                        case 4:
                            line2 = 615;
                            break;
                        case 5:
                            line2 = 769;
                            break;
                        case 6:
                            line2 = 923;
                            break;
                        case 7:
                            line2 = 1077;
                            break;
                        case 8:
                            line2 = 1231;
                            break;
                        case 9:
                            line2 = 1365;
                            break;
                        case 10:
                            line2 = 1538;
                            break;
                        default:
                            if (AllowenceAmount > 10)
                            {
                                int temp = AllowenceAmount - 10;
                                temp *= 154;
                                line2 = temp;
                            }
                            break;
                    }
                    line3 = line1 - line2;
                    if (line3 >= 165)
                    {
                        line4 = (line3 - 165) * statePre;
                    }
                    else
                    {
                        line4 = 0;
                    }
                    StateWith = line4;
                    break;
                default:
                    line1 = IncomeAmount;
                    switch (AllowenceAmount)
                    {
                        case 0:
                            line2 = 0;
                            break;
                        case 1:
                            line2 = 154;
                            break;
                        case 2:
                            line2 = 308;
                            break;
                        case 3:
                            line2 = 462;
                            break;
                        case 4:
                            line2 = 615;
                            break;
                        case 5:
                            line2 = 769;
                            break;
                        case 6:
                            line2 = 923;
                            break;
                        case 7:
                            line2 = 1077;
                            break;
                        case 8:
                            line2 = 1231;
                            break;
                        case 9:
                            line2 = 1365;
                            break;
                        case 10:
                            line2 = 1538;
                            break;
                        default:
                            if (AllowenceAmount > 10)
                            {
                                int temp = AllowenceAmount - 10;
                                temp *= 154;
                                line2 = temp;
                            }
                            break;
                    }
                    line3 = line1 - line2;
                    if (line3 >= 44)
                    {
                        line4 = (line3 - 44) * statePre;
                    }
                    else
                    {
                        line4 = 0;
                    }
                    StateWith = line4;
                    break;
            }
            return StateWith;
        }
    }
}
