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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
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

        private void runnerRegButton_Click(object sender, EventArgs e)
        {
            regAsRunner pg2 = new regAsRunner();
            pg2.Show();
            this.Hide();
        }

        private void aboutInfButton_Click(object sender, EventArgs e)
        {
            aboutInf pg8 = new aboutInf();
            pg8.Show();
            this.Hide();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            authorizationMenu pg3 = new authorizationMenu();
            pg3.Show();
            this.Hide();
        }

        private void linkToVK_Click(object sender, EventArgs e)
        {
            Process.Start("https://vk.com/provice911");
        }

        private void runnerMenuToolStripMenuItem_Click(object sender, EventArgs e)

        {
            runnerMenu pg7 = new runnerMenu();
            pg7.Show();
            this.Hide();
        }

        private void aboutInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aboutInf pg8 = new aboutInf();
            pg8.Show();
            this.Hide();
        }

        private void autorizationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            authorizationMenu pg3 = new authorizationMenu();
            pg3.Show();
            this.Hide();
        }

        private void coordMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            coordinatorMenu pg14 = new coordinatorMenu();
            pg14.Show();
            this.Hide();
        }

        private void adminMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            administratorMenu pg15 = new administratorMenu();
            pg15.Show();
            this.Hide();
        }

        private void regRunnerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            regAsRunner pg2 = new regAsRunner();
            pg2.Show();
            this.Hide();
        }

        private void aboutMarathonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aboutMarathon pg9 = new aboutMarathon();
            pg9.Show();
            this.Hide();
        }

        private void BMIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BMIcalculator pg23 = new BMIcalculator();
            pg23.Show();
            this.Hide();
        }

        private void registrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            registrationMenu pg4 = new registrationMenu();
            pg4.Show();
            this.Hide();
        }

        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void формыToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bMRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BMRcalculator pg24 = new BMRcalculator();
            pg24.Show();
            this.Hide();
        }
    }
}
