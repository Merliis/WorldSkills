using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace WorldSkills
{
    public partial class authorizationMenu : Form
    {
        public authorizationMenu()
        {
            InitializeComponent();
            this.KeyPreview = true;
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

        private void emailTextBox_Enter(object sender, EventArgs e)
        {
            if (emailTextBox.Text == "Enter your email address") {
                emailTextBox.Text = "";
                emailTextBox.ForeColor = Color.Black;
            }
        }

        private void emailTextBox_Leave(object sender, EventArgs e)
        {
            if (emailTextBox.Text == "") {
                emailTextBox.Text = "Enter your email address";
                emailTextBox.ForeColor = Color.FromArgb(180, 180, 180); 
            }
        }

        private void passwordTextBox_Enter(object sender, EventArgs e)
        {
            if (passwordTextBox.Text == "Enter your password")
            {
                passwordTextBox.Text = "";
                passwordTextBox.ForeColor = Color.Black;
                passwordTextBox.PasswordChar = '*';
            }
        }

        private void passwordTextBox_Leave(object sender, EventArgs e)
        {
            if (passwordTextBox.Text == "")
            {
                passwordTextBox.Text = "Enter your password";
                passwordTextBox.ForeColor = Color.FromArgb(180, 180, 180);
                passwordTextBox.PasswordChar = '\0';
            }
        }

        private void autorizationLogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=PROVICE-PC\SQLEXPRESS;Initial Catalog=SQL;Integrated Security=True");
            SqlCommand com = new SqlCommand("SELECT * FROM [dbo].[User]", con);
            SqlDataReader reader;

            con.Open();

            reader = com.ExecuteReader();

            bool result = false;
            while (reader.Read())

            {
                if (emailTextBox.Text == reader["Email"].ToString() && passwordTextBox.Text == reader["Password"].ToString())
                {
                    if ("R" == reader["RoleId"].ToString())
                    {
                        runnerMenu pg7 = new runnerMenu();
                        pg7.Show();
                        this.Hide();
                        result = true;
                    }

                    else if ("A" == reader["RoleId"].ToString())
                    {
                        administratorMenu pg15 = new administratorMenu();
                        pg15.Show();
                        this.Hide();
                        result = true;

                    }
                    else if ("C" == reader["RoleId"].ToString())
                    {
                        coordinatorMenu pg14 = new coordinatorMenu();
                        pg14.Show();
                        this.Hide();
                        result = true;
                    }
                }
            }
            if (result == false) {
                MessageBox.Show("Логин или пароль введены неверно!", "Ошибка входа!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                passwordTextBox.Text = "Enter your password";
                passwordTextBox.ForeColor = Color.FromArgb(180, 180, 180);
                passwordTextBox.PasswordChar = '\0';
            }
            con.Close();
        }

        private void autorizationCancel_Click(object sender, EventArgs e)
        {
            emailTextBox.Text = "Enter your email address";
            emailTextBox.ForeColor = Color.FromArgb(180, 180, 180);
            passwordTextBox.Text = "Enter your password";
            passwordTextBox.ForeColor = Color.FromArgb(180, 180, 180);
            passwordTextBox.PasswordChar = '\0';
        }

        private void emailTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                autorizationLogin.PerformClick();
            }
        }

        private void passwordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                autorizationLogin.PerformClick();
            }
        }

        private void autorizationMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}