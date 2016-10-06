using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayCheck
{
    public partial class payCheckForm : Form
    {
        CalculateClass calculator = new CalculateClass();
        private decimal subtotal = 0;
        public payCheckForm()
        {
            InitializeComponent();
            ///Holiday selection
            holidayPayLabel.Location = new Point(12, 167);
            holidayGroupBox.Location = new Point(194, 157);
            //PTO information
            ptoLabel.Location = new Point(12, 206);
            ptoGroupBox.Location = new Point(194, 195);
            ptoAmountLabel.Location = new Point(12, 249);
            ptoTextBox.Location = new Point(194, 235);
            //Allowences information
            allowLabel.Location = new Point(394, 117);
            allowTextBox.Location = new Point(585, 115);
            //Filling status UI
            singleMarriedLabel.Location = new Point(394, 159);
            fillingStatusComboBox.Location = new Point(585, 157);
            //State label and combo box
            stateLabel.Location = new Point(394, 203);
            stateComboBox.Location = new Point(585, 201);
            //Garnish amount label and combo box
            garnishmentLabel.Location = new Point(394, 78);
            garnishmentGroupBox.Location = new Point(585, 65);
            //Federal and State tax label
            taxLabel.Location = new Point(394, 406);
        }

        public void Clear()
        {
            calculator.Total = 0;
            calculator.Allowences = 0;
            calculator.PostTax = 0;
            calculator.PreTax = 0;
            calculator.SinMar = 0;
        }

        public void Display(decimal hourly)//Displays the information for the taxes
        {
            decimal savings = 0;
            decimal pto = 0;
            decimal taxes = 0;

            CheckFillingStatus();

            calculator.Allowences = Convert.ToInt16(allowTextBox.Text);
            if (yesPTO.Checked)
            {
                pto = Convert.ToDecimal(ptoTextBox.Text);
                pto = calculator.HoursCalc(pto);
                calculator.CalcPTO(pto, hourly);
            }
            grossLabel.Text += "$" + calculator.Total.ToString("#,###.00");
            if (preTaxAmountRadioButton.Checked && preTaxAmountTextBox.Text != "")
            {
                calculator.PreTax = Convert.ToDecimal(RemoveSpecialCharacters(preTaxAmountTextBox.Text));
                calculator.Total -= calculator.PreTax;
                preTaxLabel.Text = "Pretax Total ";
                preTaxLabel.Visible = true;
                preTaxLabel.Text += "$" + calculator.PreTax.ToString("#,###.00");
            }
            else if (preTaxPercentRadioButton.Checked && preTaxPercentTextBox.Text != "")
            {
                calculator.PreTax = Convert.ToDecimal(RemoveSpecialCharacters(preTaxPercentTextBox.Text)) / 100;
                subtotal = calculator.Total  * calculator.PreTax;
                calculator.Total -= subtotal;
                preTaxLabel.Text = "Pretax Total ";
                preTaxLabel.Visible = true;
                preTaxLabel.Text += "$" + subtotal.ToString("#,###.00");
            }

            if (yesSavingsRadioButton.Checked && percentSavingBox.Text != "")
            {
                string hopePercent = RemoveSpecialCharacters(percentSavingBox.Text);
                savings = Convert.ToDecimal(hopePercent) / 100;
            }
            else if (amountSavingRadioButton.Checked && amountSavingTextBox.Text != "")//Getting the amount from the whole abount text box.
            {
                string hopeAmount = RemoveSpecialCharacters(amountSavingTextBox.Text);
                savings = Convert.ToDecimal(hopeAmount);
            }
            else
            {
                savings = 0;
            }

            taxes += calculator.CalcStateTax(stateComboBox.Text) + calculator.CalcMed() + calculator.CalcSS() + calculator.CalcFedTax(calculator.CalcAllowFed());
            taxLabel.Visible = true;
            calculator.Total -= taxes;
            taxLabel.Text += "$" + taxes.ToString("#,###.00");
            if (garnishPercentAmountRadioButton.Checked && garnishPercentAmountTextBox.Text != "")
            {
                calculator.PostTax = Convert.ToDecimal(RemoveSpecialCharacters(garnishPercentAmountTextBox.Text)) / 100;
                subtotal = calculator.Total * calculator.PostTax;
                calculator.Total += taxes;
                calculator.Total -= subtotal;
                calculator.Total -= taxes;
                garnishLabel.Visible = true;
                garnishLabel.Text += "$" + subtotal.ToString("#,###.00");
            }
            else if (garnishWholeAmountRadioButton.Checked && garnishWholeAmountTextBox.Text != "")
            {
                calculator.PostTax = Convert.ToDecimal(RemoveSpecialCharacters(garnishWholeAmountTextBox.Text));
                calculator.Total += taxes;
                calculator.Total -= calculator.PostTax;
                calculator.Total -= taxes;
                garnishLabel.Visible = true;
                garnishLabel.Text += "$" + calculator.PostTax.ToString("#,###.00");
            }
            //making sure to only use the percent amount.
            if (percentSavingsRadioButton.Checked)
            {
                savingsTotalLabel.Visible = true;
                amountSavingTextBox.Text = "";
                savings = calculator.Total * savings;
                calculator.Total -= savings;
                savingsTotalLabel.Text += "$" + savings.ToString("#,###.00");
            }
            else if (amountSavingRadioButton.Checked)
            {
                savingsTotalLabel.Visible = true;
                percentSavingBox.Text = "";
                calculator.Total -= savings;
                savingsTotalLabel.Text += "$" + savings.ToString("#,###.00");
            }
            CheckPos();
            totalLabel.Visible = true;
            totalLabel.Text += "$" + calculator.Total.ToString("#,###.00");
        }

        public void CheckPos() //Checking for the label locations
        {
            if (garnishYesRadioButton.Checked == false && preTaxYesRadioButton.Checked == false)
            {
                garnishLabel.Visible = false;
                preTaxLabel.Visible = false;
                taxLabel.Location = new Point(394, 406);
                savingsTotalLabel.Location = new Point(394, 426);
            }
            else if (garnishYesRadioButton.Checked == true && preTaxYesRadioButton.Checked == false)
            {
                preTaxLabel.Visible = false;
                taxLabel.Location = new Point(394, 406);
                garnishLabel.Location = new Point(394, 426);
                savingsTotalLabel.Location = new Point(394, 447);
            }
            else if (garnishYesRadioButton.Checked == false && preTaxYesRadioButton.Checked == true)
            {
                garnishLabel.Visible = false;
                taxLabel.Location = new Point(394, 426);
                preTaxLabel.Location = new Point(394, 406);
                savingsTotalLabel.Location = new Point(394, 447);
            }
            else if (garnishYesRadioButton.Checked == true && preTaxYesRadioButton.Checked == true)
            {
                taxLabel.Location = new Point(394, 426);
                garnishLabel.Location = new Point(394, 447);
                savingsTotalLabel.Location = new Point(394, 468);
            }
        }

        public void CheckFillingStatus() //Checking to see input the filling status again if the program does not reset.
        {
            string fillingStat = fillingStatusComboBox.Text;
            switch (fillingStat)
            {
                case ("Single"):
                    calculator.SinMar = 1;
                    break;
                case ("Married Jointly"):
                    calculator.SinMar = 2;
                    break;
                case ("Married Seperately"):
                    calculator.SinMar = 3;
                    break;
                case ("Head of Household"):
                    calculator.SinMar = 4;
                    break;
                default:
                    calculator.SinMar = 1;
                    break;
            }
        }

        private void calcButtonS_Click(object sender, EventArgs e)//calculating button for the total amount.
        {
            string hoursFir;
            string hoursSec;
            decimal hoursS = 0;
            decimal hoursF = 0;
            decimal hoursH = 0;
            string payPerHours;
            char holiday;
            string dayHoliday;
            int dayH = 0;

            grossLabel.Visible = true;
            grossLabel.Text = "Gross amount is ";
            preTaxLabel.Text = "Pretax Total ";
            taxLabel.Text = "State and Federal Taxes ";
            savingsTotalLabel.Text = "Savings Total ";
            totalLabel.Text = "Paycheck is ";

            if (garnishLabel.Visible == true)
            {
                garnishLabel.Text = "Posttax Total ";
            }
            payPerHours = RemoveSpecialCharacters(hoursBox.Text);//Getting the amount per hours.
            hoursFir = RemoveSpecialCharacters(firstHourBox.Text);//Getting the first week of hours.
            hoursSec = RemoveSpecialCharacters(secHourBox.Text);//Getting the second week of hours.
            dayHoliday = RemoveSpecialCharacters(holidayAmountTextBox.Text);
            if (yesHolidayRadioButton.Checked == true) //Finding out if a holiday is going to be paid.
            {
                holiday = 'y';
                if (int.TryParse(dayHoliday, out dayH))
                {
                    dayH = Convert.ToInt16(dayHoliday);
                }
            }
            else
            {
                holiday = 'n';
            }
            //Here is where the option on what weeks are changed to would be a good thing. The current on for 1 week calcualtions.
            if (decimal.TryParse(payPerHours, out hoursH) && decimal.TryParse(hoursFir, out hoursF) && decimal.TryParse(hoursSec, out hoursS))
            {
                hoursH = Convert.ToDecimal(payPerHours);
                hoursF = Convert.ToDecimal(hoursFir);
                hoursS = Convert.ToDecimal(hoursSec);
            }
            else
            {
                if (hoursS >= 65 && hoursFir == "")
                {
                    hoursFir = "0";
                    hoursF = 0;
                }
                else
                {
                    MessageBox.Show("You did not enter enough in First and Second Weeks Hours!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    firstHourBox.Text = "";
                    Clear();
                }
                //-------------------------------------------------------------------------------------------------------------------------------------//
                if (hoursF >= 65 && hoursSec == "")
                {
                    hoursSec = "0";
                    hoursS = 0;
                }
                else
                {
                    MessageBox.Show("You did not enter enough in First and Second Weeks Hours!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    secHourBox.Text = "";
                    Clear();
                }
                //-------------------------------------------------------------------------------------------------------------------------------------//
                /*if (!decimal.TryParse(payPerHours, out hoursH) && !decimal.TryParse(hoursFir, out hoursF) && !decimal.TryParse(hoursSec, out hoursS))
                {
                    MessageBox.Show("You did not enter a number some or all of the following: Pay Per Hours, First Week Hours, or Second Week Hours.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    hoursBox.Text = "Enter Here";
                    firstHourBox.Text = "Enter Here";
                    secHourBox.Text = "Enter Here";
                    Clear();
                }*/
            }
            //----------------------------------------------------------------------------------------------------------------------------------------//
            if (decimal.TryParse(hoursFir, out hoursF))
            {
                hoursF = Convert.ToDecimal(hoursFir);
            }
            else
            {
                if (hoursS >= 65 && hoursFir == "")
                {
                    hoursF = 0;
                }
                else
                {
                    MessageBox.Show("You did not enter a number in First Weeks Hours!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    firstHourBox.Text = "";
                    Clear();
                }
            }
            if (decimal.TryParse(hoursSec, out hoursS))//Check to make sure the user entered a number for second week.
            {
                hoursS = Convert.ToDecimal(hoursSec);
            }
            else
            {
                if (hoursF >= 65 && hoursSec == "")
                {
                    hoursS = 0;
                }
                else
                {
                    MessageBox.Show("You did not enter a number in Second Weeks Hours!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    secHourBox.Text = "";
                    Clear();
                }
            }
            string allow = allowTextBox.Text;
            int allowTest;
            if (!int.TryParse(allow, out allowTest))//Check to make sure the user entered a number.
            {
                MessageBox.Show("You did not enter a number in Allowences.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                allowTextBox.Text = "";
                Clear();
            }
            else
            {
                calculator.CheckWage(hoursH, hoursF, hoursS, holiday, dayH);//Passing the input from the customer to calculate the paycheck.
                Display(hoursH);//Display and calculate the information.
                Clear();//Clear the numbers in case the user decides to change before pressing the clear button.
            }
        }

        private void CheckEnter(object sender, System.Windows.Forms.KeyPressEventArgs e)//Makes it so that when the enter button is clicked on any text tool the calculation will attempt to run.
        {
            if (e.KeyChar == (char)13)
            {
                string hoursFir;
                string hoursSec;
                decimal hoursS = 0;
                decimal hoursF = 0;
                decimal hoursH = 0;
                string payPerHours;
                char holiday;
                string dayHoliday;
                int dayH = 0;

                grossLabel.Visible = true;
                grossLabel.Text = "Gross amount is ";
                preTaxLabel.Text = "Pretax Total ";
                taxLabel.Text = "State and Federal Taxes ";
                savingsTotalLabel.Text = "Savings Total ";
                totalLabel.Text = "Paycheck is ";

                if (garnishLabel.Visible == true)
                {
                    garnishLabel.Text = "Posttax Total ";
                }
                payPerHours = RemoveSpecialCharacters(hoursBox.Text);//Getting the amount per hours.
                hoursFir = RemoveSpecialCharacters(firstHourBox.Text);//Getting the first week of hours.
                hoursSec = RemoveSpecialCharacters(secHourBox.Text);//Getting the second week of hours.
                dayHoliday = RemoveSpecialCharacters(holidayAmountTextBox.Text);
                if (yesHolidayRadioButton.Checked == true) //Finding out if a holiday is going to be paid.
                {
                    holiday = 'y';
                    if (int.TryParse(dayHoliday, out dayH))
                    {
                        dayH = Convert.ToInt16(dayHoliday);
                    }
                }
                else
                {
                    holiday = 'n';
                }
                //Here is where the option on what weeks are changed to would be a good thing. The current on for 1 week calcualtions.
                if (decimal.TryParse(payPerHours, out hoursH) && decimal.TryParse(hoursFir, out hoursF) && decimal.TryParse(hoursSec, out hoursS))
                {
                    hoursH = Convert.ToDecimal(payPerHours);
                    hoursF = Convert.ToDecimal(hoursFir);
                    hoursS = Convert.ToDecimal(hoursSec);
                }
                else
                {
                    if (hoursS >= 65 && hoursFir == "")
                    {
                        hoursFir = "0";
                        hoursF = 0;
                    }
                    else
                    {
                        MessageBox.Show("You did not enter enough in First and Second Weeks Hours!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        firstHourBox.Text = "";
                        Clear();
                    }
                    if (hoursF >= 65 && hoursSec == "")
                    {
                        hoursFir = "0";
                        hoursS = 0;
                    }
                    else
                    {
                        MessageBox.Show("You did not enter enough in First and Second Weeks Hours!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        secHourBox.Text = "";
                        Clear();
                    }
                    /*if (!decimal.TryParse(payPerHours, out hoursH) && !decimal.TryParse(hoursFir, out hoursF) && !decimal.TryParse(hoursSec, out hoursS))
                    {
                        MessageBox.Show("You did not enter a number some or all of the following: Pay Per Hours, First Week Hours, or Second Week Hours.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        hoursBox.Text = "Enter Here";
                        firstHourBox.Text = "Enter Here";
                        secHourBox.Text = "Enter Here";
                        Clear();
                    }*/
                }
                if (decimal.TryParse(hoursFir, out hoursF))
                {
                    hoursF = Convert.ToDecimal(hoursFir);
                }
                else
                {
                    if (hoursS >= 65 && hoursFir == "")
                    {
                        hoursF = 0;
                    }
                    else
                    {
                        MessageBox.Show("You did not enter a number in First Weeks Hours!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        firstHourBox.Text = "";
                        Clear();
                    }
                }
                if (decimal.TryParse(hoursSec, out hoursS))//Check to make sure the user entered a number for second week.
                {
                    hoursS = Convert.ToDecimal(hoursSec);
                }
                else
                {
                    if (hoursF >= 65 && hoursSec == "")
                    {
                        hoursS = 0;
                    }
                    else
                    {
                        MessageBox.Show("You did not enter a number in Second Weeks Hours!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        secHourBox.Text = "";
                        Clear();
                    }
                }
                string allow = allowTextBox.Text;
                int allowTest;
                if (!int.TryParse(allow, out allowTest))//Check to make sure the user entered a number.
                {
                    MessageBox.Show("You did not enter a number in Allowences!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    allowTextBox.Text = "";
                    Clear();
                }
                else
                {
                    calculator.CheckWage(hoursH, hoursF, hoursS, holiday, dayH);//Passing the input from the customer to calculate the paycheck.
                    Display(hoursH);//Display and calculate the information.
                    Clear();//Clear the numbers in case the user decides to change before pressing the clear button.
                }
            }
        }

        public static string RemoveSpecialCharacters(string str)//Remove any character that is not acceptable for calculation.
        {
            return Regex.Replace(str, "[^a-zA-Z0-9_.]+", "", RegexOptions.Compiled);
        }

        private void yesSavingsRadioButton_CheckedChanged(object sender, EventArgs e)//Checking to see if the user wants to save money.
        {
            if (yesSavingsRadioButton.Checked == true)
            {
                amountPercentSavingsLabel.Visible = true;
                amountComboBox.Visible = true;
                amountPercentSavingsLabel.Location = new Point(12, 170);
                amountComboBox.Location = new Point(194, 161);
                //Holiday selection information
                holidayPayLabel.Location = new Point(12, 213);
                holidayGroupBox.Location = new Point(194, 202);
                if (yesHolidayRadioButton.Checked == true)
                {
                    holidayAmountLabel.Location = new Point(12, 256);
                    holidayAmountTextBox.Location = new Point(194, 251);
                    ptoLabel.Location = new Point(12, 291);
                    ptoGroupBox.Location = new Point(194, 280);
                    ptoAmountLabel.Location = new Point(12, 327);
                    ptoTextBox.Location = new Point(194, 322);
                }
                else if (noHolidayRadioButton.Checked == true || yesHolidayRadioButton.Checked == false)
                {
                    ptoLabel.Location = new Point(12, 256);
                    ptoGroupBox.Location = new Point(194, 240);
                    ptoAmountLabel.Location = new Point(12, 291);
                    ptoTextBox.Location = new Point(194, 289);
                }
            }
        }

        private void noSavingsRadioButton_CheckedChanged(object sender, EventArgs e)//Making sure all the savings objects are not visable in case the user changes thier mind.
        {
            if (noSavingsRadioButton.Checked == true)
            {
                howMuchSavingLabel.Visible = false;
                amountPercentSavingsLabel.Visible = false;
                amountComboBox.Visible = false;
                amountSavingTextBox.Visible = false;
                amountSavingTextBox.Text = "";
                //Clearing out the boxes to not mess with the total.
                percentSavingBox.Visible = false;
                percentSavingsRadioButton.Checked = false;
                amountSavingRadioButton.Checked = false;
                //Clearing out the boxes to not mess with the total.
                holidayPayLabel.Location = new Point(12, 167);
                holidayGroupBox.Location = new Point(194, 157);
                if (yesHolidayRadioButton.Checked == true)
                {
                    holidayAmountLabel.Location = new Point(12, 213);
                    holidayAmountTextBox.Location = new Point(194, 209);
                    ptoLabel.Location = new Point(12, 256);
                    ptoGroupBox.Location = new Point(194, 240);
                    ptoAmountLabel.Location = new Point(12, 291);
                    ptoTextBox.Location = new Point(194, 289);
                }
                else if (noHolidayRadioButton.Checked == true || yesHolidayRadioButton.Checked == false)
                {
                    ptoLabel.Location = new Point(12, 206);
                    ptoGroupBox.Location = new Point(194, 195);
                    ptoAmountLabel.Location = new Point(12, 249);
                    ptoTextBox.Location = new Point(194, 235);
                }
            }
        }

        private void percentRadioButton_CheckedChanged(object sender, EventArgs e)//The user wants to save with a percent.
        {
            if (percentSavingsRadioButton.Checked == true)
            {
                howMuchSavingLabel.Visible = true;
                percentSavingBox.Visible = true;
                amountSavingTextBox.Visible = false;//Clearing the other choice in case the user changes their mind.
                amountSavingTextBox.Text = "";//Clearing the amount in the whole amount text box so the calculation is correct.
                holidayPayLabel.Location = new Point(12, 256);//Changing the location of the holiday label.
                holidayGroupBox.Location = new Point(194, 240);//Changing the location of the holiday group box.
                if (yesHolidayRadioButton.Checked == true)
                {
                    holidayAmountLabel.Location = new Point(12, 291);
                    holidayAmountTextBox.Location = new Point(194, 289);
                    ptoLabel.Location = new Point(12, 327);
                    ptoGroupBox.Location = new Point(194, 313);
                    ptoAmountLabel.Location = new Point(12, 366);
                    ptoTextBox.Location = new Point(194, 361);
                }
                else if (noHolidayRadioButton.Checked == true || yesHolidayRadioButton.Checked == false)
                {
                    ptoLabel.Location = new Point(12, 291);
                    ptoGroupBox.Location = new Point(194, 280);
                    ptoAmountLabel.Location = new Point(12, 327);
                    ptoTextBox.Location = new Point(194, 322);
                }
            }
        }

        private void amountRadioButton_CheckedChanged(object sender, EventArgs e)//The user wants to save with a set amount.
        {
            if (amountSavingRadioButton.Checked == true)
            {
                howMuchSavingLabel.Visible = true;
                percentSavingBox.Visible = false;
                percentSavingBox.Text = "";//Clearing the amount in the percent area so the calculation is correct.
                amountSavingTextBox.Location = new Point(194, 209);
                amountSavingTextBox.Visible = true;
                holidayPayLabel.Location = new Point(12, 256);//Changing the location of the holiday label.
                holidayGroupBox.Location = new Point(194, 240);//Changing the location of the holiday group box.
                if (yesHolidayRadioButton.Checked == true)
                {
                    holidayAmountLabel.Location = new Point(12, 291);
                    holidayAmountTextBox.Location = new Point(194, 289);
                    ptoLabel.Location = new Point(12, 327);
                    ptoGroupBox.Location = new Point(194, 313);
                    ptoAmountLabel.Location = new Point(12, 366);
                    ptoTextBox.Location = new Point(194, 361);
                }
                else if (noHolidayRadioButton.Checked == true || yesHolidayRadioButton.Checked == false)
                {
                    ptoLabel.Location = new Point(12, 291);
                    ptoGroupBox.Location = new Point(194, 280);
                    ptoAmountLabel.Location = new Point(12, 327);
                    ptoTextBox.Location = new Point(194, 322);
                }
            }
        }

        private void yesHolidayRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (yesHolidayRadioButton.Checked == true)
            {
                holidayAmountLabel.Visible = true;
                holidayAmountTextBox.Visible = true;
                if (yesSavingsRadioButton.Checked == false || noSavingsRadioButton.Checked == true)
                {
                    holidayPayLabel.Location = new Point(12, 167);
                    holidayGroupBox.Location = new Point(194, 157);
                    holidayAmountLabel.Location = new Point(12, 213);
                    holidayAmountTextBox.Location = new Point(194, 209);
                    ptoLabel.Location = new Point(12, 256);
                    ptoGroupBox.Location = new Point(194, 240);
                    ptoAmountLabel.Location = new Point(12, 291);
                    ptoTextBox.Location = new Point(194, 289);
                }
                else if (yesSavingsRadioButton.Checked == true && percentSavingsRadioButton.Checked == false && amountSavingRadioButton.Checked == false)
                {
                    holidayPayLabel.Location = new Point(12, 213);
                    holidayGroupBox.Location = new Point(194, 202);
                    holidayAmountLabel.Location = new Point(12, 256);
                    holidayAmountTextBox.Location = new Point(194, 251);
                    ptoLabel.Location = new Point(12, 291);
                    ptoGroupBox.Location = new Point(194, 280);
                    ptoAmountLabel.Location = new Point(12, 327);
                    ptoTextBox.Location = new Point(194, 322);
                }
                else if (yesSavingsRadioButton.Checked == true && percentSavingsRadioButton.Checked == true || yesSavingsRadioButton.Checked == true && amountSavingRadioButton.Checked == true)
                {
                    holidayPayLabel.Location = new Point(12, 256);//Changing the location of the holiday label.
                    holidayGroupBox.Location = new Point(194, 240);//Changing the location of the holiday group box.
                    holidayAmountLabel.Location = new Point(12, 291);
                    holidayAmountTextBox.Location = new Point(194, 289);
                    ptoLabel.Location = new Point(12, 327);
                    ptoGroupBox.Location = new Point(194, 313);
                    ptoAmountLabel.Location = new Point(12, 366);
                    ptoTextBox.Location = new Point(194, 361);
                }
            }
        }

        private void noHolidayRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (noHolidayRadioButton.Checked == true)
            {
                holidayAmountLabel.Visible = false;
                holidayAmountTextBox.Visible = false;
                holidayAmountTextBox.Text = "";
                if (yesSavingsRadioButton.Checked == false || noSavingsRadioButton.Checked == true)
                {
                    holidayPayLabel.Location = new Point(12, 167);
                    holidayGroupBox.Location = new Point(194, 157);
                    ptoLabel.Location = new Point(12, 206);
                    ptoGroupBox.Location = new Point(194, 195);
                    ptoAmountLabel.Location = new Point(12, 249);
                    ptoTextBox.Location = new Point(194, 244);
                }
                else if (yesSavingsRadioButton.Checked == true && percentSavingsRadioButton.Checked == false && amountSavingRadioButton.Checked == false)
                {
                    holidayPayLabel.Location = new Point(12, 213);
                    holidayGroupBox.Location = new Point(194, 202);
                    ptoLabel.Location = new Point(12, 256);
                    ptoGroupBox.Location = new Point(194, 240);
                    ptoAmountLabel.Location = new Point(12, 291);
                    ptoTextBox.Location = new Point(194, 289);
                }
                else if (yesSavingsRadioButton.Checked == true && percentSavingsRadioButton.Checked == true || yesSavingsRadioButton.Checked == true && amountSavingRadioButton.Checked == true)
                {
                    holidayPayLabel.Location = new Point(12, 256);//Changing the location of the holiday label.
                    holidayGroupBox.Location = new Point(194, 240);//Changing the location of the holiday group box.
                    ptoLabel.Location = new Point(12, 291);
                    ptoGroupBox.Location = new Point(194, 280);
                    ptoAmountLabel.Location = new Point(12, 327);
                    ptoTextBox.Location = new Point(194, 322);
                }
            }
        }

        //Clearing the program to be used again.************************************************
        private void clearButton_Click(object sender, EventArgs e)
        {
                //Clearing out the hours tools.
            hoursBox.Text = "";
            firstHourBox.Text = "";
            secHourBox.Text = "";
                //Clearing out the Allowance tools.
            allowTextBox.Text = "";
                //Clearing out the Filling tools.
            fillingStatusComboBox.Text = "";
                //Clearing out the State tools.
            stateComboBox.Text = "";
                //Clearing out the Holiday tools.
            noHolidayRadioButton.Checked = false;
            yesHolidayRadioButton.Checked = false;
            holidayAmountLabel.Visible = false;
            holidayAmountTextBox.Text = "";
            holidayAmountTextBox.Visible = false;
                //Clearing out the Savings tools
            yesSavingsRadioButton.Checked = false;
            noSavingsRadioButton.Checked = false;
            percentSavingsRadioButton.Checked = false;
            amountSavingRadioButton.Checked = false;
                            //
            savingsTotalLabel.Visible = false;
            amountPercentSavingsLabel.Visible = false;
            amountComboBox.Visible = false;
            amountSavingTextBox.Visible = false;
            howMuchSavingLabel.Visible = false;
            percentSavingBox.Visible = false;
                            //
            percentSavingBox.Text = "";
            amountSavingTextBox.Text = "";
                //Clearing the PTO tools
            yesPTO.Checked = false;
            noPTO.Checked = false;
            ptoTextBox.Visible = false;
            ptoAmountLabel.Visible = false;
            ptoTextBox.Text = "";
                //Clearing the tools for Posttax
            garnishNoRadioButton.Checked = false;
            garnishYesRadioButton.Checked = false;
            garnishAmountLabel.Visible = false;
            garnishWholeAmountRadioButton.Checked = false;
            garnishPercentAmountRadioButton.Checked = false;
                            //
            garnishAmountGroupBox.Visible = false;
            garnishLabel.Visible = false;
            garnishPercentAmountLabel.Visible = false;
            garnishPercentAmountTextBox.Visible = false;
            garnishWholeAmountTextBox.Visible = false;
                            //
            garnishWholeAmountTextBox.Text = "";
            garnishPercentAmountTextBox.Text = "";
                //Clearing the tools for Pretax
            preTaxYesRadioButton.Checked = false;
            preTaxNoRadioButton.Checked = false;
            preTaxPercentRadioButton.Checked = false;
            preTaxAmountRadioButton.Checked = false;
                            //
            preTaxPerAmountLabel.Visible = false;
            preTaxHowMuchLabel.Visible = false;
            preTaxPerAmountGroupBox.Visible = false;
            preTaxLabel.Visible = false;
                            //
            preTaxPercentTextBox.Text = "";
            preTaxAmountTextBox.Text = "";
                //Clearing out the Total tools
            totalLabel.Visible = false;
                //Defaulting back the labels.
            grossLabel.Visible = false;
            preTaxLabel.Visible = false;
            taxLabel.Visible = false;
            savingsTotalLabel.Visible = false;
            totalLabel.Visible = false;
                            //
            grossLabel.Text = "Gross amount is ";
            preTaxLabel.Text = "Pretax Total ";
            taxLabel.Text = "State and Federal Taxes ";
            savingsTotalLabel.Text = "Savings Total ";
            totalLabel.Text = "Paycheck is ";
                //Moving the savings tools to where they started.
            savingsTotalLabel.Location = new Point(386, 103);
                //Moving the holiday tools to where they started.
            holidayPayLabel.Location = new Point(12, 167);
            holidayGroupBox.Location = new Point(194, 157);
                //Moving the pto tools to where they started.
            ptoLabel.Location = new Point(12, 206);
            ptoGroupBox.Location = new Point(194, 195);
            ptoAmountLabel.Location = new Point(12, 249);
            ptoTextBox.Location = new Point(194, 235);
                //Moving the state tools to where they started.
            stateLabel.Location = new Point(386, 278);
            stateComboBox.Location = new Point(568, 278);
                //Garnish amount label and combo box
            garnishmentLabel.Location = new Point(394, 78);
            garnishmentGroupBox.Location = new Point(585, 65);
                //Allowences information
            allowLabel.Location = new Point(394, 117);
            allowTextBox.Location = new Point(585, 115);
                //Filling status UI
            singleMarriedLabel.Location = new Point(394, 159);
            fillingStatusComboBox.Location = new Point(585, 157);
                //State label and combo box
            stateLabel.Location = new Point(394, 203);
            stateComboBox.Location = new Point(585, 201);
                //Defaulting the Calculator class properties.
            calculator.Allowences = 0;
            calculator.PreTax = 0;
            calculator.PostTax = 0;
            calculator.SinMar = 0;
            calculator.Total = 0;
        }

        private void fillingStatusComboBox_SelectedIndexChanged(object sender, EventArgs e)//getting the filling status from the combo box.
        {
            string fillingStat = fillingStatusComboBox.Text;
            switch (fillingStat)
            {
                case ("Single"):
                    calculator.SinMar = 1;
                    break;
                case ("Married Jointly"):
                    calculator.SinMar = 2;
                    break;
                case ("Married Seperately"):
                    calculator.SinMar = 3;
                    break;
                case ("Head of Household"):
                    calculator.SinMar = 4;
                    break;
                default:
                    calculator.SinMar = 1;
                    break;
            }
        }

        private void yesPTO_CheckedChanged(object sender, EventArgs e)//when checked it will make the rest of the PTO tools available.
        {
            if (yesPTO.Checked == true)
            {
                ptoAmountLabel.Visible = true;
                ptoTextBox.Visible = true;
                ptoTextBox.Location = new Point(194, 244);
            }
        }

        private void noPTO_CheckedChanged(object sender, EventArgs e)//When checked it clears the pto tools
        {
            if (noPTO.Checked == true)
            {
                ptoTextBox.Visible = false;
                ptoAmountLabel.Visible = false;
                ptoTextBox.Text = "";
            }
        }

        private void preTaxYesRadioButton_CheckedChanged(object sender, EventArgs e)//When checked it will make some PreTax tools available.
        {
            if (preTaxYesRadioButton.Checked == true)
            {
                preTaxPerAmountLabel.Visible = true;
                preTaxPerAmountGroupBox.Visible = true;
                if (garnishYesRadioButton.Checked == false && preTaxYesRadioButton.Checked == true || garnishNoRadioButton.Checked == true && preTaxNoRadioButton.Checked == false)
                {
                    garnishmentLabel.Location = new Point(394, 117);//Taken After Taxes
                    garnishmentGroupBox.Location = new Point(585, 104);//Yes and No radio buttons
                    allowLabel.Location = new Point(394, 159);//Allowence Lable
                    allowTextBox.Location = new Point(585, 157);//Allowence Text Box
                    singleMarriedLabel.Location = new Point(394, 203);//Single or Married?
                    fillingStatusComboBox.Location = new Point(585, 201);//Filling Status
                    stateLabel.Location = new Point(394, 242);//State?
                    stateComboBox.Location = new Point(585, 240);//State Combo Box
                }
                else if (garnishYesRadioButton.Checked == true && garnishPercentAmountRadioButton.Checked == false && garnishWholeAmountRadioButton.Checked == false && garnishNoRadioButton.Checked == false)
                {
                    garnishmentLabel.Location = new Point(394, 117);//Taken After Taxes
                    garnishmentGroupBox.Location = new Point(585, 104);//Yes and No radio buttons
                    garnishAmountLabel.Location = new Point(394, 159);//Percent or Amount
                    garnishAmountGroupBox.Location = new Point(585, 146);//Radio buttons Percent or Amount
                    allowLabel.Location = new Point(394, 203);//Allowence Lable
                    allowTextBox.Location = new Point(585, 201);//Allowence Text Box
                    singleMarriedLabel.Location = new Point(394, 242);//Single or Married?
                    fillingStatusComboBox.Location = new Point(585, 240);//Filling Status
                    stateLabel.Location = new Point(394, 279);//State?
                    stateComboBox.Location = new Point(585, 277);//State Combo Box
                }
                else if (garnishYesRadioButton.Checked == true && garnishPercentAmountRadioButton.Checked == true && garnishNoRadioButton.Checked == false || garnishYesRadioButton.Checked == true && garnishWholeAmountRadioButton.Checked == false && garnishNoRadioButton.Checked == false)
                {
                    garnishmentLabel.Location = new Point(394, 117);//Taken After Taxes
                    garnishmentGroupBox.Location = new Point(585, 104);//Yes and No radio buttons
                    garnishAmountLabel.Location = new Point(394, 159);//Percent or Amount
                    garnishAmountGroupBox.Location = new Point(585, 146);//Radio buttons Percent or Amount
                    garnishPercentAmountLabel.Location = new Point(394, 203);//How Much?
                    if (garnishPercentAmountRadioButton.Checked == true)
                    {
                        garnishPercentAmountTextBox.Location = new Point(585, 201);//Percent Text box
                        allowLabel.Location = new Point(394, 242);//Allowence Lable
                        allowTextBox.Location = new Point(585, 240);//Allowence Text Box
                        singleMarriedLabel.Location = new Point(394, 279);//Single or Married?
                        fillingStatusComboBox.Location = new Point(585, 277);//Filling Status
                        stateLabel.Location = new Point(394, 315);//State?
                        stateComboBox.Location = new Point(585, 313);//State Combo Box
                    }
                    else if (garnishWholeAmountRadioButton.Checked == true)
                    {
                        garnishWholeAmountTextBox.Location = new Point(585, 201);//Whole amount Text box
                        allowLabel.Location = new Point(394, 242);//Allowence Lable
                        allowTextBox.Location = new Point(585, 240);//Allowence Text Box
                        singleMarriedLabel.Location = new Point(394, 279);//Single or Married?
                        fillingStatusComboBox.Location = new Point(585, 277);//Filling Status
                        stateLabel.Location = new Point(394, 315);//State?
                        stateComboBox.Location = new Point(585, 313);//State Combo Box
                    }
                }
            }
        }

        private void preTaxNoRadioButton_CheckedChanged(object sender, EventArgs e)//When checked it will take the PreTax tools away and clear the information.
        {
            if (preTaxNoRadioButton.Checked == true)
            {
                preTaxAmountRadioButton.Checked = false;
                preTaxPercentRadioButton.Checked = false;
                preTaxPerAmountGroupBox.Visible = false;
                preTaxPerAmountLabel.Visible = false;
                preTaxHowMuchLabel.Visible = false;
                preTaxPercentTextBox.Visible = false;
                preTaxAmountTextBox.Visible = false;
                preTaxPercentTextBox.Text = "";
                preTaxAmountTextBox.Text = "";
                //Garnish amount label and combo box
                if (garnishYesRadioButton.Checked == false && preTaxYesRadioButton.Checked == false || garnishNoRadioButton.Checked == true && preTaxNoRadioButton.Checked == true)
                {
                    garnishmentLabel.Location = new Point(394, 78);//Taken After Taxes
                    garnishmentGroupBox.Location = new Point(585, 65);//Yes and No radio buttons
                    allowLabel.Location = new Point(394, 117);//Allowence Lable
                    allowTextBox.Location = new Point(585, 115);//Allowence Text Box
                    singleMarriedLabel.Location = new Point(394, 159);//Single or Married?
                    fillingStatusComboBox.Location = new Point(585, 157);//Filling Status
                    stateLabel.Location = new Point(394, 203);//State?
                    stateComboBox.Location = new Point(585, 201);//State Combo Box
                }
                else if (garnishYesRadioButton.Checked == true && garnishPercentAmountRadioButton.Checked == false && garnishWholeAmountRadioButton.Checked == false && garnishNoRadioButton.Checked == false)
                {
                    garnishmentLabel.Location = new Point(394, 78);//Taken After Taxes
                    garnishmentGroupBox.Location = new Point(585, 65);//Yes and No radio buttons
                    garnishAmountLabel.Location = new Point(394, 117);//Percent or Amount
                    garnishAmountGroupBox.Location = new Point(585, 104);//Radio buttons Percent or Amount
                    allowLabel.Location = new Point(394, 159);//Allowence Lable
                    allowTextBox.Location = new Point(585, 157);//Allowence Text Box
                    singleMarriedLabel.Location = new Point(394, 203);//Single or Married?
                    fillingStatusComboBox.Location = new Point(585, 201);//Filling Status
                    stateLabel.Location = new Point(394, 242);//State?
                    stateComboBox.Location = new Point(585, 240);//State Combo Box
                }
                else if (garnishYesRadioButton.Checked == true && garnishPercentAmountRadioButton.Checked == true && garnishNoRadioButton.Checked == false || garnishYesRadioButton.Checked == true && garnishWholeAmountRadioButton.Checked == false && garnishNoRadioButton.Checked == false)
                {
                    garnishmentLabel.Location = new Point(394, 78);//Taken After Taxes
                    garnishmentGroupBox.Location = new Point(585, 65);//Yes and No radio buttons
                    garnishAmountLabel.Location = new Point(394, 117);//Percent or Amount
                    garnishAmountGroupBox.Location = new Point(585, 104);//Radio buttons Percent or Amount
                    garnishPercentAmountLabel.Location = new Point(394, 159);//How Much?
                    if (garnishPercentAmountRadioButton.Checked == true)
                    {
                        garnishPercentAmountTextBox.Location = new Point(585, 157);//Percent Text box
                        allowLabel.Location = new Point(394, 203);//Allowence Lable
                        allowTextBox.Location = new Point(585, 201);//Allowence Text Box
                        singleMarriedLabel.Location = new Point(394, 242);//Single or Married?
                        fillingStatusComboBox.Location = new Point(585, 240);//Filling Status
                        stateLabel.Location = new Point(394, 279);//State?
                        stateComboBox.Location = new Point(585, 277);//State Combo Box
                    }
                    else if (garnishWholeAmountRadioButton.Checked == true)
                    {
                        garnishWholeAmountTextBox.Location = new Point(585, 157);//Whole amount Text box
                        allowLabel.Location = new Point(394, 203);//Allowence Lable
                        allowTextBox.Location = new Point(585, 201);//Allowence Text Box
                        singleMarriedLabel.Location = new Point(394, 242);//Single or Married?
                        fillingStatusComboBox.Location = new Point(585, 240);//Filling Status
                        stateLabel.Location = new Point(394, 279);//State?
                        stateComboBox.Location = new Point(585, 277);//State Combo Box
                    }
                }
            }
        }

        private void preTaxPercentRadioButton_CheckedChanged(object sender, EventArgs e)//When checked it will make the PreTax percentage tools available and take the amount information away.
        {
            if (preTaxPercentRadioButton.Checked == true)
            {
                garnishAmountLabel.Location = new Point(394, 159);
                garnishmentGroupBox.Location = new Point(585, 149);
                preTaxAmountTextBox.Visible = false;
                preTaxHowMuchLabel.Visible = true;
                preTaxPercentTextBox.Visible = true;
                preTaxAmountTextBox.Text = "";
                if (garnishYesRadioButton.Checked == false)
                {
                    garnishmentLabel.Location = new Point(394, 159);//Taken After Taxes
                    garnishmentGroupBox.Location = new Point(585, 146);//Yes and No radio buttons
                    allowLabel.Location = new Point(394, 203);//Allowence Lable
                    allowTextBox.Location = new Point(585, 201);//Allowence Text Box
                    singleMarriedLabel.Location = new Point(394, 242);//Single or Married?
                    fillingStatusComboBox.Location = new Point(585, 240);//Filling Status
                    stateLabel.Location = new Point(394, 279);//State?
                    stateComboBox.Location = new Point(585, 277);//State Combo Box
                }
                else if (garnishYesRadioButton.Checked == true && garnishPercentAmountRadioButton.Checked == false && garnishWholeAmountRadioButton.Checked == false)
                {
                    garnishmentLabel.Location = new Point(394, 159);//Taken After Taxes
                    garnishmentGroupBox.Location = new Point(585, 146);//Yes and No radio buttons
                    garnishAmountLabel.Location = new Point(394, 203);//Percent or Amount
                    garnishAmountGroupBox.Location = new Point(585, 190);//Radio buttons Percent or Amount
                    allowLabel.Location = new Point(394, 242);//Allowence Lable
                    allowTextBox.Location = new Point(585, 240);//Allowence Text Box
                    singleMarriedLabel.Location = new Point(394, 279);//Single or Married?
                    fillingStatusComboBox.Location = new Point(585, 277);//Filling Status
                    stateLabel.Location = new Point(394, 315);//State?
                    stateComboBox.Location = new Point(585, 313);//State Combo Box
                }
                else if (garnishYesRadioButton.Checked == true && garnishPercentAmountRadioButton.Checked == true || garnishYesRadioButton.Checked == true && garnishWholeAmountRadioButton.Checked == false)
                {
                    garnishmentLabel.Location = new Point(394, 159);//Taken After Taxes
                    garnishmentGroupBox.Location = new Point(585, 146);//Yes and No radio buttons
                    garnishAmountLabel.Location = new Point(394, 203);//Percent or Amount
                    garnishAmountGroupBox.Location = new Point(585, 190);//Radio buttons Percent or Amount
                    garnishPercentAmountLabel.Location = new Point(394, 242);//How Much?
                    if (garnishPercentAmountRadioButton.Checked == true)
                    {
                        garnishPercentAmountTextBox.Location = new Point(585, 240);//Percent Text box
                        allowLabel.Location = new Point(394, 279);//Allowence Lable
                        allowTextBox.Location = new Point(585, 277);//Allowence Text Box
                        singleMarriedLabel.Location = new Point(394, 315);//Single or Married?
                        fillingStatusComboBox.Location = new Point(585, 313);//Filling Status
                        stateLabel.Location = new Point(394, 346);//State?
                        stateComboBox.Location = new Point(585, 344);//State Combo Box
                    }
                    else if (garnishWholeAmountRadioButton.Checked == true)
                    {
                        garnishWholeAmountTextBox.Location = new Point(585, 240);//Whole amount Text box
                        allowLabel.Location = new Point(394, 279);//Allowence Lable
                        allowTextBox.Location = new Point(585, 277);//Allowence Text Box
                        singleMarriedLabel.Location = new Point(394, 315);//Single or Married?
                        fillingStatusComboBox.Location = new Point(585, 313);//Filling Status
                        stateLabel.Location = new Point(394, 346);//State?
                        stateComboBox.Location = new Point(585, 344);//State Combo Box
                    }
                }
            }
        }

        private void preTaxAmountRadioButton_CheckedChanged(object sender, EventArgs e)//When checked it will make the amount tools available and clear the percentage information.
        {
            if (preTaxAmountRadioButton.Checked == true)
            {
                preTaxAmountTextBox.Location = new Point(585, 115);
                preTaxPercentTextBox.Visible = false;
                preTaxHowMuchLabel.Visible = true;
                preTaxAmountTextBox.Visible = true;
                preTaxPercentTextBox.Text = "";
                if (garnishYesRadioButton.Checked == false)
                {
                    garnishmentLabel.Location = new Point(394, 159);//Taken After Taxes
                    garnishmentGroupBox.Location = new Point(585, 146);//Yes and No radio buttons
                    allowLabel.Location = new Point(394, 203);//Allowence Lable
                    allowTextBox.Location = new Point(585, 201);//Allowence Text Box
                    singleMarriedLabel.Location = new Point(394, 242);//Single or Married?
                    fillingStatusComboBox.Location = new Point(585, 240);//Filling Status
                    stateLabel.Location = new Point(394, 279);//State?
                    stateComboBox.Location = new Point(585, 277);//State Combo Box
                }
                else if (garnishYesRadioButton.Checked == true && garnishPercentAmountRadioButton.Checked == false && garnishWholeAmountRadioButton.Checked == false)
                {
                    garnishmentLabel.Location = new Point(394, 159);//Taken After Taxes
                    garnishmentGroupBox.Location = new Point(585, 146);//Yes and No radio buttons
                    garnishAmountLabel.Location = new Point(394, 203);//Percent or Amount
                    garnishAmountGroupBox.Location = new Point(585, 190);//Radio buttons Percent or Amount
                    allowLabel.Location = new Point(394, 242);//Allowence Lable
                    allowTextBox.Location = new Point(585, 240);//Allowence Text Box
                    singleMarriedLabel.Location = new Point(394, 279);//Single or Married?
                    fillingStatusComboBox.Location = new Point(585, 277);//Filling Status
                    stateLabel.Location = new Point(394, 315);//State?
                    stateComboBox.Location = new Point(585, 313);//State Combo Box
                }
                else if (garnishYesRadioButton.Checked == true && garnishPercentAmountRadioButton.Checked == true || garnishYesRadioButton.Checked == true && garnishWholeAmountRadioButton.Checked == false)
                {
                    garnishmentLabel.Location = new Point(394, 159);//Taken After Taxes
                    garnishmentGroupBox.Location = new Point(585, 146);//Yes and No radio buttons
                    garnishAmountLabel.Location = new Point(394, 203);//Percent or Amount
                    garnishAmountGroupBox.Location = new Point(585, 190);//Radio buttons Percent or Amount
                    garnishPercentAmountLabel.Location = new Point(394, 242);//How Much?
                    if (garnishPercentAmountRadioButton.Checked == true)
                    {
                        garnishPercentAmountTextBox.Location = new Point(585, 240);//Percent Text box
                        allowLabel.Location = new Point(394, 279);//Allowence Lable
                        allowTextBox.Location = new Point(585, 277);//Allowence Text Box
                        singleMarriedLabel.Location = new Point(394, 315);//Single or Married?
                        fillingStatusComboBox.Location = new Point(585, 313);//Filling Status
                        stateLabel.Location = new Point(394, 346);//State?
                        stateComboBox.Location = new Point(585, 344);//State Combo Box
                    }
                    else if (garnishWholeAmountRadioButton.Checked == true)
                    {
                        garnishWholeAmountTextBox.Location = new Point(585, 240);//Whole amount Text box
                        allowLabel.Location = new Point(394, 279);//Allowence Lable
                        allowTextBox.Location = new Point(585, 277);//Allowence Text Box
                        singleMarriedLabel.Location = new Point(394, 315);//Single or Married?
                        fillingStatusComboBox.Location = new Point(585, 313);//Filling Status
                        stateLabel.Location = new Point(394, 346);//State?
                        stateComboBox.Location = new Point(585, 344);//State Combo Box
                    }
                }
            }
        }

        private void garnishYesRadioButton_CheckedChanged(object sender, EventArgs e)//when checked it will make the garnish tools available.
        {
            if (garnishYesRadioButton.Checked == true)
            {
                garnishAmountLabel.Visible = true;
                garnishAmountGroupBox.Visible = true;
                if (preTaxYesRadioButton.Checked == false)
                {
                    garnishmentLabel.Location = new Point(394, 78);//Taken After Taxes
                    garnishmentGroupBox.Location = new Point(585, 65);//Yes and No radio buttons
                    garnishAmountLabel.Location = new Point(394, 117);//Percent or Amount
                    garnishAmountGroupBox.Location = new Point(585, 104);//Radio buttons Percent or Amount
                    garnishPercentAmountLabel.Location = new Point(394, 159);//How Much?
                    if (garnishPercentAmountRadioButton.Checked == true)
                    {
                        garnishPercentAmountTextBox.Location = new Point(585, 157);//Percent Text box
                        allowLabel.Location = new Point(394, 203);//Allowence Lable
                        allowTextBox.Location = new Point(585, 210);//Allowence Text Box
                        singleMarriedLabel.Location = new Point(394, 242);//Single or Married?
                        fillingStatusComboBox.Location = new Point(585, 240);//Filling Status
                        stateLabel.Location = new Point(394, 279);//State?
                        stateComboBox.Location = new Point(585, 277);//State Combo Box
                    }
                    else if (garnishWholeAmountRadioButton.Checked == true)
                    {
                        garnishWholeAmountTextBox.Location = new Point(585, 157);//Whole amount Text box
                        allowLabel.Location = new Point(394, 203);//Allowence Lable
                        allowTextBox.Location = new Point(585, 210);//Allowence Text Box
                        singleMarriedLabel.Location = new Point(394, 242);//Single or Married?
                        fillingStatusComboBox.Location = new Point(585, 240);//Filling Status
                        stateLabel.Location = new Point(394, 279);//State?
                        stateComboBox.Location = new Point(585, 277);//State Combo Box
                    }
                    else
                    {
                        allowLabel.Location = new Point(394, 159);//Allowence Lable
                        allowTextBox.Location = new Point(585, 157);//Allowence Text Box
                        singleMarriedLabel.Location = new Point(394, 203);//Single or Married?
                        fillingStatusComboBox.Location = new Point(585, 190);//Filling Status
                        stateLabel.Location = new Point(394, 242);//State?
                        stateComboBox.Location = new Point(585, 240);//State Combo Box
                    }
                }
                else if (preTaxYesRadioButton.Checked == true && preTaxAmountRadioButton.Checked == false && preTaxPercentRadioButton.Checked == false)
                {
                    garnishmentLabel.Location = new Point(394, 117);//Taken After Taxes
                    garnishmentGroupBox.Location = new Point(585, 104);//Yes and No radio buttons
                    garnishAmountLabel.Location = new Point(394, 159);//Percent or Amount
                    garnishAmountGroupBox.Location = new Point(585, 146);//Radio buttons Percent or Amount
                    garnishPercentAmountLabel.Location = new Point(394, 203);//How Much?
                    if (garnishPercentAmountRadioButton.Checked == true)
                    {
                        garnishPercentAmountTextBox.Location = new Point(585, 201);//Percent Text box
                        allowLabel.Location = new Point(394, 242);//Allowence Lable
                        allowTextBox.Location = new Point(585, 240);//Allowence Text Box
                        singleMarriedLabel.Location = new Point(394, 279);//Single or Married?
                        fillingStatusComboBox.Location = new Point(585, 277);//Filling Status
                        stateLabel.Location = new Point(394, 315);//State?
                        stateComboBox.Location = new Point(585, 313);//State Combo Box
                    }
                    else if (garnishWholeAmountRadioButton.Checked == true)
                    {
                        garnishWholeAmountTextBox.Location = new Point(585, 201);//Whole amount Text box
                        allowLabel.Location = new Point(394, 242);//Allowence Lable
                        allowTextBox.Location = new Point(585, 240);//Allowence Text Box
                        singleMarriedLabel.Location = new Point(394, 279);//Single or Married?
                        fillingStatusComboBox.Location = new Point(585, 277);//Filling Status
                        stateLabel.Location = new Point(394, 315);//State?
                        stateComboBox.Location = new Point(585, 313);//State Combo Box
                    }
                    else
                    {
                        allowLabel.Location = new Point(394, 203);//Allowence Lable
                        allowTextBox.Location = new Point(585, 201);//Allowence Text Box
                        singleMarriedLabel.Location = new Point(394, 242);//Single or Married?
                        fillingStatusComboBox.Location = new Point(585, 240);//Filling Status
                        stateLabel.Location = new Point(394, 279);//State?
                        stateComboBox.Location = new Point(585, 277);//State Combo Box
                    }
                }
                else if (preTaxYesRadioButton.Checked == true && preTaxPercentRadioButton.Checked == true || preTaxYesRadioButton.Checked == true && preTaxAmountRadioButton.Checked == true)
                {
                    garnishmentLabel.Location = new Point(394, 159);//Taken After Taxes
                    garnishmentGroupBox.Location = new Point(585, 146);//Yes and No radio buttons
                    garnishAmountLabel.Location = new Point(394, 203);//Percent or Amount
                    garnishAmountGroupBox.Location = new Point(585, 190);//Radio buttons Percent or Amount
                    garnishPercentAmountLabel.Location = new Point(394, 242);//How Much?
                    if (garnishPercentAmountRadioButton.Checked == true)
                    {
                        garnishPercentAmountTextBox.Location = new Point(585, 240);//Percent Text box
                        allowLabel.Location = new Point(394, 279);//Allowence Lable
                        allowTextBox.Location = new Point(585, 277);//Allowence Text Box
                        singleMarriedLabel.Location = new Point(394, 315);//Single or Married?
                        fillingStatusComboBox.Location = new Point(585, 313);//Filling Status
                        stateLabel.Location = new Point(394, 346);//State?
                        stateComboBox.Location = new Point(585, 344);//State Combo Box
                    }
                    else if (garnishWholeAmountRadioButton.Checked == true)
                    {
                        garnishWholeAmountTextBox.Location = new Point(585, 240);//Whole amount Text box
                        allowLabel.Location = new Point(394, 279);//Allowence Lable
                        allowTextBox.Location = new Point(585, 277);//Allowence Text Box
                        singleMarriedLabel.Location = new Point(394, 315);//Single or Married?
                        fillingStatusComboBox.Location = new Point(585, 313);//Filling Status
                        stateLabel.Location = new Point(394, 346);//State?
                        stateComboBox.Location = new Point(585, 344);//State Combo Box
                    }
                    else
                    {
                        allowLabel.Location = new Point(394, 242);//Allowence Lable
                        allowTextBox.Location = new Point(585, 240);//Allowence Text Box
                        singleMarriedLabel.Location = new Point(394, 279);//Single or Married?
                        fillingStatusComboBox.Location = new Point(585, 277);//Filling Status
                        stateLabel.Location = new Point(394, 315);//State?
                        stateComboBox.Location = new Point(585, 313);//State Combo Box
                    }
                }
            }
        }

        private void garnishNoRadioButton_CheckedChanged(object sender, EventArgs e)//Clears the garnish tools.
        {
            if (garnishNoRadioButton.Checked == true)
            {
                garnishWholeAmountRadioButton.Checked = false;
                garnishPercentAmountRadioButton.Checked = false;
                garnishLabel.Visible = false;
                garnishAmountGroupBox.Visible = false;
                garnishAmountLabel.Visible = false;
                garnishPercentAmountLabel.Visible = false;
                garnishPercentAmountTextBox.Visible = false;
                garnishWholeAmountTextBox.Visible = false;
                garnishWholeAmountTextBox.Text = "";
                garnishPercentAmountTextBox.Text = "";
                if (preTaxYesRadioButton.Checked == false)
                {
                    garnishmentLabel.Location = new Point(394, 78);//Taken After Taxes
                    garnishmentGroupBox.Location = new Point(585, 65);//Yes and No radio buttons
                    allowLabel.Location = new Point(394, 117);//Allowence Lable
                    allowTextBox.Location = new Point(585, 115);//Allowence Text Box
                    singleMarriedLabel.Location = new Point(394, 159);//Single or Married?
                    fillingStatusComboBox.Location = new Point(585, 157);//Filling Status
                    stateLabel.Location = new Point(394, 203);//State?
                    stateComboBox.Location = new Point(585, 201);//State Combo Box
                }
                else if (preTaxYesRadioButton.Checked == true && preTaxAmountRadioButton.Checked == false && preTaxPercentRadioButton.Checked == false)
                {
                    garnishmentLabel.Location = new Point(394, 117);//Taken After Taxes
                    garnishmentGroupBox.Location = new Point(585, 104);//Yes and No radio buttons
                    allowLabel.Location = new Point(394, 159);//Allowence Lable
                    allowTextBox.Location = new Point(585, 157);//Allowence Text Box
                    singleMarriedLabel.Location = new Point(394, 203);//Single or Married?
                    fillingStatusComboBox.Location = new Point(585, 201);//Filling Status
                    stateLabel.Location = new Point(394, 242);//State?
                    stateComboBox.Location = new Point(585, 240);//State Combo Box
                }
                else if (preTaxYesRadioButton.Checked == true && preTaxPercentRadioButton.Checked == true || preTaxYesRadioButton.Checked == true && preTaxAmountRadioButton.Checked == true)
                {
                    garnishmentLabel.Location = new Point(394, 159);//Taken After Taxes
                    garnishmentGroupBox.Location = new Point(585, 146);//Yes and No radio buttons
                    allowLabel.Location = new Point(394, 203);//Allowence Lable
                    allowTextBox.Location = new Point(585, 201);//Allowence Text Box
                    singleMarriedLabel.Location = new Point(394, 242);//Single or Married?
                    fillingStatusComboBox.Location = new Point(585, 240);//Filling Status
                    stateLabel.Location = new Point(394, 279);//State?
                    stateComboBox.Location = new Point(585, 277);//State Combo Box
                }
            }
        }

        private void garnishPercentAmountRadioButton_CheckedChanged(object sender, EventArgs e)//makes the precent box available and clears the amount box.
        {
            if (garnishPercentAmountRadioButton.Checked == true)
            {
                garnishPercentAmountLabel.Visible = true;
                garnishPercentAmountTextBox.Visible = true;
                garnishWholeAmountTextBox.Visible = false;
                garnishWholeAmountTextBox.Text = "";
                if (preTaxYesRadioButton.Checked == false)
                {
                    garnishmentLabel.Location = new Point(394, 78);//Taken After Taxes
                    garnishmentGroupBox.Location = new Point(585, 65);//Yes and No radio buttons
                    garnishAmountLabel.Location = new Point(394, 117);//Percent or Amount
                    garnishAmountGroupBox.Location = new Point(585, 104);//Radio buttons Percent or Amount
                    garnishPercentAmountLabel.Location = new Point(394, 159);//How Much?
                    garnishPercentAmountTextBox.Location = new Point(585, 157);//Percent Text box
                    allowLabel.Location = new Point(394, 203);//Allowence Lable
                    allowTextBox.Location = new Point(585, 201);//Allowence Text Box
                    singleMarriedLabel.Location = new Point(394, 242);//Single or Married?
                    fillingStatusComboBox.Location = new Point(585, 240);//Filling Status
                    stateLabel.Location = new Point(394, 279);//State?
                    stateComboBox.Location = new Point(585, 277);//State Combo Box
                }
                else if (preTaxYesRadioButton.Checked == true && preTaxAmountRadioButton.Checked == false && preTaxPercentRadioButton.Checked == false)
                {
                    garnishmentLabel.Location = new Point(394, 117);//Taken After Taxes
                    garnishmentGroupBox.Location = new Point(585, 104);//Yes and No radio buttons
                    garnishAmountLabel.Location = new Point(394, 159);//Percent or Amount
                    garnishAmountGroupBox.Location = new Point(585, 146);//Radio buttons Percent or Amount
                    garnishPercentAmountLabel.Location = new Point(394, 203);//How Much?
                    garnishPercentAmountTextBox.Location = new Point(585, 201);//Percent Text box
                    allowLabel.Location = new Point(394, 242);//Allowence Lable
                    allowTextBox.Location = new Point(585, 240);//Allowence Text Box
                    singleMarriedLabel.Location = new Point(394, 279);//Single or Married?
                    fillingStatusComboBox.Location = new Point(585, 277);//Filling Status
                    stateLabel.Location = new Point(394, 315);//State?
                    stateComboBox.Location = new Point(585, 313);//State Combo Box
                }
                else if (preTaxYesRadioButton.Checked == true && preTaxPercentRadioButton.Checked == true || preTaxYesRadioButton.Checked == true && preTaxAmountRadioButton.Checked == true)
                {
                    garnishmentLabel.Location = new Point(394, 159);//Taken After Taxes
                    garnishmentGroupBox.Location = new Point(585, 146);//Yes and No radio buttons
                    garnishAmountLabel.Location = new Point(394, 203);//Percent or Amount
                    garnishAmountGroupBox.Location = new Point(585, 190);//Radio buttons Percent or Amount
                    garnishPercentAmountLabel.Location = new Point(394, 242);//How Much?
                    garnishPercentAmountTextBox.Location = new Point(585, 240);//Percent Text box
                    allowLabel.Location = new Point(394, 279);//Allowence Lable
                    allowTextBox.Location = new Point(585, 277);//Allowence Text Box
                    singleMarriedLabel.Location = new Point(394, 315);//Single or Married?
                    fillingStatusComboBox.Location = new Point(585, 313);//Filling Status
                    stateLabel.Location = new Point(394, 346);//State?
                    stateComboBox.Location = new Point(585, 344);//State Combo Box
                }
            }
        }

        private void garnishWholeAmountRadioButton_CheckedChanged(object sender, EventArgs e)//Makes the amount box available and clears the percent box.
        {
            if (garnishWholeAmountRadioButton.Checked == true)
            {
                garnishPercentAmountLabel.Visible = true;
                garnishWholeAmountTextBox.Visible = true;
                garnishPercentAmountTextBox.Visible = false;
                garnishPercentAmountTextBox.Text = "";
                if (preTaxYesRadioButton.Checked == false)
                {
                    garnishmentLabel.Location = new Point(394, 78);//Taken After Taxes
                    garnishmentGroupBox.Location = new Point(585, 65);//Yes and No radio buttons
                    garnishAmountLabel.Location = new Point(394, 117);//Percent or Amount
                    garnishAmountGroupBox.Location = new Point(585, 104);//Radio buttons Percent or Amount
                    garnishPercentAmountLabel.Location = new Point(394, 159);//How Much?
                    garnishWholeAmountTextBox.Location = new Point(585, 157);//Whole amount Text box
                    allowLabel.Location = new Point(394, 203);//Allowence Lable
                    allowTextBox.Location = new Point(585, 201);//Allowence Text Box
                    singleMarriedLabel.Location = new Point(394, 242);//Single or Married?
                    fillingStatusComboBox.Location = new Point(585, 240);//Filling Status
                    stateLabel.Location = new Point(394, 279);//State?
                    stateComboBox.Location = new Point(585, 277);//State Combo Box
                }
                else if (preTaxYesRadioButton.Checked == true && preTaxAmountRadioButton.Checked == false && preTaxPercentRadioButton.Checked == false)
                {
                    garnishmentLabel.Location = new Point(394, 117);//Taken After Taxes
                    garnishmentGroupBox.Location = new Point(585, 104);//Yes and No radio buttons
                    garnishAmountLabel.Location = new Point(394, 159);//Percent or Amount
                    garnishAmountGroupBox.Location = new Point(585, 146);//Radio buttons Percent or Amount
                    garnishPercentAmountLabel.Location = new Point(394, 203);//How Much?
                    garnishWholeAmountTextBox.Location = new Point(585, 201);//Whole amount Text box
                    allowLabel.Location = new Point(394, 242);//Allowence Lable
                    allowTextBox.Location = new Point(585, 240);//Allowence Text Box
                    singleMarriedLabel.Location = new Point(394, 279);//Single or Married?
                    fillingStatusComboBox.Location = new Point(585, 277);//Filling Status
                    stateLabel.Location = new Point(394, 315);//State?
                    stateComboBox.Location = new Point(585, 313);//State Combo Box
                }
                else if (preTaxYesRadioButton.Checked == true && preTaxPercentRadioButton.Checked == true || preTaxYesRadioButton.Checked == true && preTaxAmountRadioButton.Checked == true)
                {
                    garnishmentLabel.Location = new Point(394, 159);//Taken After Taxes
                    garnishmentGroupBox.Location = new Point(585, 146);//Yes and No radio buttons
                    garnishAmountLabel.Location = new Point(394, 203);//Percent or Amount
                    garnishAmountGroupBox.Location = new Point(585, 190);//Radio buttons Percent or Amount
                    garnishPercentAmountLabel.Location = new Point(394, 242);//How Much?
                    garnishWholeAmountTextBox.Location = new Point(585, 240);//Whole amount Text box
                    allowLabel.Location = new Point(394, 279);//Allowence Lable
                    allowTextBox.Location = new Point(585, 277);//Allowence Text Box
                    singleMarriedLabel.Location = new Point(394, 315);//Single or Married?
                    fillingStatusComboBox.Location = new Point(585, 313);//Filling Status
                    stateLabel.Location = new Point(394, 346);//State?
                    stateComboBox.Location = new Point(585, 344);//State Combo Box
                }
            }
        }
    }
}