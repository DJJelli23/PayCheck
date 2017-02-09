using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayCheck
{
    public class StateClass
    {
        private decimal percentageAmount;
        private decimal incomeAmount;
        private int maritalStatus;
        private int allowenceAmount;
        private decimal stateWith;

        public decimal PercentageAmount
        {
            get { return percentageAmount; }
            set { percentageAmount = value; }
        }

        public decimal IncomeAmount
        {
            get { return incomeAmount; }
            set { incomeAmount = value; }
        }

        public int MaritalStatus
        {
            get { return maritalStatus; }
            set { maritalStatus = value; }
        }

        public int AllowenceAmount
        {
            get { return allowenceAmount; }
            set { allowenceAmount = value; }
        }

        public decimal StateWith
        {
            get { return stateWith; }
            set { stateWith = value; }
        }

        public decimal CalculateStateTax()
        {
            return stateWith;
        }
    }

}
