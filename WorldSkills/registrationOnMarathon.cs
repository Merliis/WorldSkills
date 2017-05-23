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
    public partial class registrationOnMarathon : Form
    {
        public registrationOnMarathon()
        {
            InitializeComponent();
            contributionComboBox.SelectedIndex = 0;
            fullMarathonCB.Checked = true;
        }

        private void registrationOnMarathon_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void remainTimer_Tick(object sender, EventArgs e)
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

        private void contributionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void sumContributionTextBox_Enter(object sender, EventArgs e)
        {
            if (sumContributionTextBox.Text == "$500") {
                sumContributionTextBox.Text = "";
                sumContributionTextBox.ForeColor = Color.Black;
            }
        }

        private void sumContributionTextBox_Leave(object sender, EventArgs e)
        {
            if (sumContributionTextBox.Text == "") {
                sumContributionTextBox.Text = "$500";
                sumContributionTextBox.ForeColor = Color.FromArgb(180, 180, 180);
            }
        }

        private void registrationOnMarathon_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(infoPic, "информация не дана");
        }

        private void backToMainMenu_Click(object sender, EventArgs e)
        {
            MainMenu pg1 = new MainMenu();
            pg1.Show();
            this.Hide();
        }

        private void sumContributionTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }
        int fullMar = 0; //145
        int halfMar = 0; //75
        int smallMar = 0; //20
        int variantA = 0; //0
        int variantB = 0; //20
        int variantC = 0; //45


        private void fullMarathonCB_Click(object sender, EventArgs e)
        {
            if (fullMarathonCB.Checked == true) {
                fullMar = 145;
            } else {
                fullMar = 0;
            }
            finSumContribution.Text = (fullMar + halfMar + smallMar + variantA + variantB + variantC).ToString();
        }

        private void halfMarathonCB_Click(object sender, EventArgs e)
        {
            if (halfMarathonCB.Checked == true) {
                halfMar = 75;
            } else {
                halfMar = 0;
            }
            finSumContribution.Text = (fullMar + halfMar + smallMar + variantA + variantB + variantC).ToString();
        }

        private void smallMarathonCB_Click(object sender, EventArgs e)
        {
            if (smallMarathonCB.Checked == true) {
                smallMar = 20;
            } else {
                smallMar = 0;
            }
            finSumContribution.Text = (fullMar + halfMar + smallMar + variantA + variantB + variantC).ToString();
        }

        private void varA_Click(object sender, EventArgs e)
        {
            if (varA.Checked == true) {
                variantA = 0;
                variantB = 0;
                variantC = 0;
            } else {
                variantA = 0;
            }
            finSumContribution.Text = (fullMar + halfMar + smallMar + variantA + variantB + variantC).ToString();
        }

        private void varB_Click(object sender, EventArgs e)
        {
            if (varB.Checked == true) {
                variantA = 0;
                variantB = 20;
                variantC = 0;
            } else {
                variantB = 0;
            }
            finSumContribution.Text = (fullMar + halfMar + smallMar + variantA + variantB + variantC).ToString();
        }

        private void varC_Click(object sender, EventArgs e)
        {
            if (varC.Checked == true) {
                variantA = 0;
                variantB = 0;
                variantC = 45;
            }
            else {
                variantC = 0;
            }
            finSumContribution.Text = (fullMar + halfMar + smallMar + variantA + variantB + variantC).ToString();
        }
    }
}
