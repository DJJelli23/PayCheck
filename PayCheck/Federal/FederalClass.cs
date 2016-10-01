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


namespace PayCheck
{
    class FederalClass
    {
        FederalDS fedDS = new FederalDS();

        public decimal CalcAllowFederal(int allowAM, decimal totalAM)//Calcualting allowences for Federal taxes.
        {
            decimal withHoldingAllowance = fedDS.SomeMethod("[Annually Allowence]", "Annually Allowence", 1);
            decimal valueOfAllowance = withHoldingAllowance * allowAM;
            decimal income = 0;
            decimal taxableIncome;

            income = totalAM * 26;
            taxableIncome = income - valueOfAllowance;
            return taxableIncome;
        }
        public decimal CalcFederalTax(decimal wholeIncome, int sinMar)
        {
            decimal fedWith = 0;
            decimal fedPre = 0;
            int singleMarried = sinMar;
            //Make a switch statement here to get what the customer filed.
            switch (singleMarried)
            {
                case 1://This one is for a user filling Single.
                case 3:
                    {
                        if (wholeIncome > fedDS.SomeMethod("[Annual Bracket One Single]", "Annual Bracket One Single", 0) && wholeIncome <= fedDS.SomeMethod("[Annual Bracket Two Single]", "Annual Bracket Two Single", 0) || wholeIncome >= fedDS.SomeMethod("[Annual Bracket Two Single]", "Annual Bracket Two Single", 0) + 1)
                            //Checking the first set of brackets for Federal tax on income.
                        {
                            fedPre = fedDS.SomeMethod("[Percent Bracket One]", "Percent Bracket One", 1);
                            fedWith = fedPre * (wholeIncome - fedDS.SomeMethod("[Annual Bracket One Single]", "Annual Bracket One Single", 0)) + fedDS.SomeMethod("[Annual Amount Bracket One Single]", "Annual Amount Bracket One Single", 1);
                            if (wholeIncome > fedDS.SomeMethod("[Annual Bracket Two Single]", "Annual Bracket Two Single", 0) && wholeIncome <= 39750 || wholeIncome >= fedDS.SomeMethod("[Annual Bracket Three Single]", "Annual Bracket Three Single", 0) + 1)
                                //The second set of the bracket is 15%.
                            {
                                fedPre = fedDS.SomeMethod("[Percent Bracket Two]", "Percent Bracket Two", 1);
                                fedWith += fedPre * (wholeIncome - fedDS.SomeMethod("[Annual Bracket Two Single]", "Annual Bracket Two Single", 0)) + fedDS.SomeMethod("[Annual Amount Bracket Two Single]", "Annual Amount Bracket Two Single", 1);
                                if (wholeIncome > fedDS.SomeMethod("[Annual Bracket Three Single]", "Annual Bracket Three Single", 0) && wholeIncome < fedDS.SomeMethod("[Annual Bracket Four Single]", "Annual Bracket Four Single", 0))
                                    //The third set of the bracket is 28%.
                                {
                                    fedPre = fedDS.SomeMethod("[Percent Bracket Three]", "Percent Bracket Three", 1);
                                    fedWith += fedPre * (wholeIncome - fedDS.SomeMethod("[Annual Bracket Three Single]", "Annual Bracket Three Single", 0)) + fedDS.SomeMethod("[Annual Amount Bracket Three Single]", "Annual Amount Bracket Three Single", 1);
                                    return fedWith / 26;
                                }
                                else if (wholeIncome >= fedDS.SomeMethod("[Annual Bracket Three Single]", "Annual Bracket Three Single", 0) + 1)
                                {
                                    fedPre = fedDS.SomeMethod("[Percent Bracket Three]", "Percent Bracket Three", 1);
                                    fedWith += fedPre * (wholeIncome - fedDS.SomeMethod("[Annual Bracket Three Single]", "Annual Bracket Three Single", 0)) + fedDS.SomeMethod("[Annual Amount Bracket Three Single]", "Annual Amount Bracket Three Single", 1);
                                    if (wholeIncome > fedDS.SomeMethod("[Annual Bracket Four Single]", "Annual Bracket Four Single", 0) && wholeIncome < fedDS.SomeMethod("[Annual Bracket Five Single]", "Annual Bracket Five Single", 0))
                                        //The fourth set of the bracket is 28%.
                                    {
                                        fedPre = fedDS.SomeMethod("[Percent Bracket Four]", "Percent Bracket Four", 1);
                                        fedWith += fedPre * (wholeIncome - fedDS.SomeMethod("[Annual Bracket Four Single]", "Annual Bracket Four Single", 0)) + fedDS.SomeMethod("[Annual Amount Bracket Four Single]", "Annual Amount Bracket Four Single", 1);
                                        return fedWith / 26;
                                    }
                                    else if (wholeIncome >= fedDS.SomeMethod("[Annual Bracket Four Single]", "Annual Bracket Four Single", 0) + 1)
                                    {
                                        fedPre = fedDS.SomeMethod("[Percent Bracket Four]", "Percent Bracket Four", 1);
                                        fedWith += fedPre * (wholeIncome - fedDS.SomeMethod("[Annual Bracket Four Single]", "Annual Bracket Four Single", 0)) + fedDS.SomeMethod("[Annual Amount Bracket Four Single]", "Annual Amount Bracket Four Single", 1);
                                        if (wholeIncome > fedDS.SomeMethod("[Annual Bracket Five Single]", "Annual Bracket Five Single", 0) && wholeIncome < fedDS.SomeMethod("[Annual Bracket Six Single]", "Annual Bracket Six Single", 0))
                                            //The fifth set of the bracket is 33%.
                                        {
                                            fedPre = fedDS.SomeMethod("[Percent Bracket Five]", "Percent Bracket Five", 1);
                                            fedWith += fedPre * (wholeIncome - fedDS.SomeMethod("[Annual Bracket Five Single]", "Annual Bracket Five Single", 0)) + fedDS.SomeMethod("[Annual Amount Bracket Five Single]", "Annual Amount Bracket Five Single", 1);
                                            return fedWith / 26;
                                        }
                                        else if (wholeIncome >= fedDS.SomeMethod("[Annual Bracket Five Single]", "Annual Bracket Five Single", 0) + 1)
                                        {
                                            fedPre = fedDS.SomeMethod("[Percent Bracket Five]", "Percent Bracket Five", 1);
                                            fedWith += fedPre * (wholeIncome - fedDS.SomeMethod("[Annual Bracket Five Single]", "Annual Bracket Five Single", 0)) + fedDS.SomeMethod("[Annual Amount Bracket Five Single]", "Annual Amount Bracket Five Single", 1);
                                            if (wholeIncome > fedDS.SomeMethod("[Annual Bracket Six Single]", "Annual Bracket Six Single", 0) && wholeIncome < fedDS.SomeMethod("[Annual Bracket Seven Single]", "Annual Bracket Seven Single", 0))
                                                //The sixth set of the bracket is 35%.
                                            {
                                                fedPre = fedDS.SomeMethod("[Percent Bracket Six]", "Percent Bracket Six", 1);
                                                fedWith += fedPre * (wholeIncome - fedDS.SomeMethod("[Annual Bracket Six Single]", "Annual Bracket Six Single", 0)) + fedDS.SomeMethod("[Annual Amount Bracket Six Single]", "Annual Amount Bracket Six Single", 1);
                                                return fedWith / 26;
                                            }
                                            else if (wholeIncome >= fedDS.SomeMethod("[Annual Bracket Six Single]", "Annual Bracket Six Single", 0) + 1)
                                            {
                                                fedPre = fedDS.SomeMethod("[Percent Bracket Six]", "Percent Bracket Six", 1);
                                                fedWith += fedPre * (wholeIncome - fedDS.SomeMethod("[Annual Bracket Six Single]", "Annual Bracket Six Single", 0)) + fedDS.SomeMethod("[Annual Amount Bracket Six Single]", "Annual Amount Bracket Six Single", 1);
                                                if (wholeIncome > fedDS.SomeMethod("[Annual Bracket Seven Single]", "Annual Bracket Seven Single", 0))
                                                    //The seventh set of the bracket is 39.6%.
                                                {
                                                    fedPre = fedDS.SomeMethod("[Percent Bracket Seven]", "Percent Bracket Seven", 1);
                                                    fedWith += fedPre * (wholeIncome - fedDS.SomeMethod("[Annual Bracket Seven Single]", "Annual Bracket Seven Single", 0)) + fedDS.SomeMethod("[Annual Amount Bracket Seven Single]", "Annual Amount Bracket Seven Single", 1);
                                                    return fedWith / 26;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        return fedWith / 26;
                    }
                case 2:
                //This option is for a user filling with Married status.
                case 4:
                    {
                        if (wholeIncome > fedDS.SomeMethod("[Annual Bracket One Married]", "Annual Bracket One Married", 0) && wholeIncome <= fedDS.SomeMethod("[Annual Bracket Two Married]", "Annual Bracket Two Married", 0) || wholeIncome >= fedDS.SomeMethod("[Annual Bracket Two Married]", "Annual Bracket Two Married", 0) + 1)
                            //Checking the first set of brackets for Federal tax on income.
                        {
                            fedPre = fedDS.SomeMethod("[Percent Bracket One]", "Percent Bracket One", 1);
                            fedWith = fedPre * (wholeIncome - fedDS.SomeMethod("[Annual Bracket One Married]", "Annual Bracket One Married", 0) + fedDS.SomeMethod("[Annual Amount Bracket One Married]", "Annual Amount Bracket One Married", 1));
                            if (wholeIncome > fedDS.SomeMethod("[Annual Bracket Two Married]", "Annual Bracket Two Married", 0) && wholeIncome < fedDS.SomeMethod("[Annual Bracket Three Married]", "Annual Bracket Three Married", 0) || wholeIncome >= fedDS.SomeMethod("[Annual Bracket Three Married]", "Annual Bracket Three Married", 0) + 1)
                                //The second set of the bracket is 15%.
                            {
                                fedPre = fedDS.SomeMethod("[Percent Bracket Two]", "Percent Bracket Two", 1);
                                fedWith += fedPre * (wholeIncome - fedDS.SomeMethod("[Annual Bracket Two Married]", "Annual Bracket Two Married", 0)) + fedDS.SomeMethod("[Annual Amount Bracket Two Married]", "Annual Amount Bracket Two Married", 1);
                                if (wholeIncome > fedDS.SomeMethod("[Annual Bracket Three Married]", "Annual Bracket Three Married", 0) && wholeIncome < fedDS.SomeMethod("[Annual Bracket Four Married]", "Annual Bracket Four Married", 0))
                                    //The third set of the bracket is 28%.
                                {
                                    fedPre = fedDS.SomeMethod("[Percent Bracket Three]", "Percent Bracket Three", 1);
                                    fedWith += fedPre * (wholeIncome - fedDS.SomeMethod("[Annual Bracket Three Married]", "Annual Bracket Three Married", 0)) + fedDS.SomeMethod("[Annual Amount Bracket Three Married]", "Annual Amount Bracket Three Married", 1);
                                    return fedWith / 26;
                                }
                                else if (wholeIncome >= fedDS.SomeMethod("[Annual Bracket Three Married]", "Annual Bracket Three Married", 0) + 1)
                                {
                                    fedPre = fedDS.SomeMethod("[Percent Bracket Three]", "Percent Bracket Three", 1);
                                    fedWith += fedPre * (wholeIncome - fedDS.SomeMethod("[Annual Bracket Three Married]", "Annual Bracket Three Married", 0)) + fedDS.SomeMethod("[Annual Amount Bracket Three Married]", "Annual Amount Bracket Three Married", 1);
                                    if (wholeIncome > fedDS.SomeMethod("[Annual Bracket Four Married]", "Annual Bracket Four Married", 0) && wholeIncome < fedDS.SomeMethod("[Annual Bracket Five Married]", "Annual Bracket Five Married", 0))
                                        //The forth set of the bracket is 28%.
                                    {
                                        fedPre = fedDS.SomeMethod("[Percent Bracket Four]", "Percent Bracket Four", 1);
                                        fedWith += fedPre * (wholeIncome - fedDS.SomeMethod("[Annual Bracket Four Married]", "Annual Bracket Four Married", 0)) + fedDS.SomeMethod("[Annual Amount Bracket Four Married]", "Annual Amount Bracket Four Married", 1);
                                        return fedWith / 26;
                                    }
                                    else if (wholeIncome >= fedDS.SomeMethod("[Annual Bracket Four Married]", "Annual Bracket Four Married", 0) + 1)
                                    {
                                        fedPre = fedDS.SomeMethod("[Percent Bracket Four]", "Percent Bracket Four", 1);
                                        fedWith += fedPre * (wholeIncome - fedDS.SomeMethod("[Annual Bracket Four Married]", "Annual Bracket Four Married", 0)) + fedDS.SomeMethod("[Annual Amount Bracket Four Married]", "Annual Amount Bracket Four Married", 1);
                                        if (wholeIncome > fedDS.SomeMethod("[Annual Bracket Five Married]", "Annual Bracket Five Married", 0) && wholeIncome < fedDS.SomeMethod("[Annual Bracket Six Married]", "Annual Bracket Six Married", 0))
                                            //The fifth set of the bracket is 33%.
                                        {
                                            fedPre = fedDS.SomeMethod("[Percent Bracket Five]", "Percent Bracket Five", 1);
                                            fedWith += fedPre * (wholeIncome - fedDS.SomeMethod("[Annual Bracket Five Married]", "Annual Bracket Five Married", 0)) + fedDS.SomeMethod("[Annual Amount Bracket Five Married]", "Annual Amount Bracket Five Married", 1);
                                            return fedWith / 26;
                                        }
                                        else if (wholeIncome >= fedDS.SomeMethod("[Annual Bracket Five Married]", "Annual Bracket Five Married", 0) + 1)
                                        {
                                            fedPre = fedDS.SomeMethod("[Percent Bracket Five]", "Percent Bracket Five", 1);
                                            fedWith += fedPre * (wholeIncome - fedDS.SomeMethod("[Annual Bracket Five Married]", "Annual Bracket Five Married", 0)) + fedDS.SomeMethod("[Annual Amount Bracket Five Married]", "Annual Amount Bracket Five Married", 1); ;
                                            if (wholeIncome > fedDS.SomeMethod("[Annual Bracket Six Married]", "Annual Bracket Six Married", 0) && wholeIncome < fedDS.SomeMethod("[Annual Bracket Seven Married]", "Annual Bracket Seven Married", 0))
                                                //The sixth set of the bracket is 35%.
                                            {
                                                fedPre = fedDS.SomeMethod("[Percent Bracket Six]", "Percent Bracket Six", 1);
                                                fedWith += fedPre * (wholeIncome - fedDS.SomeMethod("[Annual Bracket Six Married]", "Annual Bracket Six Married", 0)) + fedDS.SomeMethod("[Annual Amount Bracket Six Married]", "Annual Amount Bracket Six Married", 1);
                                                return fedWith / 26;
                                            }
                                            else if (wholeIncome >= fedDS.SomeMethod("[Annual Bracket Six Married]", "Annual Bracket Six Married", 0) + 1)
                                            {
                                                fedPre = fedDS.SomeMethod("[Percent Bracket Six]", "Percent Bracket Six", 1);
                                                fedWith += fedPre * (wholeIncome - fedDS.SomeMethod("[Annual Bracket Six Married]", "Annual Bracket Six Married", 0)) + fedDS.SomeMethod("[Annual Amount Bracket Six Married]", "Annual Amount Bracket Six Married", 1);
                                                if (wholeIncome > fedDS.SomeMethod("[Annual Bracket Seven Married]", "Annual Bracket Seven Married", 0))//The seventh set of the bracket is 39.6%.
                                                {
                                                    fedPre = fedDS.SomeMethod("[Percent Bracket Seven]", "Percent Bracket Seven", 1);
                                                    fedWith += fedPre * (wholeIncome - fedDS.SomeMethod("[Annual Bracket Seven Married]", "Annual Bracket Seven Married", 0)) + fedDS.SomeMethod("[Annual Amount Bracket Seven Married]", "Annual Amount Bracket Seven Married", 1);
                                                    return fedWith / 26;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        if (wholeIncome < 0)
                        {
                            return fedWith = 0;
                        }
                        return fedWith / 26;
                    }
                default:
                    {
                        return fedWith / 26;
                    }
            }
        }
    }
}