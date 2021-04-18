using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
            error.Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void height_TextChanged(object sender, EventArgs e)
        {

        }

        private void weight_TextChanged(object sender, EventArgs e)
        {

        }

        private void age_TextChanged(object sender, EventArgs e)
        {

        }

        private void calories_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            error.Visible = false;
            if(weight.Text.ToString() != "" && height.Text.ToString() != ""
                && age.Text.ToString() != "" && activity.Text !="Select Level")
            {
                double height_, weight_;

                //gets height from textbox & converts into double.
                double.TryParse(height.Text.ToString(), out height_);
                //gets weight from textbox & converts into double.
                double.TryParse(weight.Text.ToString(), out weight_);
                //gets age from textbox & converts into integer.
                int age_ = Int32.Parse(age.Text.ToString());

                //selects the checked radio button & stores value into a string variable.
                string value = "";
                bool isChecked = male.Checked;
                if (isChecked)
                {
                    value = male.Text.ToString();
                    //this function call returns the activity_level
                    string activity_level = activity.Text.ToString();
                    double calories = calculate_BMR(activity_level, value, age_, height_, weight_);

                    string Calories_in_string = calories.ToString();
                    caloriesbox.Text = Calories_in_string;
                }
                else
                {
                    value = female.Text.ToString();
                    //this function call returns the activity_level
                    string activity_level = activity.Text.ToString();
                    double calories = calculate_BMR(activity_level, value, age_, height_, weight_);

                    string Calories_in_string = calories.ToString();
                    caloriesbox.Text = Calories_in_string;
                }
            }
            else
            {
                error.Visible = true;
            }
        }

        public double calculate_BMR(string activity_, string value, int age, double h, double w)
        {
            double BMR = 0.0;
            double Calories = 0.0;
            if (value == "Male")
            {
                double activity_value = check_Activity(activity_);
                BMR = (w * 10) + (6.25 * h) - (5 * age) + 5;
                Calories = BMR * activity_value;
            }
            else
            {
                double activity_value = check_Activity(activity_);
                BMR = (w * 10) + (6.25 * h) - (5 * age) + 161;
                Calories = BMR * activity_value;
            }

            return Calories/1000;
        }

        public double check_Activity(string val)
        {
            //int activity_value= Int32.Parse(val);
            if(val == "High")
            {
                return 1.7;
            }
            else if(val == "Normal")
            {
                return 1.5;
            }
            else
            {
                return 1.3;
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            height.Text = "";
            weight.Text = "";
            caloriesbox.Text = "";
            activity.Text = "";
            age.Text = "";
            error.Visible = false;
        }
    }
}
