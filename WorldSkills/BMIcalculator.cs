using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace WorldSkills
{
    public partial class BMIcalculator : Form
    {
        public BMIcalculator()
        {
            InitializeComponent();
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

        private void backToMainMenu_Click(object sender, EventArgs e)
        {
            MainMenu pg1 = new MainMenu();
            pg1.Show();
            this.Hide();
        }

        private void BMIcalculator_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(label1, "BMI обозначает индекс массы тела. Он используется, чтобы дать вам представление о том,\r\nявляется " +
            "ли Ваш вес - избыточным или идеальным для вашего роста.");
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            height.Text = "";
            weight.Text = "";
            female.FlatAppearance.BorderSize = 1;
            male.FlatAppearance.BorderSize = 1;
            pictureBox1.Image = null;
            arrowBox.Location = new Point(326, 489);
            BMIresult.Text = "00,0";
        }

        private void calc_Click(object sender, EventArgs e)
        {
            if (height.Text == "" || weight.Text == "" || female.FlatAppearance.BorderSize != 3 && male.FlatAppearance.BorderSize != 3)
            {
                MessageBox.Show("Параметры пол, рост или вес не введены!", "Параметры не введены", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                double heightNum = Convert.ToDouble(height.Text);
                double weightNum = Convert.ToDouble(weight.Text);
                double BMIpreRes = Math.Round(weightNum / ((heightNum / 100) * (heightNum / 100)), 1);

                double arrowPreMoveValue;

                if (BMIpreRes > 0 && BMIpreRes < 18.5) {
                    arrowPreMoveValue = (BMIpreRes * 100) / 18.5;
                    int arrowMoveValue = Convert.ToInt32(arrowPreMoveValue);
                    arrowBox.Location = new Point(326 + arrowMoveValue, 489);
                    pictureBox1.Image = global::WorldSkills.Properties.Resources.bmi_underweight_icon;
                } else if (BMIpreRes > 18.5 && BMIpreRes < 24.9) 
                {
                    arrowPreMoveValue = (BMIpreRes * 200) / 24.9;
                    int arrowMoveValue = Convert.ToInt32(arrowPreMoveValue);
                    arrowBox.Location = new Point(326 + arrowMoveValue, 489);
                    pictureBox1.Image = global::WorldSkills.Properties.Resources.bmi_healthy_icon;
                } else if (BMIpreRes > 25 && BMIpreRes < 29.9)
                {
                    arrowPreMoveValue = (BMIpreRes * 300) / 29.9;
                    int arrowMoveValue = Convert.ToInt32(arrowPreMoveValue);
                    arrowBox.Location = new Point(326 + arrowMoveValue, 489);
                    pictureBox1.Image = global::WorldSkills.Properties.Resources.bmi_overweight_icon;
                }
                else if (BMIpreRes > 30)
                {
                    arrowPreMoveValue = (BMIpreRes * 400) / 30;
                    int arrowMoveValue = Convert.ToInt32(arrowPreMoveValue);
                    arrowBox.Location = new Point(726, 489);
                    pictureBox1.Image = global::WorldSkills.Properties.Resources.bmi_obese_icon;
                }

                BMIresult.Text = BMIpreRes.ToString();
                if (BMIresult.Text.Length <= 2) {
                    BMIresult.Text += ",0";
                }
            }
        }

        private void BMIcalculator_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                calc.PerformClick();
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

        private void weight_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                calc.PerformClick();
            }
        }

        private void height_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                calc.PerformClick();
            }
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

        private void BMIcalculator_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}