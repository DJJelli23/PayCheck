namespace PayCheck
{
    partial class payCheckForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(payCheckForm));
            this.hoursBox = new System.Windows.Forms.TextBox();
            this.firstWeekLabel = new System.Windows.Forms.Label();
            this.hoursFirstWorkedLabel = new System.Windows.Forms.Label();
            this.firstHourBox = new System.Windows.Forms.TextBox();
            this.calcButtonS = new System.Windows.Forms.Button();
            this.savingLabel = new System.Windows.Forms.Label();
            this.holidayPayLabel = new System.Windows.Forms.Label();
            this.howMuchSavingLabel = new System.Windows.Forms.Label();
            this.percentSavingBox = new System.Windows.Forms.TextBox();
            this.holidayGroupBox = new System.Windows.Forms.GroupBox();
            this.noHolidayRadioButton = new System.Windows.Forms.RadioButton();
            this.yesHolidayRadioButton = new System.Windows.Forms.RadioButton();
            this.grossLabel = new System.Windows.Forms.Label();
            this.preTaxLabel = new System.Windows.Forms.Label();
            this.garnishLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.savingsTotalLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.amountPercentSavingsLabel = new System.Windows.Forms.Label();
            this.amountComboBox = new System.Windows.Forms.GroupBox();
            this.amountSavingRadioButton = new System.Windows.Forms.RadioButton();
            this.percentSavingsRadioButton = new System.Windows.Forms.RadioButton();
            this.amountSavingTextBox = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.ptoGroupBox = new System.Windows.Forms.GroupBox();
            this.yesPTO = new System.Windows.Forms.RadioButton();
            this.noPTO = new System.Windows.Forms.RadioButton();
            this.ptoLabel = new System.Windows.Forms.Label();
            this.ptoTextBox = new System.Windows.Forms.TextBox();
            this.ptoAmountLabel = new System.Windows.Forms.Label();
            this.garnishmentGroupBox = new System.Windows.Forms.GroupBox();
            this.garnishNoRadioButton = new System.Windows.Forms.RadioButton();
            this.garnishYesRadioButton = new System.Windows.Forms.RadioButton();
            this.garnishmentLabel = new System.Windows.Forms.Label();
            this.allowTextBox = new System.Windows.Forms.TextBox();
            this.allowLabel = new System.Windows.Forms.Label();
            this.singleMarriedLabel = new System.Windows.Forms.Label();
            this.garnishAmountGroupBox = new System.Windows.Forms.GroupBox();
            this.garnishWholeAmountRadioButton = new System.Windows.Forms.RadioButton();
            this.garnishPercentAmountRadioButton = new System.Windows.Forms.RadioButton();
            this.garnishAmountLabel = new System.Windows.Forms.Label();
            this.garnishWholeAmountTextBox = new System.Windows.Forms.TextBox();
            this.garnishPercentAmountTextBox = new System.Windows.Forms.TextBox();
            this.garnishPercentAmountLabel = new System.Windows.Forms.Label();
            this.secHourBox = new System.Windows.Forms.TextBox();
            this.hoursSecWorkedLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.payPeriodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fillingStatusComboBox = new System.Windows.Forms.ComboBox();
            this.stateComboBox = new System.Windows.Forms.ComboBox();
            this.stateLabel = new System.Windows.Forms.Label();
            this.noSavingsRadioButton = new System.Windows.Forms.RadioButton();
            this.yesSavingsRadioButton = new System.Windows.Forms.RadioButton();
            this.savingsGroupBox = new System.Windows.Forms.GroupBox();
            this.preTaxAmountTextBox = new System.Windows.Forms.TextBox();
            this.preTaxPercentTextBox = new System.Windows.Forms.TextBox();
            this.preTaxHowMuchLabel = new System.Windows.Forms.Label();
            this.preTaxPerAmountGroupBox = new System.Windows.Forms.GroupBox();
            this.preTaxAmountRadioButton = new System.Windows.Forms.RadioButton();
            this.preTaxPercentRadioButton = new System.Windows.Forms.RadioButton();
            this.preTaxPerAmountLabel = new System.Windows.Forms.Label();
            this.preTaxGroupBox = new System.Windows.Forms.GroupBox();
            this.preTaxNoRadioButton = new System.Windows.Forms.RadioButton();
            this.preTaxYesRadioButton = new System.Windows.Forms.RadioButton();
            this.preTaxRadioButtonGroupLabel = new System.Windows.Forms.Label();
            this.holidayAmountTextBox = new System.Windows.Forms.TextBox();
            this.holidayAmountLabel = new System.Windows.Forms.Label();
            this.holidayGroupBox.SuspendLayout();
            this.amountComboBox.SuspendLayout();
            this.ptoGroupBox.SuspendLayout();
            this.garnishmentGroupBox.SuspendLayout();
            this.garnishAmountGroupBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.savingsGroupBox.SuspendLayout();
            this.preTaxPerAmountGroupBox.SuspendLayout();
            this.preTaxGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // hoursBox
            // 
            this.hoursBox.Location = new System.Drawing.Point(194, 32);
            this.hoursBox.Name = "hoursBox";
            this.hoursBox.Size = new System.Drawing.Size(45, 20);
            this.hoursBox.TabIndex = 0;
            this.hoursBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckEnter);
            // 
            // firstWeekLabel
            // 
            this.firstWeekLabel.AutoSize = true;
            this.firstWeekLabel.Font = new System.Drawing.Font("Imprint MT Shadow", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstWeekLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.firstWeekLabel.Location = new System.Drawing.Point(12, 34);
            this.firstWeekLabel.Name = "firstWeekLabel";
            this.firstWeekLabel.Size = new System.Drawing.Size(90, 15);
            this.firstWeekLabel.TabIndex = 0;
            this.firstWeekLabel.Text = "Pay Per Hours";
            // 
            // hoursFirstWorkedLabel
            // 
            this.hoursFirstWorkedLabel.AutoSize = true;
            this.hoursFirstWorkedLabel.Font = new System.Drawing.Font("Imprint MT Shadow", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoursFirstWorkedLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.hoursFirstWorkedLabel.Location = new System.Drawing.Point(12, 64);
            this.hoursFirstWorkedLabel.Name = "hoursFirstWorkedLabel";
            this.hoursFirstWorkedLabel.Size = new System.Drawing.Size(108, 15);
            this.hoursFirstWorkedLabel.TabIndex = 1;
            this.hoursFirstWorkedLabel.Text = "First Week Hours";
            // 
            // firstHourBox
            // 
            this.firstHourBox.Location = new System.Drawing.Point(194, 60);
            this.firstHourBox.Name = "firstHourBox";
            this.firstHourBox.Size = new System.Drawing.Size(100, 20);
            this.firstHourBox.TabIndex = 1;
            this.firstHourBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckEnter);
            // 
            // calcButtonS
            // 
            this.calcButtonS.BackColor = System.Drawing.SystemColors.HotTrack;
            this.calcButtonS.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.calcButtonS.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcButtonS.ForeColor = System.Drawing.Color.Navy;
            this.calcButtonS.Location = new System.Drawing.Point(284, 513);
            this.calcButtonS.Name = "calcButtonS";
            this.calcButtonS.Size = new System.Drawing.Size(112, 42);
            this.calcButtonS.TabIndex = 8;
            this.calcButtonS.Text = "Calculate";
            this.calcButtonS.UseVisualStyleBackColor = false;
            this.calcButtonS.Click += new System.EventHandler(this.calcButtonS_Click);
            // 
            // savingLabel
            // 
            this.savingLabel.AutoSize = true;
            this.savingLabel.Font = new System.Drawing.Font("Imprint MT Shadow", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savingLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.savingLabel.Location = new System.Drawing.Point(12, 131);
            this.savingLabel.Name = "savingLabel";
            this.savingLabel.Size = new System.Drawing.Size(76, 15);
            this.savingLabel.TabIndex = 4;
            this.savingLabel.Text = "You Saving?";
            // 
            // holidayPayLabel
            // 
            this.holidayPayLabel.AutoSize = true;
            this.holidayPayLabel.Font = new System.Drawing.Font("Imprint MT Shadow", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.holidayPayLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.holidayPayLabel.Location = new System.Drawing.Point(12, 256);
            this.holidayPayLabel.Name = "holidayPayLabel";
            this.holidayPayLabel.Size = new System.Drawing.Size(82, 15);
            this.holidayPayLabel.TabIndex = 8;
            this.holidayPayLabel.Text = "Holiday Pay?";
            // 
            // howMuchSavingLabel
            // 
            this.howMuchSavingLabel.AutoSize = true;
            this.howMuchSavingLabel.Font = new System.Drawing.Font("Imprint MT Shadow", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.howMuchSavingLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.howMuchSavingLabel.Location = new System.Drawing.Point(12, 213);
            this.howMuchSavingLabel.Name = "howMuchSavingLabel";
            this.howMuchSavingLabel.Size = new System.Drawing.Size(74, 15);
            this.howMuchSavingLabel.TabIndex = 9;
            this.howMuchSavingLabel.Text = "How Much?";
            this.howMuchSavingLabel.Visible = false;
            // 
            // percentSavingBox
            // 
            this.percentSavingBox.Location = new System.Drawing.Point(194, 209);
            this.percentSavingBox.Name = "percentSavingBox";
            this.percentSavingBox.Size = new System.Drawing.Size(45, 20);
            this.percentSavingBox.TabIndex = 2;
            this.percentSavingBox.Visible = false;
            this.percentSavingBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckEnter);
            // 
            // holidayGroupBox
            // 
            this.holidayGroupBox.Controls.Add(this.noHolidayRadioButton);
            this.holidayGroupBox.Controls.Add(this.yesHolidayRadioButton);
            this.holidayGroupBox.Location = new System.Drawing.Point(194, 240);
            this.holidayGroupBox.Name = "holidayGroupBox";
            this.holidayGroupBox.Size = new System.Drawing.Size(109, 34);
            this.holidayGroupBox.TabIndex = 12;
            this.holidayGroupBox.TabStop = false;
            // 
            // noHolidayRadioButton
            // 
            this.noHolidayRadioButton.AutoSize = true;
            this.noHolidayRadioButton.Font = new System.Drawing.Font("Imprint MT Shadow", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noHolidayRadioButton.ForeColor = System.Drawing.Color.MidnightBlue;
            this.noHolidayRadioButton.Location = new System.Drawing.Point(57, 11);
            this.noHolidayRadioButton.Name = "noHolidayRadioButton";
            this.noHolidayRadioButton.Size = new System.Drawing.Size(42, 19);
            this.noHolidayRadioButton.TabIndex = 1;
            this.noHolidayRadioButton.TabStop = true;
            this.noHolidayRadioButton.Text = "No";
            this.noHolidayRadioButton.UseVisualStyleBackColor = true;
            this.noHolidayRadioButton.CheckedChanged += new System.EventHandler(this.noHolidayRadioButton_CheckedChanged);
            // 
            // yesHolidayRadioButton
            // 
            this.yesHolidayRadioButton.AutoSize = true;
            this.yesHolidayRadioButton.Font = new System.Drawing.Font("Imprint MT Shadow", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yesHolidayRadioButton.ForeColor = System.Drawing.Color.MidnightBlue;
            this.yesHolidayRadioButton.Location = new System.Drawing.Point(6, 11);
            this.yesHolidayRadioButton.Name = "yesHolidayRadioButton";
            this.yesHolidayRadioButton.Size = new System.Drawing.Size(45, 19);
            this.yesHolidayRadioButton.TabIndex = 0;
            this.yesHolidayRadioButton.TabStop = true;
            this.yesHolidayRadioButton.Text = "Yes";
            this.yesHolidayRadioButton.UseVisualStyleBackColor = true;
            this.yesHolidayRadioButton.CheckedChanged += new System.EventHandler(this.yesHolidayRadioButton_CheckedChanged);
            // 
            // grossLabel
            // 
            this.grossLabel.AutoSize = true;
            this.grossLabel.Font = new System.Drawing.Font("Imprint MT Shadow", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grossLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.grossLabel.Location = new System.Drawing.Point(394, 388);
            this.grossLabel.Name = "grossLabel";
            this.grossLabel.Size = new System.Drawing.Size(99, 15);
            this.grossLabel.TabIndex = 13;
            this.grossLabel.Text = "Gross amount is ";
            this.grossLabel.Visible = false;
            // 
            // preTaxLabel
            // 
            this.preTaxLabel.AutoSize = true;
            this.preTaxLabel.Font = new System.Drawing.Font("Imprint MT Shadow", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preTaxLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.preTaxLabel.Location = new System.Drawing.Point(394, 406);
            this.preTaxLabel.Name = "preTaxLabel";
            this.preTaxLabel.Size = new System.Drawing.Size(78, 15);
            this.preTaxLabel.TabIndex = 14;
            this.preTaxLabel.Text = "After Pretax ";
            this.preTaxLabel.Visible = false;
            // 
            // garnishLabel
            // 
            this.garnishLabel.AutoSize = true;
            this.garnishLabel.Font = new System.Drawing.Font("Imprint MT Shadow", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.garnishLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.garnishLabel.Location = new System.Drawing.Point(394, 447);
            this.garnishLabel.Name = "garnishLabel";
            this.garnishLabel.Size = new System.Drawing.Size(83, 15);
            this.garnishLabel.TabIndex = 15;
            this.garnishLabel.Text = "After Posttax ";
            this.garnishLabel.Visible = false;
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Imprint MT Shadow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.totalLabel.Location = new System.Drawing.Point(10, 412);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(140, 28);
            this.totalLabel.TabIndex = 16;
            this.totalLabel.Text = "Paycheck is ";
            this.totalLabel.Visible = false;
            // 
            // savingsTotalLabel
            // 
            this.savingsTotalLabel.AutoSize = true;
            this.savingsTotalLabel.Font = new System.Drawing.Font("Imprint MT Shadow", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savingsTotalLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.savingsTotalLabel.Location = new System.Drawing.Point(394, 468);
            this.savingsTotalLabel.Name = "savingsTotalLabel";
            this.savingsTotalLabel.Size = new System.Drawing.Size(87, 15);
            this.savingsTotalLabel.TabIndex = 17;
            this.savingsTotalLabel.Text = "Savings Total ";
            this.savingsTotalLabel.Visible = false;
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.Font = new System.Drawing.Font("Imprint MT Shadow", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.taxLabel.Location = new System.Drawing.Point(394, 426);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(174, 15);
            this.taxLabel.TabIndex = 18;
            this.taxLabel.Text = "After State and Federal Taxes ";
            this.taxLabel.Visible = false;
            // 
            // amountPercentSavingsLabel
            // 
            this.amountPercentSavingsLabel.AutoSize = true;
            this.amountPercentSavingsLabel.Font = new System.Drawing.Font("Imprint MT Shadow", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountPercentSavingsLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.amountPercentSavingsLabel.Location = new System.Drawing.Point(12, 170);
            this.amountPercentSavingsLabel.Name = "amountPercentSavingsLabel";
            this.amountPercentSavingsLabel.Size = new System.Drawing.Size(132, 15);
            this.amountPercentSavingsLabel.TabIndex = 19;
            this.amountPercentSavingsLabel.Text = "Percent or set amount?";
            this.amountPercentSavingsLabel.Visible = false;
            // 
            // amountComboBox
            // 
            this.amountComboBox.Controls.Add(this.amountSavingRadioButton);
            this.amountComboBox.Controls.Add(this.percentSavingsRadioButton);
            this.amountComboBox.Location = new System.Drawing.Point(194, 161);
            this.amountComboBox.Name = "amountComboBox";
            this.amountComboBox.Size = new System.Drawing.Size(179, 34);
            this.amountComboBox.TabIndex = 13;
            this.amountComboBox.TabStop = false;
            this.amountComboBox.Visible = false;
            // 
            // amountSavingRadioButton
            // 
            this.amountSavingRadioButton.AutoSize = true;
            this.amountSavingRadioButton.Font = new System.Drawing.Font("Imprint MT Shadow", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountSavingRadioButton.ForeColor = System.Drawing.Color.MidnightBlue;
            this.amountSavingRadioButton.Location = new System.Drawing.Point(90, 11);
            this.amountSavingRadioButton.Name = "amountSavingRadioButton";
            this.amountSavingRadioButton.Size = new System.Drawing.Size(70, 19);
            this.amountSavingRadioButton.TabIndex = 1;
            this.amountSavingRadioButton.TabStop = true;
            this.amountSavingRadioButton.Text = "Amount";
            this.amountSavingRadioButton.UseVisualStyleBackColor = true;
            this.amountSavingRadioButton.CheckedChanged += new System.EventHandler(this.amountRadioButton_CheckedChanged);
            // 
            // percentSavingsRadioButton
            // 
            this.percentSavingsRadioButton.AutoSize = true;
            this.percentSavingsRadioButton.Font = new System.Drawing.Font("Imprint MT Shadow", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percentSavingsRadioButton.ForeColor = System.Drawing.Color.MidnightBlue;
            this.percentSavingsRadioButton.Location = new System.Drawing.Point(6, 11);
            this.percentSavingsRadioButton.Name = "percentSavingsRadioButton";
            this.percentSavingsRadioButton.Size = new System.Drawing.Size(68, 19);
            this.percentSavingsRadioButton.TabIndex = 0;
            this.percentSavingsRadioButton.TabStop = true;
            this.percentSavingsRadioButton.Text = "Percent";
            this.percentSavingsRadioButton.UseVisualStyleBackColor = true;
            this.percentSavingsRadioButton.CheckedChanged += new System.EventHandler(this.percentRadioButton_CheckedChanged);
            // 
            // amountSavingTextBox
            // 
            this.amountSavingTextBox.Location = new System.Drawing.Point(273, 209);
            this.amountSavingTextBox.Name = "amountSavingTextBox";
            this.amountSavingTextBox.Size = new System.Drawing.Size(100, 20);
            this.amountSavingTextBox.TabIndex = 3;
            this.amountSavingTextBox.Visible = false;
            this.amountSavingTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckEnter);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.ForeColor = System.Drawing.Color.Navy;
            this.clearButton.Location = new System.Drawing.Point(453, 513);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(112, 42);
            this.clearButton.TabIndex = 9;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // ptoGroupBox
            // 
            this.ptoGroupBox.Controls.Add(this.yesPTO);
            this.ptoGroupBox.Controls.Add(this.noPTO);
            this.ptoGroupBox.Location = new System.Drawing.Point(194, 313);
            this.ptoGroupBox.Name = "ptoGroupBox";
            this.ptoGroupBox.Size = new System.Drawing.Size(109, 35);
            this.ptoGroupBox.TabIndex = 25;
            this.ptoGroupBox.TabStop = false;
            // 
            // yesPTO
            // 
            this.yesPTO.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton;
            this.yesPTO.AutoSize = true;
            this.yesPTO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.yesPTO.Font = new System.Drawing.Font("Imprint MT Shadow", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yesPTO.ForeColor = System.Drawing.Color.MidnightBlue;
            this.yesPTO.Location = new System.Drawing.Point(6, 10);
            this.yesPTO.Name = "yesPTO";
            this.yesPTO.Size = new System.Drawing.Size(45, 19);
            this.yesPTO.TabIndex = 0;
            this.yesPTO.TabStop = true;
            this.yesPTO.Text = "Yes";
            this.yesPTO.UseVisualStyleBackColor = true;
            this.yesPTO.CheckedChanged += new System.EventHandler(this.yesPTO_CheckedChanged);
            // 
            // noPTO
            // 
            this.noPTO.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton;
            this.noPTO.AutoSize = true;
            this.noPTO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.noPTO.Font = new System.Drawing.Font("Imprint MT Shadow", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noPTO.ForeColor = System.Drawing.Color.MidnightBlue;
            this.noPTO.Location = new System.Drawing.Point(57, 10);
            this.noPTO.Name = "noPTO";
            this.noPTO.Size = new System.Drawing.Size(42, 19);
            this.noPTO.TabIndex = 1;
            this.noPTO.TabStop = true;
            this.noPTO.Text = "No";
            this.noPTO.UseVisualStyleBackColor = true;
            this.noPTO.CheckedChanged += new System.EventHandler(this.noPTO_CheckedChanged);
            // 
            // ptoLabel
            // 
            this.ptoLabel.AutoSize = true;
            this.ptoLabel.Font = new System.Drawing.Font("Imprint MT Shadow", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ptoLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ptoLabel.Location = new System.Drawing.Point(12, 327);
            this.ptoLabel.Name = "ptoLabel";
            this.ptoLabel.Size = new System.Drawing.Size(99, 15);
            this.ptoLabel.TabIndex = 24;
            this.ptoLabel.Text = "Any PTO taken?";
            // 
            // ptoTextBox
            // 
            this.ptoTextBox.Location = new System.Drawing.Point(194, 361);
            this.ptoTextBox.Name = "ptoTextBox";
            this.ptoTextBox.Size = new System.Drawing.Size(45, 20);
            this.ptoTextBox.TabIndex = 26;
            this.ptoTextBox.Visible = false;
            this.ptoTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckEnter);
            // 
            // ptoAmountLabel
            // 
            this.ptoAmountLabel.AutoSize = true;
            this.ptoAmountLabel.Font = new System.Drawing.Font("Imprint MT Shadow", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ptoAmountLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ptoAmountLabel.Location = new System.Drawing.Point(12, 366);
            this.ptoAmountLabel.Name = "ptoAmountLabel";
            this.ptoAmountLabel.Size = new System.Drawing.Size(74, 15);
            this.ptoAmountLabel.TabIndex = 27;
            this.ptoAmountLabel.Text = "How Much?";
            this.ptoAmountLabel.Visible = false;
            // 
            // garnishmentGroupBox
            // 
            this.garnishmentGroupBox.Controls.Add(this.garnishNoRadioButton);
            this.garnishmentGroupBox.Controls.Add(this.garnishYesRadioButton);
            this.garnishmentGroupBox.Location = new System.Drawing.Point(585, 146);
            this.garnishmentGroupBox.Name = "garnishmentGroupBox";
            this.garnishmentGroupBox.Size = new System.Drawing.Size(109, 34);
            this.garnishmentGroupBox.TabIndex = 29;
            this.garnishmentGroupBox.TabStop = false;
            // 
            // garnishNoRadioButton
            // 
            this.garnishNoRadioButton.AutoSize = true;
            this.garnishNoRadioButton.Font = new System.Drawing.Font("Imprint MT Shadow", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.garnishNoRadioButton.ForeColor = System.Drawing.Color.MidnightBlue;
            this.garnishNoRadioButton.Location = new System.Drawing.Point(57, 11);
            this.garnishNoRadioButton.Name = "garnishNoRadioButton";
            this.garnishNoRadioButton.Size = new System.Drawing.Size(42, 19);
            this.garnishNoRadioButton.TabIndex = 1;
            this.garnishNoRadioButton.TabStop = true;
            this.garnishNoRadioButton.Text = "No";
            this.garnishNoRadioButton.UseVisualStyleBackColor = true;
            this.garnishNoRadioButton.CheckedChanged += new System.EventHandler(this.garnishNoRadioButton_CheckedChanged);
            // 
            // garnishYesRadioButton
            // 
            this.garnishYesRadioButton.AutoSize = true;
            this.garnishYesRadioButton.Font = new System.Drawing.Font("Imprint MT Shadow", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.garnishYesRadioButton.ForeColor = System.Drawing.Color.MidnightBlue;
            this.garnishYesRadioButton.Location = new System.Drawing.Point(6, 11);
            this.garnishYesRadioButton.Name = "garnishYesRadioButton";
            this.garnishYesRadioButton.Size = new System.Drawing.Size(45, 19);
            this.garnishYesRadioButton.TabIndex = 0;
            this.garnishYesRadioButton.TabStop = true;
            this.garnishYesRadioButton.Text = "Yes";
            this.garnishYesRadioButton.UseVisualStyleBackColor = true;
            this.garnishYesRadioButton.CheckedChanged += new System.EventHandler(this.garnishYesRadioButton_CheckedChanged);
            // 
            // garnishmentLabel
            // 
            this.garnishmentLabel.AutoSize = true;
            this.garnishmentLabel.Font = new System.Drawing.Font("Imprint MT Shadow", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.garnishmentLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.garnishmentLabel.Location = new System.Drawing.Point(394, 159);
            this.garnishmentLabel.Name = "garnishmentLabel";
            this.garnishmentLabel.Size = new System.Drawing.Size(176, 15);
            this.garnishmentLabel.TabIndex = 28;
            this.garnishmentLabel.Text = "Anything taken out after taxes?";
            // 
            // allowTextBox
            // 
            this.allowTextBox.Location = new System.Drawing.Point(585, 277);
            this.allowTextBox.Name = "allowTextBox";
            this.allowTextBox.Size = new System.Drawing.Size(45, 20);
            this.allowTextBox.TabIndex = 30;
            this.allowTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckEnter);
            // 
            // allowLabel
            // 
            this.allowLabel.AutoSize = true;
            this.allowLabel.Font = new System.Drawing.Font("Imprint MT Shadow", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allowLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.allowLabel.Location = new System.Drawing.Point(394, 279);
            this.allowLabel.Name = "allowLabel";
            this.allowLabel.Size = new System.Drawing.Size(71, 15);
            this.allowLabel.TabIndex = 31;
            this.allowLabel.Text = "Allowences";
            // 
            // singleMarriedLabel
            // 
            this.singleMarriedLabel.AutoSize = true;
            this.singleMarriedLabel.Font = new System.Drawing.Font("Imprint MT Shadow", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.singleMarriedLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.singleMarriedLabel.Location = new System.Drawing.Point(394, 315);
            this.singleMarriedLabel.Name = "singleMarriedLabel";
            this.singleMarriedLabel.Size = new System.Drawing.Size(110, 15);
            this.singleMarriedLabel.TabIndex = 33;
            this.singleMarriedLabel.Text = "Single or Married?";
            // 
            // garnishAmountGroupBox
            // 
            this.garnishAmountGroupBox.Controls.Add(this.garnishWholeAmountRadioButton);
            this.garnishAmountGroupBox.Controls.Add(this.garnishPercentAmountRadioButton);
            this.garnishAmountGroupBox.Location = new System.Drawing.Point(585, 190);
            this.garnishAmountGroupBox.Name = "garnishAmountGroupBox";
            this.garnishAmountGroupBox.Size = new System.Drawing.Size(179, 34);
            this.garnishAmountGroupBox.TabIndex = 34;
            this.garnishAmountGroupBox.TabStop = false;
            this.garnishAmountGroupBox.Visible = false;
            // 
            // garnishWholeAmountRadioButton
            // 
            this.garnishWholeAmountRadioButton.AutoSize = true;
            this.garnishWholeAmountRadioButton.Font = new System.Drawing.Font("Imprint MT Shadow", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.garnishWholeAmountRadioButton.ForeColor = System.Drawing.Color.MidnightBlue;
            this.garnishWholeAmountRadioButton.Location = new System.Drawing.Point(90, 11);
            this.garnishWholeAmountRadioButton.Name = "garnishWholeAmountRadioButton";
            this.garnishWholeAmountRadioButton.Size = new System.Drawing.Size(70, 19);
            this.garnishWholeAmountRadioButton.TabIndex = 1;
            this.garnishWholeAmountRadioButton.TabStop = true;
            this.garnishWholeAmountRadioButton.Text = "Amount";
            this.garnishWholeAmountRadioButton.UseVisualStyleBackColor = true;
            this.garnishWholeAmountRadioButton.CheckedChanged += new System.EventHandler(this.garnishWholeAmountRadioButton_CheckedChanged);
            // 
            // garnishPercentAmountRadioButton
            // 
            this.garnishPercentAmountRadioButton.AutoSize = true;
            this.garnishPercentAmountRadioButton.Font = new System.Drawing.Font("Imprint MT Shadow", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.garnishPercentAmountRadioButton.ForeColor = System.Drawing.Color.MidnightBlue;
            this.garnishPercentAmountRadioButton.Location = new System.Drawing.Point(6, 11);
            this.garnishPercentAmountRadioButton.Name = "garnishPercentAmountRadioButton";
            this.garnishPercentAmountRadioButton.Size = new System.Drawing.Size(68, 19);
            this.garnishPercentAmountRadioButton.TabIndex = 0;
            this.garnishPercentAmountRadioButton.TabStop = true;
            this.garnishPercentAmountRadioButton.Text = "Percent";
            this.garnishPercentAmountRadioButton.UseVisualStyleBackColor = true;
            this.garnishPercentAmountRadioButton.CheckedChanged += new System.EventHandler(this.garnishPercentAmountRadioButton_CheckedChanged);
            // 
            // garnishAmountLabel
            // 
            this.garnishAmountLabel.AutoSize = true;
            this.garnishAmountLabel.Font = new System.Drawing.Font("Imprint MT Shadow", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.garnishAmountLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.garnishAmountLabel.Location = new System.Drawing.Point(394, 203);
            this.garnishAmountLabel.Name = "garnishAmountLabel";
            this.garnishAmountLabel.Size = new System.Drawing.Size(132, 15);
            this.garnishAmountLabel.TabIndex = 35;
            this.garnishAmountLabel.Text = "Percent or set amount?";
            this.garnishAmountLabel.Visible = false;
            // 
            // garnishWholeAmountTextBox
            // 
            this.garnishWholeAmountTextBox.Location = new System.Drawing.Point(664, 240);
            this.garnishWholeAmountTextBox.Name = "garnishWholeAmountTextBox";
            this.garnishWholeAmountTextBox.Size = new System.Drawing.Size(100, 20);
            this.garnishWholeAmountTextBox.TabIndex = 37;
            this.garnishWholeAmountTextBox.Visible = false;
            this.garnishWholeAmountTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckEnter);
            // 
            // garnishPercentAmountTextBox
            // 
            this.garnishPercentAmountTextBox.Location = new System.Drawing.Point(585, 240);
            this.garnishPercentAmountTextBox.Name = "garnishPercentAmountTextBox";
            this.garnishPercentAmountTextBox.Size = new System.Drawing.Size(45, 20);
            this.garnishPercentAmountTextBox.TabIndex = 36;
            this.garnishPercentAmountTextBox.Visible = false;
            this.garnishPercentAmountTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckEnter);
            // 
            // garnishPercentAmountLabel
            // 
            this.garnishPercentAmountLabel.AutoSize = true;
            this.garnishPercentAmountLabel.Font = new System.Drawing.Font("Imprint MT Shadow", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.garnishPercentAmountLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.garnishPercentAmountLabel.Location = new System.Drawing.Point(394, 242);
            this.garnishPercentAmountLabel.Name = "garnishPercentAmountLabel";
            this.garnishPercentAmountLabel.Size = new System.Drawing.Size(74, 15);
            this.garnishPercentAmountLabel.TabIndex = 38;
            this.garnishPercentAmountLabel.Text = "How Much?";
            this.garnishPercentAmountLabel.Visible = false;
            // 
            // secHourBox
            // 
            this.secHourBox.Location = new System.Drawing.Point(194, 90);
            this.secHourBox.Name = "secHourBox";
            this.secHourBox.Size = new System.Drawing.Size(100, 20);
            this.secHourBox.TabIndex = 3;
            this.secHourBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckEnter);
            // 
            // hoursSecWorkedLabel
            // 
            this.hoursSecWorkedLabel.AutoSize = true;
            this.hoursSecWorkedLabel.Font = new System.Drawing.Font("Imprint MT Shadow", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoursSecWorkedLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.hoursSecWorkedLabel.Location = new System.Drawing.Point(12, 94);
            this.hoursSecWorkedLabel.Name = "hoursSecWorkedLabel";
            this.hoursSecWorkedLabel.Size = new System.Drawing.Size(122, 15);
            this.hoursSecWorkedLabel.TabIndex = 41;
            this.hoursSecWorkedLabel.Text = "Second Week Hours";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.payPeriodToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(852, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // payPeriodToolStripMenuItem
            // 
            this.payPeriodToolStripMenuItem.Name = "payPeriodToolStripMenuItem";
            this.payPeriodToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.payPeriodToolStripMenuItem.Text = "Pay Period";
            // 
            // fillingStatusComboBox
            // 
            this.fillingStatusComboBox.FormattingEnabled = true;
            this.fillingStatusComboBox.Items.AddRange(new object[] {
            "",
            "Single",
            "Married Jointly",
            "Married Seperately",
            "Head of Household"});
            this.fillingStatusComboBox.Location = new System.Drawing.Point(585, 313);
            this.fillingStatusComboBox.Name = "fillingStatusComboBox";
            this.fillingStatusComboBox.Size = new System.Drawing.Size(121, 21);
            this.fillingStatusComboBox.TabIndex = 42;
            this.fillingStatusComboBox.SelectedIndexChanged += new System.EventHandler(this.fillingStatusComboBox_SelectedIndexChanged);
            this.fillingStatusComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckEnter);
            // 
            // stateComboBox
            // 
            this.stateComboBox.FormattingEnabled = true;
            this.stateComboBox.Items.AddRange(new object[] {
            "",
            "CO - Colorado",
            "UT - Utah",
            "WA - Washington"});
            this.stateComboBox.Location = new System.Drawing.Point(585, 344);
            this.stateComboBox.Name = "stateComboBox";
            this.stateComboBox.Size = new System.Drawing.Size(121, 21);
            this.stateComboBox.TabIndex = 44;
            this.stateComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckEnter);
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Font = new System.Drawing.Font("Imprint MT Shadow", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stateLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.stateLabel.Location = new System.Drawing.Point(394, 346);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(35, 15);
            this.stateLabel.TabIndex = 43;
            this.stateLabel.Text = "State";
            // 
            // noSavingsRadioButton
            // 
            this.noSavingsRadioButton.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton;
            this.noSavingsRadioButton.AutoSize = true;
            this.noSavingsRadioButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.noSavingsRadioButton.Font = new System.Drawing.Font("Imprint MT Shadow", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noSavingsRadioButton.ForeColor = System.Drawing.Color.MidnightBlue;
            this.noSavingsRadioButton.Location = new System.Drawing.Point(57, 10);
            this.noSavingsRadioButton.Name = "noSavingsRadioButton";
            this.noSavingsRadioButton.Size = new System.Drawing.Size(42, 19);
            this.noSavingsRadioButton.TabIndex = 5;
            this.noSavingsRadioButton.TabStop = true;
            this.noSavingsRadioButton.Text = "No";
            this.noSavingsRadioButton.UseVisualStyleBackColor = true;
            this.noSavingsRadioButton.CheckedChanged += new System.EventHandler(this.noSavingsRadioButton_CheckedChanged);
            // 
            // yesSavingsRadioButton
            // 
            this.yesSavingsRadioButton.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton;
            this.yesSavingsRadioButton.AutoSize = true;
            this.yesSavingsRadioButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.yesSavingsRadioButton.Font = new System.Drawing.Font("Imprint MT Shadow", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yesSavingsRadioButton.ForeColor = System.Drawing.Color.MidnightBlue;
            this.yesSavingsRadioButton.Location = new System.Drawing.Point(6, 10);
            this.yesSavingsRadioButton.Name = "yesSavingsRadioButton";
            this.yesSavingsRadioButton.Size = new System.Drawing.Size(45, 19);
            this.yesSavingsRadioButton.TabIndex = 4;
            this.yesSavingsRadioButton.TabStop = true;
            this.yesSavingsRadioButton.Text = "Yes";
            this.yesSavingsRadioButton.UseVisualStyleBackColor = true;
            this.yesSavingsRadioButton.Click += new System.EventHandler(this.yesSavingsRadioButton_CheckedChanged);
            // 
            // savingsGroupBox
            // 
            this.savingsGroupBox.Controls.Add(this.yesSavingsRadioButton);
            this.savingsGroupBox.Controls.Add(this.noSavingsRadioButton);
            this.savingsGroupBox.Location = new System.Drawing.Point(194, 118);
            this.savingsGroupBox.Name = "savingsGroupBox";
            this.savingsGroupBox.Size = new System.Drawing.Size(109, 35);
            this.savingsGroupBox.TabIndex = 11;
            this.savingsGroupBox.TabStop = false;
            // 
            // preTaxAmountTextBox
            // 
            this.preTaxAmountTextBox.Location = new System.Drawing.Point(664, 115);
            this.preTaxAmountTextBox.Name = "preTaxAmountTextBox";
            this.preTaxAmountTextBox.Size = new System.Drawing.Size(100, 20);
            this.preTaxAmountTextBox.TabIndex = 50;
            this.preTaxAmountTextBox.Visible = false;
            this.preTaxAmountTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckEnter);
            // 
            // preTaxPercentTextBox
            // 
            this.preTaxPercentTextBox.Location = new System.Drawing.Point(585, 115);
            this.preTaxPercentTextBox.Name = "preTaxPercentTextBox";
            this.preTaxPercentTextBox.Size = new System.Drawing.Size(45, 20);
            this.preTaxPercentTextBox.TabIndex = 49;
            this.preTaxPercentTextBox.Visible = false;
            this.preTaxPercentTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckEnter);
            // 
            // preTaxHowMuchLabel
            // 
            this.preTaxHowMuchLabel.AutoSize = true;
            this.preTaxHowMuchLabel.Font = new System.Drawing.Font("Imprint MT Shadow", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preTaxHowMuchLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.preTaxHowMuchLabel.Location = new System.Drawing.Point(394, 117);
            this.preTaxHowMuchLabel.Name = "preTaxHowMuchLabel";
            this.preTaxHowMuchLabel.Size = new System.Drawing.Size(74, 15);
            this.preTaxHowMuchLabel.TabIndex = 51;
            this.preTaxHowMuchLabel.Text = "How Much?";
            this.preTaxHowMuchLabel.Visible = false;
            // 
            // preTaxPerAmountGroupBox
            // 
            this.preTaxPerAmountGroupBox.Controls.Add(this.preTaxAmountRadioButton);
            this.preTaxPerAmountGroupBox.Controls.Add(this.preTaxPercentRadioButton);
            this.preTaxPerAmountGroupBox.Location = new System.Drawing.Point(585, 65);
            this.preTaxPerAmountGroupBox.Name = "preTaxPerAmountGroupBox";
            this.preTaxPerAmountGroupBox.Size = new System.Drawing.Size(179, 34);
            this.preTaxPerAmountGroupBox.TabIndex = 47;
            this.preTaxPerAmountGroupBox.TabStop = false;
            this.preTaxPerAmountGroupBox.Visible = false;
            // 
            // preTaxAmountRadioButton
            // 
            this.preTaxAmountRadioButton.AutoSize = true;
            this.preTaxAmountRadioButton.Font = new System.Drawing.Font("Imprint MT Shadow", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preTaxAmountRadioButton.ForeColor = System.Drawing.Color.MidnightBlue;
            this.preTaxAmountRadioButton.Location = new System.Drawing.Point(90, 11);
            this.preTaxAmountRadioButton.Name = "preTaxAmountRadioButton";
            this.preTaxAmountRadioButton.Size = new System.Drawing.Size(70, 19);
            this.preTaxAmountRadioButton.TabIndex = 1;
            this.preTaxAmountRadioButton.TabStop = true;
            this.preTaxAmountRadioButton.Text = "Amount";
            this.preTaxAmountRadioButton.UseVisualStyleBackColor = true;
            this.preTaxAmountRadioButton.CheckedChanged += new System.EventHandler(this.preTaxAmountRadioButton_CheckedChanged);
            // 
            // preTaxPercentRadioButton
            // 
            this.preTaxPercentRadioButton.AutoSize = true;
            this.preTaxPercentRadioButton.Font = new System.Drawing.Font("Imprint MT Shadow", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preTaxPercentRadioButton.ForeColor = System.Drawing.Color.MidnightBlue;
            this.preTaxPercentRadioButton.Location = new System.Drawing.Point(6, 11);
            this.preTaxPercentRadioButton.Name = "preTaxPercentRadioButton";
            this.preTaxPercentRadioButton.Size = new System.Drawing.Size(68, 19);
            this.preTaxPercentRadioButton.TabIndex = 0;
            this.preTaxPercentRadioButton.TabStop = true;
            this.preTaxPercentRadioButton.Text = "Percent";
            this.preTaxPercentRadioButton.UseVisualStyleBackColor = true;
            this.preTaxPercentRadioButton.CheckedChanged += new System.EventHandler(this.preTaxPercentRadioButton_CheckedChanged);
            // 
            // preTaxPerAmountLabel
            // 
            this.preTaxPerAmountLabel.AutoSize = true;
            this.preTaxPerAmountLabel.Font = new System.Drawing.Font("Imprint MT Shadow", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preTaxPerAmountLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.preTaxPerAmountLabel.Location = new System.Drawing.Point(394, 78);
            this.preTaxPerAmountLabel.Name = "preTaxPerAmountLabel";
            this.preTaxPerAmountLabel.Size = new System.Drawing.Size(132, 15);
            this.preTaxPerAmountLabel.TabIndex = 48;
            this.preTaxPerAmountLabel.Text = "Percent or set amount?";
            this.preTaxPerAmountLabel.Visible = false;
            // 
            // preTaxGroupBox
            // 
            this.preTaxGroupBox.Controls.Add(this.preTaxNoRadioButton);
            this.preTaxGroupBox.Controls.Add(this.preTaxYesRadioButton);
            this.preTaxGroupBox.Location = new System.Drawing.Point(585, 23);
            this.preTaxGroupBox.Name = "preTaxGroupBox";
            this.preTaxGroupBox.Size = new System.Drawing.Size(109, 34);
            this.preTaxGroupBox.TabIndex = 46;
            this.preTaxGroupBox.TabStop = false;
            // 
            // preTaxNoRadioButton
            // 
            this.preTaxNoRadioButton.AutoSize = true;
            this.preTaxNoRadioButton.Font = new System.Drawing.Font("Imprint MT Shadow", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preTaxNoRadioButton.ForeColor = System.Drawing.Color.MidnightBlue;
            this.preTaxNoRadioButton.Location = new System.Drawing.Point(57, 11);
            this.preTaxNoRadioButton.Name = "preTaxNoRadioButton";
            this.preTaxNoRadioButton.Size = new System.Drawing.Size(42, 19);
            this.preTaxNoRadioButton.TabIndex = 1;
            this.preTaxNoRadioButton.TabStop = true;
            this.preTaxNoRadioButton.Text = "No";
            this.preTaxNoRadioButton.UseVisualStyleBackColor = true;
            this.preTaxNoRadioButton.CheckedChanged += new System.EventHandler(this.preTaxNoRadioButton_CheckedChanged);
            // 
            // preTaxYesRadioButton
            // 
            this.preTaxYesRadioButton.AutoSize = true;
            this.preTaxYesRadioButton.Font = new System.Drawing.Font("Imprint MT Shadow", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preTaxYesRadioButton.ForeColor = System.Drawing.Color.MidnightBlue;
            this.preTaxYesRadioButton.Location = new System.Drawing.Point(6, 11);
            this.preTaxYesRadioButton.Name = "preTaxYesRadioButton";
            this.preTaxYesRadioButton.Size = new System.Drawing.Size(45, 19);
            this.preTaxYesRadioButton.TabIndex = 0;
            this.preTaxYesRadioButton.TabStop = true;
            this.preTaxYesRadioButton.Text = "Yes";
            this.preTaxYesRadioButton.UseVisualStyleBackColor = true;
            this.preTaxYesRadioButton.CheckedChanged += new System.EventHandler(this.preTaxYesRadioButton_CheckedChanged);
            // 
            // preTaxRadioButtonGroupLabel
            // 
            this.preTaxRadioButtonGroupLabel.AutoSize = true;
            this.preTaxRadioButtonGroupLabel.Font = new System.Drawing.Font("Imprint MT Shadow", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preTaxRadioButtonGroupLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.preTaxRadioButtonGroupLabel.Location = new System.Drawing.Point(394, 34);
            this.preTaxRadioButtonGroupLabel.Name = "preTaxRadioButtonGroupLabel";
            this.preTaxRadioButtonGroupLabel.Size = new System.Drawing.Size(186, 15);
            this.preTaxRadioButtonGroupLabel.TabIndex = 45;
            this.preTaxRadioButtonGroupLabel.Text = "Anything taken out before taxes?";
            // 
            // holidayAmountTextBox
            // 
            this.holidayAmountTextBox.Location = new System.Drawing.Point(194, 289);
            this.holidayAmountTextBox.Name = "holidayAmountTextBox";
            this.holidayAmountTextBox.Size = new System.Drawing.Size(45, 20);
            this.holidayAmountTextBox.TabIndex = 52;
            this.holidayAmountTextBox.Visible = false;
            // 
            // holidayAmountLabel
            // 
            this.holidayAmountLabel.AutoSize = true;
            this.holidayAmountLabel.Font = new System.Drawing.Font("Imprint MT Shadow", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.holidayAmountLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.holidayAmountLabel.Location = new System.Drawing.Point(12, 291);
            this.holidayAmountLabel.Name = "holidayAmountLabel";
            this.holidayAmountLabel.Size = new System.Drawing.Size(128, 15);
            this.holidayAmountLabel.TabIndex = 53;
            this.holidayAmountLabel.Text = "How Many Holidays?";
            this.holidayAmountLabel.Visible = false;
            // 
            // payCheckForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(852, 567);
            this.Controls.Add(this.holidayAmountTextBox);
            this.Controls.Add(this.holidayAmountLabel);
            this.Controls.Add(this.preTaxAmountTextBox);
            this.Controls.Add(this.preTaxPercentTextBox);
            this.Controls.Add(this.preTaxHowMuchLabel);
            this.Controls.Add(this.preTaxPerAmountGroupBox);
            this.Controls.Add(this.preTaxPerAmountLabel);
            this.Controls.Add(this.preTaxGroupBox);
            this.Controls.Add(this.preTaxRadioButtonGroupLabel);
            this.Controls.Add(this.stateComboBox);
            this.Controls.Add(this.stateLabel);
            this.Controls.Add(this.fillingStatusComboBox);
            this.Controls.Add(this.secHourBox);
            this.Controls.Add(this.hoursSecWorkedLabel);
            this.Controls.Add(this.garnishWholeAmountTextBox);
            this.Controls.Add(this.garnishPercentAmountTextBox);
            this.Controls.Add(this.garnishPercentAmountLabel);
            this.Controls.Add(this.garnishAmountGroupBox);
            this.Controls.Add(this.garnishAmountLabel);
            this.Controls.Add(this.singleMarriedLabel);
            this.Controls.Add(this.allowTextBox);
            this.Controls.Add(this.allowLabel);
            this.Controls.Add(this.garnishmentGroupBox);
            this.Controls.Add(this.garnishmentLabel);
            this.Controls.Add(this.ptoTextBox);
            this.Controls.Add(this.ptoAmountLabel);
            this.Controls.Add(this.ptoGroupBox);
            this.Controls.Add(this.ptoLabel);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.amountSavingTextBox);
            this.Controls.Add(this.amountComboBox);
            this.Controls.Add(this.amountPercentSavingsLabel);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.savingsTotalLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.garnishLabel);
            this.Controls.Add(this.preTaxLabel);
            this.Controls.Add(this.grossLabel);
            this.Controls.Add(this.holidayGroupBox);
            this.Controls.Add(this.savingsGroupBox);
            this.Controls.Add(this.percentSavingBox);
            this.Controls.Add(this.howMuchSavingLabel);
            this.Controls.Add(this.holidayPayLabel);
            this.Controls.Add(this.savingLabel);
            this.Controls.Add(this.calcButtonS);
            this.Controls.Add(this.firstHourBox);
            this.Controls.Add(this.hoursFirstWorkedLabel);
            this.Controls.Add(this.firstWeekLabel);
            this.Controls.Add(this.hoursBox);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "payCheckForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paycheck Application";
            this.holidayGroupBox.ResumeLayout(false);
            this.holidayGroupBox.PerformLayout();
            this.amountComboBox.ResumeLayout(false);
            this.amountComboBox.PerformLayout();
            this.ptoGroupBox.ResumeLayout(false);
            this.ptoGroupBox.PerformLayout();
            this.garnishmentGroupBox.ResumeLayout(false);
            this.garnishmentGroupBox.PerformLayout();
            this.garnishAmountGroupBox.ResumeLayout(false);
            this.garnishAmountGroupBox.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.savingsGroupBox.ResumeLayout(false);
            this.savingsGroupBox.PerformLayout();
            this.preTaxPerAmountGroupBox.ResumeLayout(false);
            this.preTaxPerAmountGroupBox.PerformLayout();
            this.preTaxGroupBox.ResumeLayout(false);
            this.preTaxGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox hoursBox;
        private System.Windows.Forms.Label firstWeekLabel;
        private System.Windows.Forms.Label hoursFirstWorkedLabel;
        private System.Windows.Forms.TextBox firstHourBox;
        private System.Windows.Forms.Button calcButtonS;
        private System.Windows.Forms.Label savingLabel;
        private System.Windows.Forms.Label holidayPayLabel;
        private System.Windows.Forms.Label howMuchSavingLabel;
        private System.Windows.Forms.TextBox percentSavingBox;
        private System.Windows.Forms.GroupBox holidayGroupBox;
        private System.Windows.Forms.RadioButton noHolidayRadioButton;
        private System.Windows.Forms.RadioButton yesHolidayRadioButton;
        private System.Windows.Forms.Label grossLabel;
        private System.Windows.Forms.Label preTaxLabel;
        private System.Windows.Forms.Label garnishLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label savingsTotalLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label amountPercentSavingsLabel;
        private System.Windows.Forms.GroupBox amountComboBox;
        private System.Windows.Forms.RadioButton amountSavingRadioButton;
        private System.Windows.Forms.RadioButton percentSavingsRadioButton;
        private System.Windows.Forms.TextBox amountSavingTextBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.GroupBox ptoGroupBox;
        private System.Windows.Forms.RadioButton yesPTO;
        private System.Windows.Forms.RadioButton noPTO;
        private System.Windows.Forms.Label ptoLabel;
        private System.Windows.Forms.TextBox ptoTextBox;
        private System.Windows.Forms.Label ptoAmountLabel;
        private System.Windows.Forms.GroupBox garnishmentGroupBox;
        private System.Windows.Forms.RadioButton garnishNoRadioButton;
        private System.Windows.Forms.RadioButton garnishYesRadioButton;
        private System.Windows.Forms.Label garnishmentLabel;
        private System.Windows.Forms.TextBox allowTextBox;
        private System.Windows.Forms.Label allowLabel;
        private System.Windows.Forms.Label singleMarriedLabel;
        private System.Windows.Forms.GroupBox garnishAmountGroupBox;
        private System.Windows.Forms.RadioButton garnishWholeAmountRadioButton;
        private System.Windows.Forms.RadioButton garnishPercentAmountRadioButton;
        private System.Windows.Forms.Label garnishAmountLabel;
        private System.Windows.Forms.TextBox garnishWholeAmountTextBox;
        private System.Windows.Forms.TextBox garnishPercentAmountTextBox;
        private System.Windows.Forms.Label garnishPercentAmountLabel;
        private System.Windows.Forms.TextBox secHourBox;
        private System.Windows.Forms.Label hoursSecWorkedLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem payPeriodToolStripMenuItem;
        private System.Windows.Forms.ComboBox fillingStatusComboBox;
        private System.Windows.Forms.ComboBox stateComboBox;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.RadioButton noSavingsRadioButton;
        private System.Windows.Forms.RadioButton yesSavingsRadioButton;
        private System.Windows.Forms.GroupBox savingsGroupBox;
        private System.Windows.Forms.TextBox preTaxAmountTextBox;
        private System.Windows.Forms.TextBox preTaxPercentTextBox;
        private System.Windows.Forms.Label preTaxHowMuchLabel;
        private System.Windows.Forms.GroupBox preTaxPerAmountGroupBox;
        private System.Windows.Forms.RadioButton preTaxAmountRadioButton;
        private System.Windows.Forms.RadioButton preTaxPercentRadioButton;
        private System.Windows.Forms.Label preTaxPerAmountLabel;
        private System.Windows.Forms.GroupBox preTaxGroupBox;
        private System.Windows.Forms.RadioButton preTaxNoRadioButton;
        private System.Windows.Forms.RadioButton preTaxYesRadioButton;
        private System.Windows.Forms.Label preTaxRadioButtonGroupLabel;
        private System.Windows.Forms.TextBox holidayAmountTextBox;
        private System.Windows.Forms.Label holidayAmountLabel;
    }
}