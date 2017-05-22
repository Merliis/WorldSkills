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
            if (male.FlatAppearance.BorderSize == 3 || female.FlatAppearance.BorderSize == 3 && height.Text != "" && weight.Text != "" && textBox1.Text != "")
            {
                int intGrowth = Convert.ToInt32(height.Text);
                int intWeight = Convert.ToInt32(weight.Text);
                int intYears = Convert.ToInt32(textBox1.Text);
                double BMRmale;
                double BMRfemale;


                if (male.FlatAppearance.BorderSize == 3)
                {
                    BMRmale = 88.362 + (13.397 * intWeight) + (4.799 * intGrowth) - (5.677 * intYears);
                    Minimum.Text = Convert.ToString(Math.Round(BMRmale * 1.2, 3));
                    Low.Text = Convert.ToString(Math.Round(BMRmale * 1.375, 3));
                    Average.Text = Convert.ToString(Math.Round(BMRmale * 1.55, 3));
                    Tall.Text = Convert.ToString(Math.Round(BMRmale * 1.725, 3));
                    VeryTall.Text = Convert.ToString(Math.Round(BMRmale * 1.9, 3));
                    label11.Text = Convert.ToString(Math.Round(BMRmale, 3));
                }
                else
                {
                    BMRfemale = 447.593 + (9.247 + intWeight) + (3.098 * intGrowth) - (4.33 * intYears);
                    Minimum.Text = Convert.ToString(Math.Round(BMRfemale * 1.2, 3));
                    Low.Text = Convert.ToString(Math.Round(BMRfemale * 1.375, 3));
                    Average.Text = Convert.ToString(Math.Round(BMRfemale * 1.55, 3));
                    Tall.Text = Convert.ToString(Math.Round(BMRfemale * 1.725, 3));
                    VeryTall.Text = Convert.ToString(Math.Round(BMRfemale * 1.9, 3));
                    label11.Text = Convert.ToString(Math.Round(BMRfemale, 3));
                }
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

        private void label7_Click(object sender, EventArgs e)
        {
            
        }

        private void BMRcalculator_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(label7, "Рассчитайте, сколько энергии в калориях необходимо потреблять вашему организму \nв состоянии покоя для обеспечения всех жизненных процессов");
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void BMRcalculator_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void backToMainMenu_Click(object sender, EventArgs e)
        {
            MainMenu pg1 = new MainMenu();
            pg1.Show();
            this.Hide();
        }

        private void hoursCount_Click(object sender, EventArgs e)
        {

        }

        private void daysCount_Click(object sender, EventArgs e)
        {

        }

        private void days_Click(object sender, EventArgs e)
        {

        }

        private void hours_Click(object sender, EventArgs e)
        {

        }

        private void and_Click(object sender, EventArgs e)
        {

        }

        private void minutesCount_Click(object sender, EventArgs e)
        {

        }

        private void minutes_Click(object sender, EventArgs e)
        {

        }

        private void remainText_Click(object sender, EventArgs e)
        {

        }

        private void remainTimer_Tick(object sender, EventArgs e)
        {
            {
                {
                    DateTime currentDate = DateTime.Now;
                    DateTime needDate = new DateTime(2017, 11, 24, 6, 0, 0);
                    TimeSpan calcDate = needDate - currentDate;
                    daysCount.Text = calcDate.Days.ToString();
                    hoursCount.Text = calcDate.Hours.ToString();
                    minutesCount.Text = calcDate.Minutes.ToString();

                    if (needDate - currentDate <= new TimeSpan(0, 0, 0))
                    {

                    }

                    {
                        if (daysCount.Text.Substring(0) == "11"
                         || daysCount.Text.Substring(0) == "12"
                         || daysCount.Text.Substring(0) == "13"
                         || daysCount.Text.Substring(0) == "14"
                         || daysCount.Text.Substring(0) == "15"
                         || daysCount.Text.Substring(0) == "16"
                         || daysCount.Text.Substring(0) == "17"
                         || daysCount.Text.Substring(0) == "18"
                         || daysCount.Text.Substring(0) == "19")
                        {
                            days.Text = "дней";
                        }
                        else if (daysCount.Text.Substring(daysCount.Text.Length - 1, 1) == "1")
                        {
                            days.Text = "день";
                        }
                        else if (daysCount.Text.Substring(daysCount.Text.Length - 1, 1) == "2"
                         || daysCount.Text.Substring(daysCount.Text.Length - 1, 1) == "3"
                         || daysCount.Text.Substring(daysCount.Text.Length - 1, 1) == "4")
                        {
                            days.Text = "дня";
                        }
                        else
                        {
                            days.Text = "дней";
                        }
                    } //Case Days
                    {
                        if (hoursCount.Text.Substring(0) == "11"
                         || hoursCount.Text.Substring(0) == "12"
                         || hoursCount.Text.Substring(0) == "13"
                         || hoursCount.Text.Substring(0) == "14"
                         || hoursCount.Text.Substring(0) == "15"
                         || hoursCount.Text.Substring(0) == "16"
                         || hoursCount.Text.Substring(0) == "17"
                         || hoursCount.Text.Substring(0) == "18"
                         || hoursCount.Text.Substring(0) == "19")
                        {
                            hours.Text = "часов";
                        }
                        else if (hoursCount.Text.Substring(hoursCount.Text.Length - 1, 1) == "1")
                        {
                            hours.Text = "час";
                        }
                        else if (hoursCount.Text.Substring(hoursCount.Text.Length - 1, 1) == "2"
                         || hoursCount.Text.Substring(hoursCount.Text.Length - 1, 1) == "3"
                         || hoursCount.Text.Substring(hoursCount.Text.Length - 1, 1) == "4")
                        {
                            hours.Text = "часа";
                        }
                        else
                        {
                            hours.Text = "часов";
                        }
                    } //Case Hours
                    {
                        if (minutesCount.Text.Substring(0) == "11"
                         || minutesCount.Text.Substring(0) == "12"
                         || minutesCount.Text.Substring(0) == "13"
                         || minutesCount.Text.Substring(0) == "14"
                         || minutesCount.Text.Substring(0) == "15"
                         || minutesCount.Text.Substring(0) == "16"
                         || minutesCount.Text.Substring(0) == "17"
                         || minutesCount.Text.Substring(0) == "18"
                         || minutesCount.Text.Substring(0) == "19")
                        {
                            minutes.Text = "минут";
                        }
                        else if (minutesCount.Text.Substring(minutesCount.Text.Length - 1, 1) == "1")
                        {
                            minutes.Text = "минута";
                        }
                        else if (minutesCount.Text.Substring(minutesCount.Text.Length - 1, 1) == "2"
                         || minutesCount.Text.Substring(minutesCount.Text.Length - 1, 1) == "3"
                         || minutesCount.Text.Substring(minutesCount.Text.Length - 1, 1) == "4")
                        {
                            minutes.Text = "минуты";
                        }
                        else
                        {
                            minutes.Text = "минут";
                        }
                    } //Case Minutes
                } // Timer; Cases
            }
        }

        private void height_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void weight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }

        }

        private void cancel_Click(object sender, EventArgs e)
        {
            male.FlatAppearance.BorderSize = 1;
            female.FlatAppearance.BorderSize = 1;
            height.Text = "";
            weight.Text = "";
            textBox1.Text = "";
            label11.Text = "";
            Minimum.Text = "";
            Low.Text = "";
            Average.Text = "";
            Tall.Text = "";
            VeryTall.Text = "";
        }
    }
}
