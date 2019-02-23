using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DynamicGym1Project
{
    class IntakeCalculator
    {
        // protein attribute
        private double WeightProtein { get; set; }

        // calorie attributes
        private double WeightCalorie { get; set; }
        private double Height { get; set; }
        private int Age { get; set; }
        private string Status { get; set; }

        // methods
        // protein calculator
        public string ProteinCalculator(double weight)
        {
            WeightProtein = weight;
            double intake = WeightProtein * 0.8f;
            intake = Math.Round(intake,2);
            return "Your daily protein \nintake is : "+intake+" Grams";
        }

        // calorie calculator
        public string CalorieCalculator(double weight, double height, int age, int status)
        {
            double value = 0;
            double calculate = 0;
            double intake = 0;
            WeightCalorie = weight;
            Height = height;
            Age = age;

            if (status == 1)
            {
                value = 1.375f;
            }

            if (status == 2)
            {
                value = 1.55f;
            }

            if (status == 3)
            {
                value = 1.725f;
            }

            if (status == 4)
            {
                value = 1.9f;
            }

            // calculate intake of calories
            double kg_lbs = 1 / 2.2f;
            double finalweight = WeightCalorie * kg_lbs;
            calculate = (6.25 * finalweight) + (12.7 * Height) - (6.8 * Convert.ToDouble(Age)) + 66;
            intake = calculate * value;
            intake = Math.Round(intake, 2);

            return "Your daily calorie \nintake is : "+intake+"\n Calories";
        }
    }
}
