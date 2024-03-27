using System;

namespace BMICalculator
{
    public enum GenderType
    {
        Female,
        Male
    }

    public enum ActivityLevel
    {
        Sedentary,
        LightlyActive,
        ModeratelyActive,
        VeryActive,
        ExtraActive
    }

    public class BmrCalculator
    {
        private double weight;
        private double height;
        private int age;
        private GenderType gender;
        private ActivityLevel activity = ActivityLevel.Sedentary;

        private readonly double[] activityFactors = { 1.2, 1.375, 1.550, 1.725, 1.9 };

        public double Weight
        {
            get => weight;
            set
            {
                if (value < 0) throw new ArgumentException("Weight must be non-negative.");
                weight = value;
            }
        }

        public double Height
        {
            get => height;
            set
            {
                if (value < 0) throw new ArgumentException("Height must be non-negative.");
                height = value;
            }
        }

        public int Age
        {
            get => age;
            set
            {
                if (value < 0) throw new ArgumentException("Age must be non-negative.");
                age = value;
            }
        }

        public GenderType Gender
        {
            get => gender;
            set => gender = value;
        }

        public ActivityLevel Activity
        {
            get => activity;
            set => activity = value;
        }

        public double CalculateBmr()
        {
            double bmr = (10 * Weight) + (6.25 * Height) - (5 * Age);
            return Gender == GenderType.Male ? bmr + 5 : bmr - 161;
        }

        public double MaintainWeightBMRs()
        {
            return CalculateBmr() * activityFactors[(int)Activity];
        }

        public double CalculateDailyCaloriesForWeightManagement(double weightChangePerWeekKg)
        {
            double maintainBMRs = MaintainWeightBMRs();
            double dailyCalorieAdjustment = weightChangePerWeekKg * 1000 / 7;
            return maintainBMRs + dailyCalorieAdjustment;
        }
    }
}
