using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BMICalculator.BmrCalculator;

namespace BMICalculator
{
    public partial class MainForm : Form
    {
        private String name = String.Empty;
        private BMICalculator bmiCalculator = new BMICalculator();
        private Savingplan savingplan = new Savingplan();
        private BmrCalculator BmrCalculator = new BmrCalculator();


        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
        }

        public void InitializeGUI()
        {
            // task 1 BMI calculator
            // controls input 
            this.Text = "The Body Mass Calculator";

            // input Controls
            rbuttonMetric.Checked = true;
            HightLable.Text = "Height (cm)";
            WeightLable.Text = "Weight (kg)";

            // output controls
            HightText.Text = String.Empty;
            WeightText.Text = String.Empty;
            Normal_label2.Visible = false;


            // task 2 Saving plan

            // input controls

            textitInitialDepos.Text = String.Empty;
            textMonthlydepos.Text = String.Empty;
            textPeriod.Text = String.Empty;
            textGrowth.Text = String.Empty;
            textFees.Text = String.Empty;


            // task 3 BMR calculator

            // input controls
            Age_textBox.Text = String.Empty;
            Female_radioButton.Checked = true;
            Sedentary_radioButton1.Checked = true;

            // output controls
            R_BMR_listBox.Text = String.Empty;

        }




        #region Task1
        private void rbuttonUS_CheckedChanged(object sender, EventArgs e)
        {
            update_unit();
        }

        private void rbuttonMetric_CheckedChanged(object sender, EventArgs e)
        {

            update_unit();
        }


        private void update_unit()
        {
            if (rbuttonUS.Checked)
            {
                HightLable.Text = "Height (feet)";
                WeightLable.Text = "Weight (lbs)";
                Normal_label2.Text = "Normal weight should be between 111 and 150 lbs";
                ft_label.Visible = true;
                in_label1.Visible = true;
                in_textBox.Visible = true;
            }
            else
            {
                HightLable.Text = "Height (cm)";
                WeightLable.Text = "Weight (kg)";
                Normal_label2.Text = "Normal weight should be between 50 and 68 kg";
                ft_label.Visible = false;
                in_label1.Visible = false;
                in_textBox.Visible = false;
              
            }
        }

        private void Calculatorbotton_Click_1(object sender, EventArgs e)
        {

            // read the input from the user

            Name = NameText.Text.Trim();
            if (Name.Length == 0)
            {
                MessageBox.Show("Please enter your name", "Error");
                NameText.Focus();
                return;
            }
            else
            {
                ResultBox.Text = "Results for " + Name;
            }

            double height = 0;
            if (rbuttonUS.Checked)
            {
                if (!double.TryParse(HightText.Text, out double feet))
                {
                    MessageBox.Show("Please enter a valid height in feet", "Error");
                    HightText.Focus();
                    return;
                }

                if (!double.TryParse(in_textBox.Text, out double inches))
                {
                    MessageBox.Show("Please enter a valid height in inches", "Error");
                    in_textBox.Focus();
                    return;
                }

                height = (feet * 12) + inches;
            }
            else if (!double.TryParse(HightText.Text, out height))
            {
                MessageBox.Show("Please enter a valid height", "Error");
                HightText.Focus();
                return;
            }


            double weight = 0;
            if (!double.TryParse(WeightText.Text, out weight))
            {
                MessageBox.Show("Please enter a valid weight", "Error");
                WeightText.Focus();
                return;
            }


            // set the values in the BMI calculator

            bmiCalculator.SetName(Name);
            bmiCalculator.SetHeight(height);
            bmiCalculator.SetWeight(weight);

            if (rbuttonUS.Checked)
            {
                bmiCalculator.SetUnitType(UnitTypes.Imperial);
            }
            else
            {
                bmiCalculator.SetUnitType(UnitTypes.Metric);
            }

            // debug the input vaLUE 
            //Console.WriteLine("Name: " + bmiCalculator.GetName());
            //Console.WriteLine("Height: " + bmiCalculator.GetHeight());
            //Console.WriteLine("Weight: " + bmiCalculator.GetWeight());
            //Console.WriteLine("Unit Type: " + bmiCalculator.GetUnitType());
            //MessageBox.Show("Name: " + bmiCalculator.GetName() + "\n" + "Height: " + bmiCalculator.GetHeight() + "\n" + "Weight: " + bmiCalculator.GetWeight() + "\n" + "Unit Type: " + bmiCalculator.GetUnitType(), "Debug");

            // get BMI resulat and display it

            ResulatBMIlable.Text = bmiCalculator.CalculateBMI().ToString("F2");

            // get the weight resulat and display it
            weightResultoutputLable.Text = bmiCalculator.BMIWeightCategory();

            Normal_label2.Visible = true;










        }

        private void buttonCalculateSaving_Click(object sender, EventArgs e)
        {
            // input validation 

            double initialDeposit = 0;
            if (!double.TryParse(textitInitialDepos.Text, out initialDeposit))
            {
                MessageBox.Show("Please enter a valid initial deposit", "Error");
                textitInitialDepos.Focus();
                return;
            }

            double monthlySaving = 0;
            if (!double.TryParse(textMonthlydepos.Text, out monthlySaving))
            {
                MessageBox.Show("Please enter a valid monthly saving", "Error");
                textMonthlydepos.Focus();
                return;
            }

            int period = 0;
            if (!int.TryParse(textPeriod.Text, out period))
            {
                MessageBox.Show("Please enter a valid period", "Error");
                textPeriod.Focus();
                return;
            }

            double growth = 0;
            if (!double.TryParse(textGrowth.Text, out growth))
            {
                MessageBox.Show("Please enter a valid growth", "Error");
                textGrowth.Focus();
                return;
            }

            double fees = 0;
            if (!double.TryParse(textFees.Text, out fees))
            {
                MessageBox.Show("Please enter a valid fees", "Error");
                textFees.Focus();
                return;
            }

            // set the values in the saving plan

            Savingplan savingplan = new Savingplan();
            savingplan.InitialDeposit = initialDeposit;
            savingplan.MonthlySaving = monthlySaving;
            savingplan.Period = period;
            savingplan.Growth = growth;
            savingplan.Fees = fees;

            // get the result and display it


            RAmountpaidlabel.Text = savingplan.totalAmountPaid().ToString("F2");
            RAmountearnedlabel.Text = savingplan.AmountEarned().ToString("F2");
            RFinalbalancelabel.Text = savingplan.finalBalance().ToString("F2");
            RfeesTotallabel.Text = savingplan.TotalFees().ToString("F2");


        }
        private void CalculateBMR_button1_Click(object sender, EventArgs e)
        {
            // get the input from the user and validate it 
            // get the height, weight, age, activity group, name

            String name = NameText.Text.Trim();
            if (name.Length == 0)
            {
                // set the name as unknown if the user did not enter a name
                name = "Unknown";
            }

            if (!double.TryParse(WeightText.Text, out double weight))
            {
                MessageBox.Show("Please enter a valid weight", "Error");
                WeightText.Focus();
                return;
            }

            double height = 0;
            if (rbuttonUS.Checked)
            {
                if (!double.TryParse(HightText.Text, out double feet))
                {
                    MessageBox.Show("Please enter a valid height in feet", "Error");
                    HightText.Focus();
                    return;
                }

                if (!double.TryParse(in_textBox.Text, out double inches))
                {
                    MessageBox.Show("Please enter a valid height in inches", "Error");
                    in_textBox.Focus();
                    return;
                }

                height = (feet * 12) + inches;
            }else if (!double.TryParse(HightText.Text, out height))
            {
                MessageBox.Show("Please enter a valid height", "Error");
                HightText.Focus();
                return;
            }




            if (!int.TryParse(Age_textBox.Text, out int age))
            {
                MessageBox.Show("Please enter a valid age", "Error");
                Age_textBox.Focus();
                return;
            }

            // if all the input is valid then set the values in the BMR calculator

            // check if the input is in kg and cm or lbs and feet 
            BmrCalculator bmrCalculator = new BmrCalculator();
            if (rbuttonUS.Checked)
            {
                bmrCalculator.Weight = weight * 0.453592; // Convert lbs to kg
                bmrCalculator.Height = height * 2.54; // Convert feet to cm
            }
            else
            {
                bmrCalculator.Weight = weight; // Already in kg
                bmrCalculator.Height = height; // Already in cm
            }

            bmrCalculator.Age = age;

            bmrCalculator.Gender = Male_radioButton1.Checked ? GenderType.Male : GenderType.Female;

            // get the activity level and set it in the BMR calculator
            if (Sedentary_radioButton1.Checked)
            {
                bmrCalculator.Activity = ActivityLevel.Sedentary;
            }
            else if (Lightly_active_radioButton.Checked)
            {
                bmrCalculator.Activity = ActivityLevel.LightlyActive;
            }
            else if (Moderately_radioButton.Checked)
            {
                bmrCalculator.Activity = ActivityLevel.ModeratelyActive;
            }
            else if (Very_radioButton1.Checked)
            {
                bmrCalculator.Activity = ActivityLevel.VeryActive;
            }
            else // Assuming the last option is ExtraActive
            {
                bmrCalculator.Activity = ActivityLevel.ExtraActive;
            }

   

            // Clear existing items
            R_BMR_listBox.Items.Clear();
            R_BMR_listBox.Items.Add($"BMR RESULTS FOR {name.ToUpper()}");
            R_BMR_listBox.Items.Add("");
            R_BMR_listBox.Items.Add($"Your BMR (calories/day): {bmrCalculator.CalculateBmr().ToString("F1")}");
            R_BMR_listBox.Items.Add($"Calories to maintain your weight: {bmrCalculator.MaintainWeightBMRs().ToString("F1")}");
            R_BMR_listBox.Items.Add($"Calories to lose 0.5 kg per week: {bmrCalculator.CalculateDailyCaloriesForWeightManagement(-0.5).ToString("F1")}");
            R_BMR_listBox.Items.Add($"Calories to lose 1 kg per week: {bmrCalculator.CalculateDailyCaloriesForWeightManagement(-1.0).ToString("F1")}");
            R_BMR_listBox.Items.Add($"Calories to gain 0.5 kg per week: {bmrCalculator.CalculateDailyCaloriesForWeightManagement(0.5).ToString("F1")}");
            R_BMR_listBox.Items.Add($"Calories to gain 1 kg per week: {bmrCalculator.CalculateDailyCaloriesForWeightManagement(1.0).ToString("F1")}");
            R_BMR_listBox.Items.Add("");
            R_BMR_listBox.Items.Add("Losing more than 1000 calories per day is to be avoided.");
        }






        #endregion









        // read the input from the user



    }
}
