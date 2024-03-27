using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculator
{

    class BMICalculator
    {
        private String name = "No Name";
        private double weight = 0; // in kilograms
        private double height = 0; // in meters
        private UnitTypes unitType = UnitTypes.Imperial;



        public BMICalculator()
        {

            unitType = UnitTypes.Metric;
        }


        #region GETTERS AND SETTERS
        public String GetName()
        {
            return name;
        }

        public void SetName(String name)
        {
            if (!String.IsNullOrEmpty(name))
            {

                this.name = name;
            }
        }

        public double GetWeight()
        {
            return weight;
        }

        public void SetWeight(double weight)
        {
            if (weight > 0)
            {
                this.weight = weight;
            }
        }

        public double GetHeight()
        {
            return height;
        }

        public void SetHeight(double height)
        {
            if (height > 0)
            {
                this.height = height;
            }
        }

        public UnitTypes GetUnitType()
        {
            return unitType;
        }

        public void SetUnitType(UnitTypes unitType)
        {
            this.unitType = unitType;
        }

        #endregion




        public double CalculateBMI()
        {
            // Check the unit type
            if (unitType == UnitTypes.Imperial)
            {
                // Calculate BMI using Imperial units: 703 * (weight in lbs / (height in inches)^2)
                return 703.0 * weight / (height * height);
            }
            else // Metric units
            {
                // Convert height from cm to meters before calculation
                double heightInMeters = height / 100.0;
                // Calculate BMI using Metric units: weight in kg / (height in meters)^2
                return weight / (heightInMeters * heightInMeters);
            }
        }


        public String BMIWeightCategory()
        {
            double bmi = CalculateBMI();
            
            string result = "";

             if (bmi < 18.5)
            {
           result = "Underweight";
            }
            else if (bmi < 24.9)
            {
                result = "Normal weight";
                }
            else if (bmi < 29.9)
            {
                result = "Overweight (Pre-obesity)";
            }
             else if (bmi < 34.9)
            {
                result = "Overweight  Obesity class I";
            }
             else if (bmi < 39.9)
            {
                result = "Overweight  Obesity class II";
            }
             else if (bmi >= 40)
            {
                result = "Overweight  Obesity class III";
            }
   
            return result;

        }
    }



}
