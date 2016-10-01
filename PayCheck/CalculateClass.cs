using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayCheck
{
    class CalculateClass
    {
        private decimal total = 0;
        private decimal subtotal = 0;
        private decimal preTax = 0;
        private decimal postTax = 0;
        private decimal hourly;
        private int allowences;
        private decimal fedMed = .0145M;
        private decimal fedSS = .062M;
        private decimal firstWeek;
        private decimal secWeek;
        private int sinMar = 0;

        FederalClass fed = new FederalClass();

        //Converting minutes into decimal.
        public decimal HoursCalc(decimal hourly)
        {
            int hours = (int)hourly;
            decimal minutes = (hourly - hours) * 100;
            decimal total = 0.0M;
            decimal subTotal = (minutes * 60) / 3600;
            total = (decimal)hours + subTotal;
            return total;
        }

        //Calculating gross wages before taxes are taken out.
        public void CheckWage(decimal hour, decimal firstW, decimal secW, char holBol, int holInt)
        {
            hourly = hour;
            bool holPay = Holiday(holBol);//Checking for holiday pay.
            int holidayHours = 0;
            firstWeek = HoursCalc(firstW);//Getting the decimal to calculate money for first week.
            secWeek = HoursCalc(secW);//Getting the deciaml to calculate money for second week.
            total = CheckHourly(firstWeek, secWeek);
            if (holPay)
            {
                for (int i = 0; i < holInt; i++)
                {
                    holidayHours += 8;
                }
                decimal holidayPayAmount = hourly * holidayHours;
                total += holidayPayAmount;//Adding holiday pay.
            }
        }

        //Checking if the user will have holiday pay.
        public bool Holiday(char holBol2)
        {
            bool holidayPay;
            switch (holBol2)
            {
                case 'y':
                    {
                        holidayPay = true;
                        break;
                    }
                default:
                    {
                        holidayPay = false;
                        break;
                    }
            }
            return holidayPay;
        }

        //Converting minutes into decimal form.
        public decimal CheckHourly(decimal firstW, decimal secW)
        {
            decimal oneWeek = 40;
            decimal twoWeek = 80;
            decimal overHourly = hourly * .5M + hourly;
            decimal overTime = 0;

            if (firstW > oneWeek)
            {
                if (firstW >= twoWeek || firstW >= 65 && secW == 0)
                {
                    overTime = 0;
                    overTime = overTime + (firstW - twoWeek);//Calculating overtime
                    firstW = twoWeek;
                    total = total + hourly * firstW;//Getting the whole gross amount before adding overtime.
                    total = total + (overTime * overHourly);//Adding the overtime to the gross amount.
                }
                else if (firstW > oneWeek)
                {
                    overTime = 0;
                    overTime = overTime + (firstW - oneWeek);//Calculating overtime for first week.
                    firstW = oneWeek;//Setting the first week to 40 normal hours.
                    total = total + hourly * (firstW);//Getting the whole gross amount before adding overtime.
                    total = total + (overTime * overHourly);//Adding the overtime to the gross amount.
                }
            }
            else if (firstW < oneWeek)
            {
                total += hourly * firstW;//Getting the whole gross amount without overtime.
            }
            else if (firstW == oneWeek)
            {
                total += hourly * firstW;//Getting the whole gross amount without overtime.
            }
            if (secW > oneWeek)
            {
                if (secW >= twoWeek || secW >= 65 && firstW == 0)
                {
                    overTime = 0;
                    overTime = overTime + (firstW - twoWeek);//Calculating overtime
                    firstW = twoWeek;
                    total = total + hourly * firstW;//Getting the whole gross amount before adding overtime.
                    total = total + (overTime * overHourly);//Adding the overtime to the gross amount.
                }
                else if (secW > oneWeek)
                {
                    overTime = 0;
                    overTime = overTime + (secW - oneWeek);//Calculating overtime for first week.
                    secW = oneWeek;//Setting the first week to 40 normal hours.
                    total = total + (hourly * secW);//Getting the whole gross amount before adding overtime.
                    total = total + (overTime * overHourly);//Adding the overtime to the gross amount.
                }
            }
            else if (secW < oneWeek)
            {
                total += hourly * secW;//Getting the whole gross amount without overtime.
            }
            else if (secW == oneWeek)
            {
                total += hourly * secW;//Getting the whole gross amount without overtime.
            }
            return total;
        }
        /*
         * PROPERTIES
        */
        public decimal PreTax
        {
            get { return preTax; }
            set { preTax = value; }
        }

        public decimal Total
        {
            get { return total; }
            set { total = value; }
        }

        public decimal PostTax
        {
            get { return postTax; }
            set { postTax = value; }
        }

        public int Allowences
        {
            get { return allowences; }
            set { allowences = value; }
        }

        public int SinMar
        {
            get { return sinMar; }
            set { sinMar = value; }
        }

        /*
         * PROPERTIES
        */
        public decimal CalcPTO(decimal pto, decimal hourly)//Calculating if the user has PTO using what the user makes per hour.
        {
            subtotal = pto * hourly;
            total += subtotal;
            return total;
        }

        //Calculating Medicade and Medicare.
        public decimal CalcMed()
        {
            subtotal = total * fedMed;
            return subtotal;
        }

        //Calculating social security tax.
        public decimal CalcSS()
        {
            subtotal = total * fedSS;
            return subtotal;
        }

        public decimal CalcStateTax(string stateABB)
        { 
            decimal stateWith = 0;
            switch (stateABB)
            {
                case ("CO - Colorado"):
                    Colorado stateCO = new Colorado();
                    stateCO.AllowenceAmount = allowences;
                    stateCO.IncomeAmount = total;
                    stateCO.MaritalStatus = sinMar;
                    stateWith = stateCO.CalculateStateTax();
                    break;

                case ("UT - Utah"):
                    Utah stateUT = new Utah();
                    stateUT.AllowenceAmount = allowences;
                    stateUT.IncomeAmount = total;
                    stateUT.MaritalStatus = sinMar;
                    stateWith = stateUT.CalculateStateTax();
                    break;

                case ("WA - Washington"):
                    stateWith = 0;
                    break;
            }

            return stateWith;
        }
        
        //Calculate federal taxes.

        public decimal CalcAllowFed()
        {
            decimal taxableIncome;
            taxableIncome = fed.CalcAllowFederal(allowences, total);
            return taxableIncome;
        }
        public decimal CalcFedTax(decimal taxIncome)
        {
            decimal fedWith = 0;
            int singleMarried = sinMar;
            fedWith = fed.CalcFederalTax(taxIncome, singleMarried);
            return fedWith;
        }
    }
}
