using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing;

namespace WorldSkills
{
    public partial class registrationMenu : Form
    {
        public registrationMenu()
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

        private void registrationMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void emailTextBox_Enter(object sender, EventArgs e)
        {
            if (emailTextBox.Text == "Email") {
                emailTextBox.Text = "";
                emailTextBox.ForeColor = Color.Black;
            }
        }

        private void emailTextBox_Leave(object sender, EventArgs e)
        {
            if (emailTextBox.Text == "") {
                emailTextBox.Text = "Email";
                emailTextBox.ForeColor = Color.FromArgb(180, 180, 180);
            }
        }

        private void findPictureButton_Click(object sender, EventArgs e)
        {

        }

        private void registrationMenu_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sQLDataSet.Gender". При необходимости она может быть перемещена или удалена.
            this.genderTableAdapter.Fill(this.sQLDataSet.Gender);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sQLDataSet.Country". При необходимости она может быть перемещена или удалена.
            this.countryTableAdapter.Fill(this.sQLDataSet.Country);

        }

        private void registration_Click(object sender, EventArgs e)
        {           
            SqlConnection con = new SqlConnection(@"Data Source=PROVICE-PC\SQLEXPRESS;Initial Catalog=SQL;Integrated Security=True");
            SqlCommand comUser = new SqlCommand("SELECT * FROM [dbo].[User]", con);
            SqlDataReader reader;

            con.Open();
            reader = comUser.ExecuteReader();

            bool result = false;
            while (reader.Read())

            {
                if (emailTextBox.Text == reader["Email"].ToString()) {
                    result = true;
                } else {
                    result = false;
                }
            }
            if (result == true) {
                Console.WriteLine("true");
            }

            if (passwordTextBox.Text != retryPasswordTextBox.Text) {
                MessageBox.Show("Пароли не совпадают", "Ошибка регистрации", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else {
                string finalPasswordVar = passwordTextBox.Text;
            }
        }

        private void passwordTextBox_Enter(object sender, EventArgs e)
        {
            if (passwordTextBox.Text == "Пароль") {
                passwordTextBox.Text = "";
                passwordTextBox.ForeColor = Color.Black;
                passwordTextBox.PasswordChar = '*';
            }
        }

        private void passwordTextBox_Leave(object sender, EventArgs e)
        {
            if (passwordTextBox.Text == "") {
                passwordTextBox.Text = "Пароль";
                passwordTextBox.ForeColor = Color.FromArgb(180, 180, 180);
                passwordTextBox.PasswordChar = '\0';
            }
        }

        private void retryPasswordTextBox_Enter(object sender, EventArgs e)
        {
            if (retryPasswordTextBox.Text == "Повторите пароль") {
                retryPasswordTextBox.Text = "";
                retryPasswordTextBox.ForeColor = Color.Black;
                retryPasswordTextBox.PasswordChar = '*';
            }
        }

        private void retryPasswordTextBox_Leave(object sender, EventArgs e)
        {
            if (retryPasswordTextBox.Text == "") {
                retryPasswordTextBox.Text = "Повторите пароль";
                retryPasswordTextBox.ForeColor = Color.FromArgb(180, 180, 180);
                retryPasswordTextBox.PasswordChar = '\0';
            }
        }

        private void nameTextBox_Enter(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "Имя") {
                nameTextBox.Text = "";
                nameTextBox.ForeColor = Color.Black;
            }
        }

        private void nameTextBox_Leave(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "") {
                nameTextBox.Text = "Имя";
                nameTextBox.ForeColor = Color.FromArgb(180, 180, 180);
            }
        }

        private void secNameTextBox_Enter(object sender, EventArgs e)
        {
            if (secNameTextBox.Text == "Фамилия") {
                secNameTextBox.Text = "";
                secNameTextBox.ForeColor = Color.Black;
            }
        }

        private void secNameTextBox_Leave(object sender, EventArgs e)
        {
            if (secNameTextBox.Text == "") {
                secNameTextBox.Text = "Фамилия";
                secNameTextBox.ForeColor = Color.FromArgb(180, 180, 180);
            }
        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
