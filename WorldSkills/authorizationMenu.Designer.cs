namespace WorldSkills
{
    partial class authorizationMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(authorizationMenu));
            this.backToMainMenu = new System.Windows.Forms.Button();
            this.Header = new System.Windows.Forms.Label();
            this.headerBlock = new System.Windows.Forms.PictureBox();
            this.remainTime = new System.Windows.Forms.Panel();
            this.hoursCount = new System.Windows.Forms.Label();
            this.remainText = new System.Windows.Forms.Label();
            this.and = new System.Windows.Forms.Label();
            this.minutesCount = new System.Windows.Forms.Label();
            this.daysCount = new System.Windows.Forms.Label();
            this.minutes = new System.Windows.Forms.Label();
            this.hours = new System.Windows.Forms.Label();
            this.days = new System.Windows.Forms.Label();
            this.footerBlock = new System.Windows.Forms.PictureBox();
            this.remainTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.autorizationLogin = new System.Windows.Forms.Button();
            this.autorizationCancel = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.headerBlock)).BeginInit();
            this.remainTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.footerBlock)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // backToMainMenu
            // 
            this.backToMainMenu.Location = new System.Drawing.Point(12, 9);
            this.backToMainMenu.Name = "backToMainMenu";
            this.backToMainMenu.Size = new System.Drawing.Size(72, 26);
            this.backToMainMenu.TabIndex = 3;
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
            this.Header.Location = new System.Drawing.Point(90, 9);
            this.Header.Name = "Header";
            this.Header.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Header.Size = new System.Drawing.Size(298, 28);
            this.Header.TabIndex = 5;
            this.Header.Text = "MARATHON SKILLS 2016";
            this.Header.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Header.UseMnemonic = false;
            // 
            // headerBlock
            // 
            this.headerBlock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.headerBlock.Location = new System.Drawing.Point(0, 0);
            this.headerBlock.Name = "headerBlock";
            this.headerBlock.Size = new System.Drawing.Size(784, 46);
            this.headerBlock.TabIndex = 4;
            this.headerBlock.TabStop = false;
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
            this.remainTime.Location = new System.Drawing.Point(152, 627);
            this.remainTime.Name = "remainTime";
            this.remainTime.Size = new System.Drawing.Size(483, 31);
            this.remainTime.TabIndex = 22;
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
            // footerBlock
            // 
            this.footerBlock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.footerBlock.Location = new System.Drawing.Point(0, 622);
            this.footerBlock.Name = "footerBlock";
            this.footerBlock.Size = new System.Drawing.Size(786, 39);
            this.footerBlock.TabIndex = 21;
            this.footerBlock.TabStop = false;
            // 
            // remainTimer
            // 
            this.remainTimer.Enabled = true;
            this.remainTimer.Interval = 1;
            this.remainTimer.Tick += new System.EventHandler(this.remainTimer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label1.Location = new System.Drawing.Point(300, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 22);
            this.label1.TabIndex = 23;
            this.label1.Text = "Форма авторизации";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label2.Location = new System.Drawing.Point(120, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(544, 36);
            this.label2.TabIndex = 24;
            this.label2.Text = "Пожалуйста, авторизуйтесь в системе, используя ваш адрес электронный\r\nпочты и пар" +
    "оль.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // autorizationLogin
            // 
            this.autorizationLogin.Location = new System.Drawing.Point(11, 9);
            this.autorizationLogin.Name = "autorizationLogin";
            this.autorizationLogin.Size = new System.Drawing.Size(94, 30);
            this.autorizationLogin.TabIndex = 31;
            this.autorizationLogin.Text = "Login";
            this.autorizationLogin.UseVisualStyleBackColor = true;
            this.autorizationLogin.Click += new System.EventHandler(this.autorizationLogin_Click);
            // 
            // autorizationCancel
            // 
            this.autorizationCancel.Location = new System.Drawing.Point(149, 9);
            this.autorizationCancel.Name = "autorizationCancel";
            this.autorizationCancel.Size = new System.Drawing.Size(94, 30);
            this.autorizationCancel.TabIndex = 32;
            this.autorizationCancel.Text = "Cancel";
            this.autorizationCancel.UseVisualStyleBackColor = true;
            this.autorizationCancel.Click += new System.EventHandler(this.autorizationCancel_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.autorizationCancel);
            this.panel3.Controls.Add(this.autorizationLogin);
            this.panel3.Location = new System.Drawing.Point(264, 336);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(256, 46);
            this.panel3.TabIndex = 33;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.passwordTextBox);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(211, 256);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(363, 55);
            this.panel2.TabIndex = 36;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.AccessibleDescription = "";
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.passwordTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.passwordTextBox.Location = new System.Drawing.Point(102, 14);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(202, 26);
            this.passwordTextBox.TabIndex = 2;
            this.passwordTextBox.Text = "Enter your password";
            this.passwordTextBox.Enter += new System.EventHandler(this.passwordTextBox_Enter);
            this.passwordTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passwordTextBox_KeyDown);
            this.passwordTextBox.Leave += new System.EventHandler(this.passwordTextBox_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label4.Location = new System.Drawing.Point(1, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 24);
            this.label4.TabIndex = 26;
            this.label4.Text = "Password:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.emailTextBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(211, 201);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(363, 56);
            this.panel1.TabIndex = 35;
            // 
            // emailTextBox
            // 
            this.emailTextBox.AccessibleDescription = "";
            this.emailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.emailTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.emailTextBox.Location = new System.Drawing.Point(102, 18);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(202, 26);
            this.emailTextBox.TabIndex = 1;
            this.emailTextBox.Text = "Enter your email address";
            this.emailTextBox.Enter += new System.EventHandler(this.emailTextBox_Enter);
            this.emailTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.emailTextBox_KeyDown);
            this.emailTextBox.Leave += new System.EventHandler(this.emailTextBox_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label3.Location = new System.Drawing.Point(36, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 24);
            this.label3.TabIndex = 25;
            this.label3.Text = "Email:";
            // 
            // authorizationMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(784, 661);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.remainTime);
            this.Controls.Add(this.footerBlock);
            this.Controls.Add(this.backToMainMenu);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.headerBlock);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "authorizationMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WorldSkills Marathon ● Autorization";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.autorizationMenu_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.headerBlock)).EndInit();
            this.remainTime.ResumeLayout(false);
            this.remainTime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.footerBlock)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button autorizationLogin;
        private System.Windows.Forms.Button autorizationCancel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label label3;
    }
}