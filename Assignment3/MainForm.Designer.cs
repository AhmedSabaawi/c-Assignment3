namespace BMICalculator
{
    partial class MainForm
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

        private void InitializeComponent()
        {
            NameLable = new Label();
            HightLable = new Label();
            WeightLable = new Label();
            NameText = new TextBox();
            HightText = new TextBox();
            WeightText = new TextBox();
            UnitTypeBox = new GroupBox();
            rbuttonUS = new RadioButton();
            rbuttonMetric = new RadioButton();
            Calculatorbotton = new Button();
            ResultBox = new GroupBox();
            weightResultoutputLable = new Label();
            ResulatBMIlable = new Label();
            weightResultLable = new Label();
            BMIResultLable = new Label();
            SavingPlanBox = new GroupBox();
            buttonCalculateSaving = new Button();
            textFees = new TextBox();
            textGrowth = new TextBox();
            textPeriod = new TextBox();
            textMonthlydepos = new TextBox();
            textitInitialDepos = new TextBox();
            Feeslabel = new Label();
            Growthlabel = new Label();
            Periodlable = new Label();
            Monthlydeposlabel = new Label();
            itInitialDeposLable = new Label();
            groupBox1 = new GroupBox();
            RfeesTotallabel = new Label();
            RFinalbalancelabel = new Label();
            RAmountpaidlabel = new Label();
            RAmountearnedlabel = new Label();
            feesTotallabel = new Label();
            Finalbalancelabel = new Label();
            Amountpaidlabel = new Label();
            Amountearnedlabel = new Label();
            groupBox2 = new GroupBox();
            R_BMR_listBox = new ListBox();
            CalculateBMR_button1 = new Button();
            Age_textBox = new TextBox();
            Agelabel1 = new Label();
            groupBox4 = new GroupBox();
            Extra_radioButton1 = new RadioButton();
            Very_radioButton1 = new RadioButton();
            Moderately_radioButton = new RadioButton();
            Lightly_active_radioButton = new RadioButton();
            Sedentary_radioButton1 = new RadioButton();
            groupBox3 = new GroupBox();
            Male_radioButton1 = new RadioButton();
            Female_radioButton = new RadioButton();
            ft_label = new Label();
            in_textBox = new TextBox();
            in_label1 = new Label();
            Normal_label1 = new Label();
            Normal_label2 = new Label();
            UnitTypeBox.SuspendLayout();
            ResultBox.SuspendLayout();
            SavingPlanBox.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // NameLable
            // 
            NameLable.AutoSize = true;
            NameLable.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            NameLable.Location = new Point(12, 31);
            NameLable.Name = "NameLable";
            NameLable.Size = new Size(51, 20);
            NameLable.TabIndex = 0;
            NameLable.Text = "Name";
            // 
            // HightLable
            // 
            HightLable.AutoSize = true;
            HightLable.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            HightLable.Location = new Point(12, 77);
            HightLable.Name = "HightLable";
            HightLable.Size = new Size(93, 20);
            HightLable.TabIndex = 1;
            HightLable.Text = "Height (cm)";
            // 
            // WeightLable
            // 
            WeightLable.AutoSize = true;
            WeightLable.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            WeightLable.Location = new Point(12, 128);
            WeightLable.Name = "WeightLable";
            WeightLable.Size = new Size(93, 20);
            WeightLable.TabIndex = 2;
            WeightLable.Text = "Weight (kg)";
            // 
            // NameText
            // 
            NameText.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            NameText.Location = new Point(127, 31);
            NameText.Name = "NameText";
            NameText.Size = new Size(477, 27);
            NameText.TabIndex = 3;
            // 
            // HightText
            // 
            HightText.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            HightText.Location = new Point(127, 78);
            HightText.Name = "HightText";
            HightText.Size = new Size(58, 27);
            HightText.TabIndex = 4;
            // 
            // WeightText
            // 
            WeightText.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            WeightText.Location = new Point(127, 125);
            WeightText.Name = "WeightText";
            WeightText.Size = new Size(58, 27);
            WeightText.TabIndex = 5;
            // 
            // UnitTypeBox
            // 
            UnitTypeBox.Controls.Add(rbuttonUS);
            UnitTypeBox.Controls.Add(rbuttonMetric);
            UnitTypeBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            UnitTypeBox.Location = new Point(341, 74);
            UnitTypeBox.Name = "UnitTypeBox";
            UnitTypeBox.Size = new Size(263, 120);
            UnitTypeBox.TabIndex = 6;
            UnitTypeBox.TabStop = false;
            UnitTypeBox.Text = "Unit";
            // 
            // rbuttonUS
            // 
            rbuttonUS.AutoSize = true;
            rbuttonUS.Location = new Point(6, 70);
            rbuttonUS.Name = "rbuttonUS";
            rbuttonUS.Size = new Size(157, 24);
            rbuttonUS.TabIndex = 8;
            rbuttonUS.TabStop = true;
            rbuttonUS.Text = "US Unit (foot, lbs)";
            rbuttonUS.UseVisualStyleBackColor = true;
            // 
            // rbuttonMetric
            // 
            rbuttonMetric.AutoSize = true;
            rbuttonMetric.Location = new Point(6, 26);
            rbuttonMetric.Name = "rbuttonMetric";
            rbuttonMetric.Size = new Size(167, 24);
            rbuttonMetric.TabIndex = 7;
            rbuttonMetric.TabStop = true;
            rbuttonMetric.Text = "Metric Unit (kg cm)";
            rbuttonMetric.UseVisualStyleBackColor = true;
            rbuttonMetric.CheckedChanged += rbuttonMetric_CheckedChanged;
            // 
            // Calculatorbotton
            // 
            Calculatorbotton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Calculatorbotton.Location = new Point(196, 200);
            Calculatorbotton.Name = "Calculatorbotton";
            Calculatorbotton.Size = new Size(258, 60);
            Calculatorbotton.TabIndex = 7;
            Calculatorbotton.Text = "Calculate";
            Calculatorbotton.UseVisualStyleBackColor = true;
            Calculatorbotton.Click += Calculatorbotton_Click_1;
            // 
            // ResultBox
            // 
            ResultBox.Controls.Add(Normal_label2);
            ResultBox.Controls.Add(Normal_label1);
            ResultBox.Controls.Add(weightResultoutputLable);
            ResultBox.Controls.Add(ResulatBMIlable);
            ResultBox.Controls.Add(weightResultLable);
            ResultBox.Controls.Add(BMIResultLable);
            ResultBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ResultBox.Location = new Point(26, 266);
            ResultBox.Name = "ResultBox";
            ResultBox.Size = new Size(653, 298);
            ResultBox.TabIndex = 8;
            ResultBox.TabStop = false;
            ResultBox.Text = "Results for";
            // 
            // weightResultoutputLable
            // 
            weightResultoutputLable.BorderStyle = BorderStyle.Fixed3D;
            weightResultoutputLable.Location = new Point(356, 146);
            weightResultoutputLable.Name = "weightResultoutputLable";
            weightResultoutputLable.Size = new Size(253, 38);
            weightResultoutputLable.TabIndex = 5;
            // 
            // ResulatBMIlable
            // 
            ResulatBMIlable.BorderStyle = BorderStyle.Fixed3D;
            ResulatBMIlable.Location = new Point(521, 54);
            ResulatBMIlable.Name = "ResulatBMIlable";
            ResulatBMIlable.Size = new Size(88, 20);
            ResulatBMIlable.TabIndex = 4;
            // 
            // weightResultLable
            // 
            weightResultLable.Location = new Point(19, 146);
            weightResultLable.Name = "weightResultLable";
            weightResultLable.Size = new Size(88, 20);
            weightResultLable.TabIndex = 3;
            weightResultLable.Text = "Weight Category";
            // 
            // BMIResultLable
            // 
            BMIResultLable.Location = new Point(19, 54);
            BMIResultLable.Name = "BMIResultLable";
            BMIResultLable.Size = new Size(88, 20);
            BMIResultLable.TabIndex = 2;
            BMIResultLable.Text = "Your BMI";
            // 
            // SavingPlanBox
            // 
            SavingPlanBox.Controls.Add(buttonCalculateSaving);
            SavingPlanBox.Controls.Add(textFees);
            SavingPlanBox.Controls.Add(textGrowth);
            SavingPlanBox.Controls.Add(textPeriod);
            SavingPlanBox.Controls.Add(textMonthlydepos);
            SavingPlanBox.Controls.Add(textitInitialDepos);
            SavingPlanBox.Controls.Add(Feeslabel);
            SavingPlanBox.Controls.Add(Growthlabel);
            SavingPlanBox.Controls.Add(Periodlable);
            SavingPlanBox.Controls.Add(Monthlydeposlabel);
            SavingPlanBox.Controls.Add(itInitialDeposLable);
            SavingPlanBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            SavingPlanBox.Location = new Point(733, 12);
            SavingPlanBox.Name = "SavingPlanBox";
            SavingPlanBox.Size = new Size(595, 355);
            SavingPlanBox.TabIndex = 9;
            SavingPlanBox.TabStop = false;
            SavingPlanBox.Text = "Saving plan";
            // 
            // buttonCalculateSaving
            // 
            buttonCalculateSaving.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonCalculateSaving.Location = new Point(168, 282);
            buttonCalculateSaving.Name = "buttonCalculateSaving";
            buttonCalculateSaving.Size = new Size(326, 58);
            buttonCalculateSaving.TabIndex = 10;
            buttonCalculateSaving.Text = "Calculate saving";
            buttonCalculateSaving.UseVisualStyleBackColor = true;
            buttonCalculateSaving.Click += buttonCalculateSaving_Click;
            // 
            // textFees
            // 
            textFees.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            textFees.Location = new Point(278, 233);
            textFees.Name = "textFees";
            textFees.Size = new Size(311, 27);
            textFees.TabIndex = 9;
            // 
            // textGrowth
            // 
            textGrowth.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            textGrowth.Location = new Point(278, 185);
            textGrowth.Name = "textGrowth";
            textGrowth.Size = new Size(311, 27);
            textGrowth.TabIndex = 8;
            // 
            // textPeriod
            // 
            textPeriod.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            textPeriod.Location = new Point(278, 141);
            textPeriod.Name = "textPeriod";
            textPeriod.Size = new Size(311, 27);
            textPeriod.TabIndex = 7;
            // 
            // textMonthlydepos
            // 
            textMonthlydepos.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            textMonthlydepos.Location = new Point(278, 93);
            textMonthlydepos.Name = "textMonthlydepos";
            textMonthlydepos.Size = new Size(311, 27);
            textMonthlydepos.TabIndex = 6;
            // 
            // textitInitialDepos
            // 
            textitInitialDepos.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            textitInitialDepos.Location = new Point(278, 49);
            textitInitialDepos.Name = "textitInitialDepos";
            textitInitialDepos.Size = new Size(311, 27);
            textitInitialDepos.TabIndex = 5;
            // 
            // Feeslabel
            // 
            Feeslabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Feeslabel.Location = new Point(30, 233);
            Feeslabel.Name = "Feeslabel";
            Feeslabel.Size = new Size(202, 27);
            Feeslabel.TabIndex = 4;
            Feeslabel.Text = "Fees in  %";
            // 
            // Growthlabel
            // 
            Growthlabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Growthlabel.Location = new Point(30, 188);
            Growthlabel.Name = "Growthlabel";
            Growthlabel.Size = new Size(202, 27);
            Growthlabel.TabIndex = 3;
            Growthlabel.Text = "Growth in (or interest)  %";
            // 
            // Periodlable
            // 
            Periodlable.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Periodlable.Location = new Point(30, 144);
            Periodlable.Name = "Periodlable";
            Periodlable.Size = new Size(179, 27);
            Periodlable.TabIndex = 2;
            Periodlable.Text = "Period (years)";
            // 
            // Monthlydeposlabel
            // 
            Monthlydeposlabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Monthlydeposlabel.Location = new Point(30, 96);
            Monthlydeposlabel.Name = "Monthlydeposlabel";
            Monthlydeposlabel.Size = new Size(179, 27);
            Monthlydeposlabel.TabIndex = 1;
            Monthlydeposlabel.Text = "Monthly depos";
            // 
            // itInitialDeposLable
            // 
            itInitialDeposLable.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            itInitialDeposLable.Location = new Point(30, 49);
            itInitialDeposLable.Name = "itInitialDeposLable";
            itInitialDeposLable.Size = new Size(179, 27);
            itInitialDeposLable.TabIndex = 0;
            itInitialDeposLable.Text = "itInitial depos";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(RfeesTotallabel);
            groupBox1.Controls.Add(RFinalbalancelabel);
            groupBox1.Controls.Add(RAmountpaidlabel);
            groupBox1.Controls.Add(RAmountearnedlabel);
            groupBox1.Controls.Add(feesTotallabel);
            groupBox1.Controls.Add(Finalbalancelabel);
            groupBox1.Controls.Add(Amountpaidlabel);
            groupBox1.Controls.Add(Amountearnedlabel);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox1.Location = new Point(733, 373);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(627, 228);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "valueFuture";
            // 
            // RfeesTotallabel
            // 
            RfeesTotallabel.BorderStyle = BorderStyle.Fixed3D;
            RfeesTotallabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            RfeesTotallabel.Location = new Point(339, 180);
            RfeesTotallabel.Name = "RfeesTotallabel";
            RfeesTotallabel.Size = new Size(179, 27);
            RfeesTotallabel.TabIndex = 18;
            // 
            // RFinalbalancelabel
            // 
            RFinalbalancelabel.BorderStyle = BorderStyle.Fixed3D;
            RFinalbalancelabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            RFinalbalancelabel.Location = new Point(339, 136);
            RFinalbalancelabel.Name = "RFinalbalancelabel";
            RFinalbalancelabel.Size = new Size(179, 27);
            RFinalbalancelabel.TabIndex = 17;
            // 
            // RAmountpaidlabel
            // 
            RAmountpaidlabel.BorderStyle = BorderStyle.Fixed3D;
            RAmountpaidlabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            RAmountpaidlabel.Location = new Point(339, 41);
            RAmountpaidlabel.Name = "RAmountpaidlabel";
            RAmountpaidlabel.Size = new Size(179, 27);
            RAmountpaidlabel.TabIndex = 15;
            // 
            // RAmountearnedlabel
            // 
            RAmountearnedlabel.BorderStyle = BorderStyle.Fixed3D;
            RAmountearnedlabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            RAmountearnedlabel.Location = new Point(339, 88);
            RAmountearnedlabel.Name = "RAmountearnedlabel";
            RAmountearnedlabel.Size = new Size(179, 27);
            RAmountearnedlabel.TabIndex = 16;
            // 
            // feesTotallabel
            // 
            feesTotallabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            feesTotallabel.Location = new Point(17, 180);
            feesTotallabel.Name = "feesTotallabel";
            feesTotallabel.Size = new Size(202, 27);
            feesTotallabel.TabIndex = 14;
            feesTotallabel.Text = "feesTotal";
            // 
            // Finalbalancelabel
            // 
            Finalbalancelabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Finalbalancelabel.Location = new Point(17, 136);
            Finalbalancelabel.Name = "Finalbalancelabel";
            Finalbalancelabel.Size = new Size(179, 27);
            Finalbalancelabel.TabIndex = 13;
            Finalbalancelabel.Text = "Final balance";
            // 
            // Amountpaidlabel
            // 
            Amountpaidlabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Amountpaidlabel.Location = new Point(17, 41);
            Amountpaidlabel.Name = "Amountpaidlabel";
            Amountpaidlabel.Size = new Size(179, 27);
            Amountpaidlabel.TabIndex = 11;
            Amountpaidlabel.Text = "Amount paid";
            // 
            // Amountearnedlabel
            // 
            Amountearnedlabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Amountearnedlabel.Location = new Point(17, 88);
            Amountearnedlabel.Name = "Amountearnedlabel";
            Amountearnedlabel.Size = new Size(179, 27);
            Amountearnedlabel.TabIndex = 12;
            Amountearnedlabel.Text = "Amount earned";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(R_BMR_listBox);
            groupBox2.Controls.Add(CalculateBMR_button1);
            groupBox2.Controls.Add(Age_textBox);
            groupBox2.Controls.Add(Agelabel1);
            groupBox2.Controls.Add(groupBox4);
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox2.Location = new Point(26, 607);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1062, 395);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "BMR Calculator";
            // 
            // R_BMR_listBox
            // 
            R_BMR_listBox.ForeColor = Color.Lime;
            R_BMR_listBox.FormattingEnabled = true;
            R_BMR_listBox.Location = new Point(575, 35);
            R_BMR_listBox.Name = "R_BMR_listBox";
            R_BMR_listBox.Size = new Size(502, 324);
            R_BMR_listBox.TabIndex = 5;
            // 
            // CalculateBMR_button1
            // 
            CalculateBMR_button1.Location = new Point(42, 294);
            CalculateBMR_button1.Name = "CalculateBMR_button1";
            CalculateBMR_button1.Size = new Size(420, 53);
            CalculateBMR_button1.TabIndex = 4;
            CalculateBMR_button1.Text = "Calculate BMR";
            CalculateBMR_button1.UseVisualStyleBackColor = true;
            CalculateBMR_button1.Click += CalculateBMR_button1_Click;
            // 
            // Age_textBox
            // 
            Age_textBox.Location = new Point(90, 225);
            Age_textBox.Name = "Age_textBox";
            Age_textBox.Size = new Size(69, 27);
            Age_textBox.TabIndex = 3;
            // 
            // Agelabel1
            // 
            Agelabel1.AutoSize = true;
            Agelabel1.Location = new Point(19, 228);
            Agelabel1.Name = "Agelabel1";
            Agelabel1.Size = new Size(37, 20);
            Agelabel1.TabIndex = 2;
            Agelabel1.Text = "Age";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(Extra_radioButton1);
            groupBox4.Controls.Add(Very_radioButton1);
            groupBox4.Controls.Add(Moderately_radioButton);
            groupBox4.Controls.Add(Lightly_active_radioButton);
            groupBox4.Controls.Add(Sedentary_radioButton1);
            groupBox4.Location = new Point(220, 33);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(305, 215);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            groupBox4.Text = "Weekly activity level";
            // 
            // Extra_radioButton1
            // 
            Extra_radioButton1.AutoSize = true;
            Extra_radioButton1.Location = new Point(10, 163);
            Extra_radioButton1.Name = "Extra_radioButton1";
            Extra_radioButton1.Size = new Size(263, 24);
            Extra_radioButton1.TabIndex = 4;
            Extra_radioButton1.TabStop = true;
            Extra_radioButton1.Text = "Extra active, hard exercises or job";
            Extra_radioButton1.UseVisualStyleBackColor = true;
            // 
            // Very_radioButton1
            // 
            Very_radioButton1.AutoSize = true;
            Very_radioButton1.Location = new Point(10, 133);
            Very_radioButton1.Name = "Very_radioButton1";
            Very_radioButton1.Size = new Size(196, 24);
            Very_radioButton1.TabIndex = 3;
            Very_radioButton1.TabStop = true;
            Very_radioButton1.Text = "Very active(6 to 7 time)";
            Very_radioButton1.UseVisualStyleBackColor = true;
            // 
            // Moderately_radioButton
            // 
            Moderately_radioButton.AutoSize = true;
            Moderately_radioButton.Location = new Point(10, 102);
            Moderately_radioButton.Name = "Moderately_radioButton";
            Moderately_radioButton.Size = new Size(248, 24);
            Moderately_radioButton.TabIndex = 2;
            Moderately_radioButton.TabStop = true;
            Moderately_radioButton.Text = "Moderately active (3 to 5 time)";
            Moderately_radioButton.UseVisualStyleBackColor = true;
            // 
            // Lightly_active_radioButton
            // 
            Lightly_active_radioButton.AutoSize = true;
            Lightly_active_radioButton.Location = new Point(10, 72);
            Lightly_active_radioButton.Name = "Lightly_active_radioButton";
            Lightly_active_radioButton.Size = new Size(180, 24);
            Lightly_active_radioButton.TabIndex = 1;
            Lightly_active_radioButton.TabStop = true;
            Lightly_active_radioButton.Text = "Lightly active (1 to 3)";
            Lightly_active_radioButton.UseVisualStyleBackColor = true;
            // 
            // Sedentary_radioButton1
            // 
            Sedentary_radioButton1.AutoSize = true;
            Sedentary_radioButton1.Location = new Point(10, 42);
            Sedentary_radioButton1.Name = "Sedentary_radioButton1";
            Sedentary_radioButton1.Size = new Size(250, 24);
            Sedentary_radioButton1.TabIndex = 0;
            Sedentary_radioButton1.TabStop = true;
            Sedentary_radioButton1.Text = "Sedentary (little or no exercise)";
            Sedentary_radioButton1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(Male_radioButton1);
            groupBox3.Controls.Add(Female_radioButton);
            groupBox3.Location = new Point(19, 32);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(150, 158);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Gender";
            // 
            // Male_radioButton1
            // 
            Male_radioButton1.AutoSize = true;
            Male_radioButton1.Location = new Point(30, 98);
            Male_radioButton1.Name = "Male_radioButton1";
            Male_radioButton1.Size = new Size(64, 24);
            Male_radioButton1.TabIndex = 1;
            Male_radioButton1.TabStop = true;
            Male_radioButton1.Text = "Male";
            Male_radioButton1.UseVisualStyleBackColor = true;
            // 
            // Female_radioButton
            // 
            Female_radioButton.AutoSize = true;
            Female_radioButton.Location = new Point(30, 47);
            Female_radioButton.Name = "Female_radioButton";
            Female_radioButton.Size = new Size(80, 24);
            Female_radioButton.TabIndex = 0;
            Female_radioButton.TabStop = true;
            Female_radioButton.Text = "Female";
            Female_radioButton.UseVisualStyleBackColor = true;
            // 
            // ft_label
            // 
            ft_label.AutoSize = true;
            ft_label.Location = new Point(191, 81);
            ft_label.Name = "ft_label";
            ft_label.Size = new Size(19, 20);
            ft_label.TabIndex = 12;
            ft_label.Text = "ft";
            ft_label.Visible = false;
            // 
            // in_textBox
            // 
            in_textBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            in_textBox.Location = new Point(225, 78);
            in_textBox.Name = "in_textBox";
            in_textBox.Size = new Size(58, 27);
            in_textBox.TabIndex = 13;
            in_textBox.Visible = false;
            // 
            // in_label1
            // 
            in_label1.AutoSize = true;
            in_label1.Location = new Point(302, 81);
            in_label1.Name = "in_label1";
            in_label1.Size = new Size(21, 20);
            in_label1.TabIndex = 14;
            in_label1.Text = "in";
            in_label1.Visible = false;
            // 
            // Normal_label1
            // 
            Normal_label1.Location = new Point(330, 208);
            Normal_label1.Name = "Normal_label1";
            Normal_label1.Size = new Size(296, 25);
            Normal_label1.TabIndex = 6;
            Normal_label1.Text = "Normal BMI is between18.50 and 24.9";
            // 
            // Normal_label2
            // 
            Normal_label2.ForeColor = Color.FromArgb(128, 255, 128);
            Normal_label2.Location = new Point(250, 243);
            Normal_label2.Name = "Normal_label2";
            Normal_label2.Size = new Size(359, 25);
            Normal_label2.TabIndex = 7;
            Normal_label2.Text = "Normal weight should be between 111 and 150 lbs";
            Normal_label2.Visible = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            ClientSize = new Size(1387, 1055);
            Controls.Add(in_label1);
            Controls.Add(in_textBox);
            Controls.Add(ft_label);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(SavingPlanBox);
            Controls.Add(ResultBox);
            Controls.Add(Calculatorbotton);
            Controls.Add(UnitTypeBox);
            Controls.Add(WeightText);
            Controls.Add(HightText);
            Controls.Add(NameText);
            Controls.Add(WeightLable);
            Controls.Add(HightLable);
            Controls.Add(NameLable);
            Name = "MainForm";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "Body Mass Index";
            WindowState = FormWindowState.Maximized;
            UnitTypeBox.ResumeLayout(false);
            UnitTypeBox.PerformLayout();
            ResultBox.ResumeLayout(false);
            SavingPlanBox.ResumeLayout(false);
            SavingPlanBox.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label NameLable;
        private Label HightLable;
        private Label WeightLable;
        private TextBox NameText;
        private TextBox HightText;
        private TextBox WeightText;
        private GroupBox UnitTypeBox;
        private RadioButton rbuttonUS;
        private RadioButton rbuttonMetric;
        private Button Calculatorbotton;
        private GroupBox ResultBox;
        private Label weightResultoutputLable;
        private Label ResulatBMIlable;
        private Label weightResultLable;
        private Label BMIResultLable;
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>


        #endregion

        private GroupBox SavingPlanBox;
        private Label itInitialDeposLable;
        private Label Monthlydeposlabel;
        private Label Periodlable;
        private Label Feeslabel;
        private Label Growthlabel;
        private TextBox textFees;
        private TextBox textGrowth;
        private TextBox textPeriod;
        private TextBox textMonthlydepos;
        private TextBox textitInitialDepos;
        private Button buttonCalculateSaving;
        private GroupBox groupBox1;
        private Label RfeesTotallabel;
        private Label RFinalbalancelabel;
        private Label RAmountpaidlabel;
        private Label RAmountearnedlabel;
        private Label feesTotallabel;
        private Label Finalbalancelabel;
        private Label Amountpaidlabel;
        private Label Amountearnedlabel;
        private GroupBox groupBox2;
        private GroupBox groupBox4;
        private RadioButton Lightly_active_radioButton;
        private RadioButton Sedentary_radioButton1;
        private GroupBox groupBox3;
        private RadioButton Male_radioButton1;
        private RadioButton Female_radioButton;
        private RadioButton Moderately_radioButton;
        private ListBox R_BMR_listBox;
        private Button CalculateBMR_button1;
        private TextBox Age_textBox;
        private Label Agelabel1;
        private RadioButton Extra_radioButton1;
        private RadioButton Very_radioButton1;
        private Label ft_label;
        private TextBox in_textBox;
        private Label in_label1;
        private Label Normal_label2;
        private Label Normal_label1;
    }
}