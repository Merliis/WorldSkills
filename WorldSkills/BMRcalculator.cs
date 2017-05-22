using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorldSkills
{
    public partial class BMRcalculator : Form
    {
        public BMRcalculator()
        {
            InitializeComponent();
        }

        private void height_TextChanged(object sender, EventArgs e)
        {

        }

        private void weight_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void male_Click(object sender, EventArgs e)
        {
            male.FlatAppearance.BorderSize = 3;
            female.FlatAppearance.BorderSize = 1;
        }

        private void female_Click(object sender, EventArgs e)
        {
            male.FlatAppearance.BorderSize = 1;
            female.FlatAppearance.BorderSize = 3;
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void calc_Click(object sender, EventArgs e)
        {
            int intGrowth = Convert.ToInt32(height.Text);
            int intWeight = Convert.ToInt32(weight.Text);
            int intYears = Convert.ToInt32(textBox1.Text);
            double BMRmale;
            double BMRfemale;

            bool maleReturn = false, femaleReturn = false;

            if (male.FlatAppearance.BorderSize == 3)
            {
                maleReturn = true;
                BMRmale = 88.362 + (13.397 * intWeight) + (4.799 * intGrowth) - (5.677 * intYears);
                Minimum.Text = Convert.ToString(BMRmale * 1.2);
                Low.Text = Convert.ToString(BMRmale * 1.375);
                Average.Text = Convert.ToString(BMRmale * 1.55);
                Tall.Text = Convert.ToString(BMRmale * 1.725);
                VeryTall.Text = Convert.ToString(BMRmale * 1.9);
                label11.Text = Convert.ToString(BMRmale);
            }
            else
            {
                femaleReturn = true;
                BMRfemale = 447.593 + (9.247 + intWeight) + (3.098 * intGrowth) - (4.33 * intYears);
                Minimum.Text = Convert.ToString(BMRfemale * 1.2);
                Low.Text = Convert.ToString(BMRfemale * 1.375);
                Average.Text = Convert.ToString(BMRfemale * 1.55);
                Tall.Text = Convert.ToString(BMRfemale * 1.725);
                VeryTall.Text = Convert.ToString(BMRfemale * 1.9);
                label11.Text = Convert.ToString(BMRfemale);
            }

           





        }

        private void Minimum_Click(object sender, EventArgs e)
        {

        }

        private void Low_Click(object sender, EventArgs e)
        {

        }

        private void Average_Click(object sender, EventArgs e)
        {

        }

        private void Tall_Click(object sender, EventArgs e)
        {

        }

        private void VeryTall_Click(object sender, EventArgs e)
        {

        }
    }
}
