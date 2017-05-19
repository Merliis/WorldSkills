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
    public partial class coordinatorMenu : Form
    {
        public coordinatorMenu()
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

        public void backToMainMenu_Click(object sender, EventArgs e)
        {
            MainMenu pg1 = new MainMenu();
            pg1.Show();
            this.Hide();
        }

        private void coordinatorMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
