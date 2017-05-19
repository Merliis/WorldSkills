namespace WorldSkills
{
    partial class registrationMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(registrationMenu));
            this.backToMainMenu = new System.Windows.Forms.Button();
            this.Header = new System.Windows.Forms.Label();
            this.remainTime = new System.Windows.Forms.Panel();
            this.hoursCount = new System.Windows.Forms.Label();
            this.remainText = new System.Windows.Forms.Label();
            this.and = new System.Windows.Forms.Label();
            this.minutesCount = new System.Windows.Forms.Label();
            this.daysCount = new System.Windows.Forms.Label();
            this.minutes = new System.Windows.Forms.Label();
            this.hours = new System.Windows.Forms.Label();
            this.days = new System.Windows.Forms.Label();
            this.remainTimer = new System.Windows.Forms.Timer(this.components);
            this.regRunnerTitle = new System.Windows.Forms.Label();
            this.regRunnerDescription = new System.Windows.Forms.Label();
            this.regRunnerEmailLabel = new System.Windows.Forms.Label();
            this.regRunnerPasswordLabel = new System.Windows.Forms.Label();
            this.regRunnerNameLabel = new System.Windows.Forms.Label();
            this.regRunnerSecNameLabel = new System.Windows.Forms.Label();
            this.regRunnerGenderLabel = new System.Windows.Forms.Label();
            this.regRunnerRetryPasswordLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.retryPasswordTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.secNameTextBox = new System.Windows.Forms.TextBox();
            this.avatarPicBox = new System.Windows.Forms.PictureBox();
            this.headerBlock = new System.Windows.Forms.PictureBox();
            this.footerBlock = new System.Windows.Forms.PictureBox();
            this.avatarImageLinkTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.findPictureButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.registration = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.genderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sQLDataSet = new WorldSkills.SQLDataSet();
            this.countryComboBox = new System.Windows.Forms.ComboBox();
            this.countryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.countryTableAdapter = new WorldSkills.SQLDataSetTableAdapters.CountryTableAdapter();
            this.warn = new System.Windows.Forms.Label();
            this.genderTableAdapter = new WorldSkills.SQLDataSetTableAdapters.GenderTableAdapter();
            this.remainTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatarPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.headerBlock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.footerBlock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQLDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // backToMainMenu
            // 
            this.backToMainMenu.Location = new System.Drawing.Point(11, 9);
            this.backToMainMenu.Name = "backToMainMenu";
            this.backToMainMenu.Size = new System.Drawing.Size(72, 26);
            this.backToMainMenu.TabIndex = 26;
            this.backToMainMenu.Text = "Назад";
            this.backToMainMenu.UseVisualStyleBackColor = true;
            this.backToMainMenu.Click += new System.EventHandler(this.backToMainMenu_Click);
            // 
            // Header
            // 
            this.Header.AutoSize = true;
            this.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Header.Font = new System.Drawing.Font("Arial", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Header.ForeColor = System.Drawing.Color.White;
            this.Header.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Header.Location = new System.Drawing.Point(89, 9);
            this.Header.Name = "Header";
            this.Header.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Header.Size = new System.Drawing.Size(298, 28);
            this.Header.TabIndex = 28;
            this.Header.Text = "MARATHON SKILLS 2016";
            this.Header.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Header.UseMnemonic = false;
            // 
            // remainTime
            // 
            this.remainTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.remainTime.Controls.Add(this.hoursCount);
            this.remainTime.Controls.Add(this.remainText);
            this.remainTime.Controls.Add(this.and);
            this.remainTime.Controls.Add(this.minutesCount);
            this.remainTime.Controls.Add(this.daysCount);
            this.remainTime.Controls.Add(this.minutes);
            this.remainTime.Controls.Add(this.hours);
            this.remainTime.Controls.Add(this.days);
            this.remainTime.Location = new System.Drawing.Point(151, 627);
            this.remainTime.Name = "remainTime";
            this.remainTime.Size = new System.Drawing.Size(483, 31);
            this.remainTime.TabIndex = 30;
            // 
            // hoursCount
            // 
            this.hoursCount.AutoSize = true;
            this.hoursCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.hoursCount.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.hoursCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.hoursCount.ForeColor = System.Drawing.Color.White;
            this.hoursCount.Location = new System.Drawing.Point(110, 5);
            this.hoursCount.Name = "hoursCount";
            this.hoursCount.Size = new System.Drawing.Size(27, 20);
            this.hoursCount.TabIndex = 16;
            this.hoursCount.Text = "00";
            this.hoursCount.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // remainText
            // 
            this.remainText.AutoSize = true;
            this.remainText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.remainText.ForeColor = System.Drawing.Color.White;
            this.remainText.Location = new System.Drawing.Point(281, 5);
            this.remainText.Name = "remainText";
            this.remainText.Size = new System.Drawing.Size(196, 20);
            this.remainText.TabIndex = 20;
            this.remainText.Text = " осталось до марафона!";
            // 
            // and
            // 
            this.and.AutoSize = true;
            this.and.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.and.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.and.ForeColor = System.Drawing.Color.White;
            this.and.Location = new System.Drawing.Point(180, 5);
            this.and.Name = "and";
            this.and.Size = new System.Drawing.Size(18, 20);
            this.and.TabIndex = 19;
            this.and.Text = "и";
            // 
            // minutesCount
            // 
            this.minutesCount.AutoSize = true;
            this.minutesCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.minutesCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minutesCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.minutesCount.ForeColor = System.Drawing.Color.White;
            this.minutesCount.Location = new System.Drawing.Point(196, 5);
            this.minutesCount.Name = "minutesCount";
            this.minutesCount.Size = new System.Drawing.Size(27, 20);
            this.minutesCount.TabIndex = 17;
            this.minutesCount.Text = "00";
            this.minutesCount.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // daysCount
            // 
            this.daysCount.AutoSize = true;
            this.daysCount.BackColor = System.Drawing.Color.Transparent;
            this.daysCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.daysCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.daysCount.ForeColor = System.Drawing.Color.White;
            this.daysCount.Location = new System.Drawing.Point(36, 5);
            this.daysCount.Name = "daysCount";
            this.daysCount.Size = new System.Drawing.Size(36, 20);
            this.daysCount.TabIndex = 15;
            this.daysCount.Text = "000";
            this.daysCount.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // minutes
            // 
            this.minutes.AutoSize = true;
            this.minutes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.minutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minutes.ForeColor = System.Drawing.Color.White;
            this.minutes.Location = new System.Drawing.Point(221, 5);
            this.minutes.Name = "minutes";
            this.minutes.Size = new System.Drawing.Size(65, 20);
            this.minutes.TabIndex = 14;
            this.minutes.Text = "минуты";
            // 
            // hours
            // 
            this.hours.AutoSize = true;
            this.hours.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.hours.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hours.ForeColor = System.Drawing.Color.White;
            this.hours.Location = new System.Drawing.Point(132, 5);
            this.hours.Name = "hours";
            this.hours.Size = new System.Drawing.Size(53, 20);
            this.hours.TabIndex = 13;
            this.hours.Text = "часов";
            // 
            // days
            // 
            this.days.AutoSize = true;
            this.days.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.days.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.days.ForeColor = System.Drawing.Color.White;
            this.days.Location = new System.Drawing.Point(68, 5);
            this.days.Name = "days";
            this.days.Size = new System.Drawing.Size(47, 20);
            this.days.TabIndex = 12;
            this.days.Text = "дней";
            // 
            // remainTimer
            // 
            this.remainTimer.Enabled = true;
            this.remainTimer.Interval = 1;
            this.remainTimer.Tick += new System.EventHandler(this.remainTimer_Tick);
            // 
            // regRunnerTitle
            // 
            this.regRunnerTitle.AutoSize = true;
            this.regRunnerTitle.Font = new System.Drawing.Font("Arial", 14F);
            this.regRunnerTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.regRunnerTitle.Location = new System.Drawing.Point(301, 74);
            this.regRunnerTitle.Name = "regRunnerTitle";
            this.regRunnerTitle.Size = new System.Drawing.Size(183, 22);
            this.regRunnerTitle.TabIndex = 31;
            this.regRunnerTitle.Text = "Регистрация бегуна";
            // 
            // regRunnerDescription
            // 
            this.regRunnerDescription.AutoSize = true;
            this.regRunnerDescription.Font = new System.Drawing.Font("Arial", 12.5F);
            this.regRunnerDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.regRunnerDescription.Location = new System.Drawing.Point(74, 113);
            this.regRunnerDescription.Name = "regRunnerDescription";
            this.regRunnerDescription.Size = new System.Drawing.Size(636, 38);
            this.regRunnerDescription.TabIndex = 32;
            this.regRunnerDescription.Text = "Пожалуйста заполните всю информацию, чтобы зарегистрироваться в качестве\r\nбегуна";
            this.regRunnerDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // regRunnerEmailLabel
            // 
            this.regRunnerEmailLabel.AutoSize = true;
            this.regRunnerEmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.regRunnerEmailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.regRunnerEmailLabel.Location = new System.Drawing.Point(121, 188);
            this.regRunnerEmailLabel.Name = "regRunnerEmailLabel";
            this.regRunnerEmailLabel.Size = new System.Drawing.Size(56, 20);
            this.regRunnerEmailLabel.TabIndex = 33;
            this.regRunnerEmailLabel.Text = "Email:";
            // 
            // regRunnerPasswordLabel
            // 
            this.regRunnerPasswordLabel.AutoSize = true;
            this.regRunnerPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.regRunnerPasswordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.regRunnerPasswordLabel.Location = new System.Drawing.Point(100, 228);
            this.regRunnerPasswordLabel.Name = "regRunnerPasswordLabel";
            this.regRunnerPasswordLabel.Size = new System.Drawing.Size(77, 20);
            this.regRunnerPasswordLabel.TabIndex = 34;
            this.regRunnerPasswordLabel.Text = "Пароль:";
            // 
            // regRunnerNameLabel
            // 
            this.regRunnerNameLabel.AutoSize = true;
            this.regRunnerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.regRunnerNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.regRunnerNameLabel.Location = new System.Drawing.Point(130, 316);
            this.regRunnerNameLabel.Name = "regRunnerNameLabel";
            this.regRunnerNameLabel.Size = new System.Drawing.Size(47, 20);
            this.regRunnerNameLabel.TabIndex = 35;
            this.regRunnerNameLabel.Text = "Имя:";
            // 
            // regRunnerSecNameLabel
            // 
            this.regRunnerSecNameLabel.AutoSize = true;
            this.regRunnerSecNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.regRunnerSecNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.regRunnerSecNameLabel.Location = new System.Drawing.Point(85, 361);
            this.regRunnerSecNameLabel.Name = "regRunnerSecNameLabel";
            this.regRunnerSecNameLabel.Size = new System.Drawing.Size(92, 20);
            this.regRunnerSecNameLabel.TabIndex = 36;
            this.regRunnerSecNameLabel.Text = "Фамилия:";
            // 
            // regRunnerGenderLabel
            // 
            this.regRunnerGenderLabel.AutoSize = true;
            this.regRunnerGenderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.regRunnerGenderLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.regRunnerGenderLabel.Location = new System.Drawing.Point(130, 408);
            this.regRunnerGenderLabel.Name = "regRunnerGenderLabel";
            this.regRunnerGenderLabel.Size = new System.Drawing.Size(47, 20);
            this.regRunnerGenderLabel.TabIndex = 37;
            this.regRunnerGenderLabel.Text = "Пол:";
            // 
            // regRunnerRetryPasswordLabel
            // 
            this.regRunnerRetryPasswordLabel.AutoSize = true;
            this.regRunnerRetryPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.regRunnerRetryPasswordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.regRunnerRetryPasswordLabel.Location = new System.Drawing.Point(5, 271);
            this.regRunnerRetryPasswordLabel.Name = "regRunnerRetryPasswordLabel";
            this.regRunnerRetryPasswordLabel.Size = new System.Drawing.Size(172, 20);
            this.regRunnerRetryPasswordLabel.TabIndex = 38;
            this.regRunnerRetryPasswordLabel.Text = "Повторите пароль:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.AccessibleDescription = "";
            this.emailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.emailTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.emailTextBox.Location = new System.Drawing.Point(179, 182);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(246, 26);
            this.emailTextBox.TabIndex = 39;
            this.emailTextBox.Text = "Email";
            this.emailTextBox.TextChanged += new System.EventHandler(this.emailTextBox_TextChanged);
            this.emailTextBox.Enter += new System.EventHandler(this.emailTextBox_Enter);
            this.emailTextBox.Leave += new System.EventHandler(this.emailTextBox_Leave);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.AccessibleDescription = "";
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.passwordTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.passwordTextBox.Location = new System.Drawing.Point(179, 225);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(202, 26);
            this.passwordTextBox.TabIndex = 40;
            this.passwordTextBox.Text = "Пароль";
            this.passwordTextBox.Enter += new System.EventHandler(this.passwordTextBox_Enter);
            this.passwordTextBox.Leave += new System.EventHandler(this.passwordTextBox_Leave);
            // 
            // retryPasswordTextBox
            // 
            this.retryPasswordTextBox.AccessibleDescription = "";
            this.retryPasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.retryPasswordTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.retryPasswordTextBox.Location = new System.Drawing.Point(179, 268);
            this.retryPasswordTextBox.Name = "retryPasswordTextBox";
            this.retryPasswordTextBox.Size = new System.Drawing.Size(202, 26);
            this.retryPasswordTextBox.TabIndex = 41;
            this.retryPasswordTextBox.Text = "Повторите пароль";
            this.retryPasswordTextBox.Enter += new System.EventHandler(this.retryPasswordTextBox_Enter);
            this.retryPasswordTextBox.Leave += new System.EventHandler(this.retryPasswordTextBox_Leave);
            // 
            // nameTextBox
            // 
            this.nameTextBox.AccessibleDescription = "";
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.nameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.nameTextBox.Location = new System.Drawing.Point(179, 313);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(202, 26);
            this.nameTextBox.TabIndex = 42;
            this.nameTextBox.Text = "Имя";
            this.nameTextBox.Enter += new System.EventHandler(this.nameTextBox_Enter);
            this.nameTextBox.Leave += new System.EventHandler(this.nameTextBox_Leave);
            // 
            // secNameTextBox
            // 
            this.secNameTextBox.AccessibleDescription = "";
            this.secNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.secNameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.secNameTextBox.Location = new System.Drawing.Point(179, 358);
            this.secNameTextBox.Name = "secNameTextBox";
            this.secNameTextBox.Size = new System.Drawing.Size(202, 26);
            this.secNameTextBox.TabIndex = 43;
            this.secNameTextBox.Text = "Фамилия";
            this.secNameTextBox.Enter += new System.EventHandler(this.secNameTextBox_Enter);
            this.secNameTextBox.Leave += new System.EventHandler(this.secNameTextBox_Leave);
            // 
            // avatarPicBox
            // 
            this.avatarPicBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.avatarPicBox.Image = global::WorldSkills.Properties.Resources.noimg;
            this.avatarPicBox.Location = new System.Drawing.Point(611, 151);
            this.avatarPicBox.Name = "avatarPicBox";
            this.avatarPicBox.Size = new System.Drawing.Size(120, 140);
            this.avatarPicBox.TabIndex = 44;
            this.avatarPicBox.TabStop = false;
            // 
            // headerBlock
            // 
            this.headerBlock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.headerBlock.Location = new System.Drawing.Point(0, 0);
            this.headerBlock.Name = "headerBlock";
            this.headerBlock.Size = new System.Drawing.Size(784, 46);
            this.headerBlock.TabIndex = 27;
            this.headerBlock.TabStop = false;
            // 
            // footerBlock
            // 
            this.footerBlock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.footerBlock.Location = new System.Drawing.Point(-1, 622);
            this.footerBlock.Name = "footerBlock";
            this.footerBlock.Size = new System.Drawing.Size(786, 39);
            this.footerBlock.TabIndex = 29;
            this.footerBlock.TabStop = false;
            // 
            // avatarImageLinkTextBox
            // 
            this.avatarImageLinkTextBox.AccessibleDescription = "";
            this.avatarImageLinkTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.avatarImageLinkTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.avatarImageLinkTextBox.Location = new System.Drawing.Point(490, 313);
            this.avatarImageLinkTextBox.Name = "avatarImageLinkTextBox";
            this.avatarImageLinkTextBox.Size = new System.Drawing.Size(169, 26);
            this.avatarImageLinkTextBox.TabIndex = 45;
            this.avatarImageLinkTextBox.Text = "shakal.jypeg";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label1.Location = new System.Drawing.Point(477, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 46;
            this.label1.Text = "Фото файл:";
            // 
            // findPictureButton
            // 
            this.findPictureButton.Location = new System.Drawing.Point(665, 313);
            this.findPictureButton.Name = "findPictureButton";
            this.findPictureButton.Size = new System.Drawing.Size(107, 26);
            this.findPictureButton.TabIndex = 47;
            this.findPictureButton.Text = "Просмотр...";
            this.findPictureButton.UseVisualStyleBackColor = true;
            this.findPictureButton.Click += new System.EventHandler(this.findPictureButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label2.Location = new System.Drawing.Point(440, 361);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 20);
            this.label2.TabIndex = 48;
            this.label2.Text = "Дата рождения:";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(588, 358);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(184, 26);
            this.dateTimePicker.TabIndex = 49;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label3.Location = new System.Drawing.Point(510, 408);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 50;
            this.label3.Text = "Страна:";
            // 
            // registration
            // 
            this.registration.Location = new System.Drawing.Point(251, 527);
            this.registration.Name = "registration";
            this.registration.Size = new System.Drawing.Size(127, 41);
            this.registration.TabIndex = 51;
            this.registration.Text = "Регистрация";
            this.registration.UseVisualStyleBackColor = true;
            this.registration.Click += new System.EventHandler(this.registration_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(407, 527);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 41);
            this.button2.TabIndex = 52;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // genderComboBox
            // 
            this.genderComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.genderComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.genderComboBox.DataSource = this.genderBindingSource;
            this.genderComboBox.DisplayMember = "Gender";
            this.genderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Location = new System.Drawing.Point(179, 405);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(128, 28);
            this.genderComboBox.TabIndex = 53;
            // 
            // genderBindingSource
            // 
            this.genderBindingSource.DataMember = "Gender";
            this.genderBindingSource.DataSource = this.sQLDataSet;
            // 
            // sQLDataSet
            // 
            this.sQLDataSet.DataSetName = "SQLDataSet";
            this.sQLDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // countryComboBox
            // 
            this.countryComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.countryComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.countryComboBox.DataSource = this.countryBindingSource;
            this.countryComboBox.DisplayMember = "CountryName";
            this.countryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.countryComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.countryComboBox.FormattingEnabled = true;
            this.countryComboBox.Location = new System.Drawing.Point(588, 405);
            this.countryComboBox.Name = "countryComboBox";
            this.countryComboBox.Size = new System.Drawing.Size(184, 28);
            this.countryComboBox.TabIndex = 54;
            // 
            // countryBindingSource
            // 
            this.countryBindingSource.DataMember = "Country";
            this.countryBindingSource.DataSource = this.sQLDataSet;
            // 
            // countryTableAdapter
            // 
            this.countryTableAdapter.ClearBeforeFill = true;
            // 
            // warn
            // 
            this.warn.AutoSize = true;
            this.warn.ForeColor = System.Drawing.Color.Red;
            this.warn.Location = new System.Drawing.Point(226, 166);
            this.warn.Name = "warn";
            this.warn.Size = new System.Drawing.Size(152, 13);
            this.warn.TabIndex = 55;
            this.warn.Text = "Этот email уже используется";
            this.warn.Visible = false;
            // 
            // genderTableAdapter
            // 
            this.genderTableAdapter.ClearBeforeFill = true;
            // 
            // registrationMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(784, 661);
            this.Controls.Add(this.warn);
            this.Controls.Add(this.countryComboBox);
            this.Controls.Add(this.genderComboBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.registration);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.findPictureButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.avatarImageLinkTextBox);
            this.Controls.Add(this.avatarPicBox);
            this.Controls.Add(this.secNameTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.retryPasswordTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.regRunnerRetryPasswordLabel);
            this.Controls.Add(this.regRunnerGenderLabel);
            this.Controls.Add(this.regRunnerSecNameLabel);
            this.Controls.Add(this.regRunnerNameLabel);
            this.Controls.Add(this.regRunnerPasswordLabel);
            this.Controls.Add(this.regRunnerEmailLabel);
            this.Controls.Add(this.regRunnerDescription);
            this.Controls.Add(this.regRunnerTitle);
            this.Controls.Add(this.backToMainMenu);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.headerBlock);
            this.Controls.Add(this.remainTime);
            this.Controls.Add(this.footerBlock);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "registrationMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WorldSkills Marathon ● Registration";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.registrationMenu_FormClosed);
            this.Load += new System.EventHandler(this.registrationMenu_Load);
            this.remainTime.ResumeLayout(false);
            this.remainTime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatarPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.headerBlock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.footerBlock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQLDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backToMainMenu;
        private System.Windows.Forms.Label Header;
        private System.Windows.Forms.PictureBox headerBlock;
        private System.Windows.Forms.Panel remainTime;
        private System.Windows.Forms.Label hoursCount;
        private System.Windows.Forms.Label remainText;
        private System.Windows.Forms.Label and;
        private System.Windows.Forms.Label minutesCount;
        private System.Windows.Forms.Label daysCount;
        private System.Windows.Forms.Label minutes;
        private System.Windows.Forms.Label hours;
        private System.Windows.Forms.Label days;
        private System.Windows.Forms.PictureBox footerBlock;
        private System.Windows.Forms.Timer remainTimer;
        private System.Windows.Forms.Label regRunnerTitle;
        private System.Windows.Forms.Label regRunnerDescription;
        private System.Windows.Forms.Label regRunnerEmailLabel;
        private System.Windows.Forms.Label regRunnerPasswordLabel;
        private System.Windows.Forms.Label regRunnerNameLabel;
        private System.Windows.Forms.Label regRunnerSecNameLabel;
        private System.Windows.Forms.Label regRunnerGenderLabel;
        private System.Windows.Forms.Label regRunnerRetryPasswordLabel;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox retryPasswordTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox secNameTextBox;
        private System.Windows.Forms.PictureBox avatarPicBox;
        private System.Windows.Forms.TextBox avatarImageLinkTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button findPictureButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button registration;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox genderComboBox;
        private System.Windows.Forms.ComboBox countryComboBox;
        private SQLDataSet sQLDataSet;
        private System.Windows.Forms.BindingSource countryBindingSource;
        private SQLDataSetTableAdapters.CountryTableAdapter countryTableAdapter;
        private System.Windows.Forms.Label warn;
        private System.Windows.Forms.BindingSource genderBindingSource;
        private SQLDataSetTableAdapters.GenderTableAdapter genderTableAdapter;
    }
}