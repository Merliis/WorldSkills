namespace WorldSkills
{
    partial class MainMenu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.Header = new System.Windows.Forms.Label();
            this.HeaderDescription = new System.Windows.Forms.Label();
            this.sponsorshipButton = new System.Windows.Forms.Button();
            this.aboutInfButton = new System.Windows.Forms.Button();
            this.runnerRegButton = new System.Windows.Forms.Button();
            this.days = new System.Windows.Forms.Label();
            this.hours = new System.Windows.Forms.Label();
            this.minutes = new System.Windows.Forms.Label();
            this.daysCount = new System.Windows.Forms.Label();
            this.remainTimer = new System.Windows.Forms.Timer(this.components);
            this.hoursCount = new System.Windows.Forms.Label();
            this.minutesCount = new System.Windows.Forms.Label();
            this.remainTime = new System.Windows.Forms.Panel();
            this.remainText = new System.Windows.Forms.Label();
            this.and = new System.Windows.Forms.Label();
            this.footerBlock = new System.Windows.Forms.PictureBox();
            this.headerBlock = new System.Windows.Forms.PictureBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.linkToVK = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.формыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runnerMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autorizationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coordMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regRunnerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMarathonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BMIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.remainTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.footerBlock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.headerBlock)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.AutoSize = true;
            this.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Header.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Header.ForeColor = System.Drawing.Color.White;
            this.Header.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Header.Location = new System.Drawing.Point(158, 26);
            this.Header.Name = "Header";
            this.Header.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Header.Size = new System.Drawing.Size(471, 44);
            this.Header.TabIndex = 1;
            this.Header.Text = "MARATHON SKILLS 2016";
            this.Header.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Header.UseMnemonic = false;
            // 
            // HeaderDescription
            // 
            this.HeaderDescription.AutoSize = true;
            this.HeaderDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.HeaderDescription.Font = new System.Drawing.Font("Arial Unicode MS", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HeaderDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.HeaderDescription.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.HeaderDescription.Location = new System.Drawing.Point(260, 85);
            this.HeaderDescription.Name = "HeaderDescription";
            this.HeaderDescription.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.HeaderDescription.Size = new System.Drawing.Size(266, 66);
            this.HeaderDescription.TabIndex = 2;
            this.HeaderDescription.Text = "Москва, Россия\r\nсреда 21 октября 2016";
            this.HeaderDescription.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.HeaderDescription.UseMnemonic = false;
            // 
            // sponsorshipButton
            // 
            this.sponsorshipButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.sponsorshipButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.sponsorshipButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.sponsorshipButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.sponsorshipButton.Location = new System.Drawing.Point(259, 329);
            this.sponsorshipButton.Name = "sponsorshipButton";
            this.sponsorshipButton.Size = new System.Drawing.Size(268, 79);
            this.sponsorshipButton.TabIndex = 4;
            this.sponsorshipButton.Text = "Я хочу стать спонсором бегуна";
            this.sponsorshipButton.UseVisualStyleBackColor = false;
            // 
            // aboutInfButton
            // 
            this.aboutInfButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.aboutInfButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.aboutInfButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.aboutInfButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.aboutInfButton.ForeColor = System.Drawing.Color.Black;
            this.aboutInfButton.Location = new System.Drawing.Point(259, 435);
            this.aboutInfButton.Name = "aboutInfButton";
            this.aboutInfButton.Size = new System.Drawing.Size(268, 79);
            this.aboutInfButton.TabIndex = 1;
            this.aboutInfButton.Text = "Я хочу узнать больше о событии";
            this.aboutInfButton.UseVisualStyleBackColor = false;
            this.aboutInfButton.Click += new System.EventHandler(this.aboutInfButton_Click);
            // 
            // runnerRegButton
            // 
            this.runnerRegButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.runnerRegButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.runnerRegButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.runnerRegButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.runnerRegButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.runnerRegButton.Location = new System.Drawing.Point(259, 225);
            this.runnerRegButton.Name = "runnerRegButton";
            this.runnerRegButton.Size = new System.Drawing.Size(268, 79);
            this.runnerRegButton.TabIndex = 10;
            this.runnerRegButton.Text = "Я хочу стать бегуном";
            this.runnerRegButton.UseVisualStyleBackColor = false;
            this.runnerRegButton.Click += new System.EventHandler(this.runnerRegButton_Click);
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
            // remainTimer
            // 
            this.remainTimer.Enabled = true;
            this.remainTimer.Interval = 1;
            this.remainTimer.Tick += new System.EventHandler(this.remainTimer_Tick);
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
            this.remainTime.Location = new System.Drawing.Point(133, 627);
            this.remainTime.Name = "remainTime";
            this.remainTime.Size = new System.Drawing.Size(514, 31);
            this.remainTime.TabIndex = 18;
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
            // footerBlock
            // 
            this.footerBlock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.footerBlock.Location = new System.Drawing.Point(0, 623);
            this.footerBlock.Name = "footerBlock";
            this.footerBlock.Size = new System.Drawing.Size(786, 39);
            this.footerBlock.TabIndex = 6;
            this.footerBlock.TabStop = false;
            // 
            // headerBlock
            // 
            this.headerBlock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.headerBlock.Location = new System.Drawing.Point(0, 0);
            this.headerBlock.Name = "headerBlock";
            this.headerBlock.Size = new System.Drawing.Size(786, 186);
            this.headerBlock.TabIndex = 0;
            this.headerBlock.TabStop = false;
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.loginButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.loginButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.loginButton.Location = new System.Drawing.Point(648, 568);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(124, 40);
            this.loginButton.TabIndex = 7;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // linkToVK
            // 
            this.linkToVK.AutoSize = true;
            this.linkToVK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.linkToVK.ForeColor = System.Drawing.Color.Silver;
            this.linkToVK.Location = new System.Drawing.Point(-2, 605);
            this.linkToVK.Name = "linkToVK";
            this.linkToVK.Size = new System.Drawing.Size(164, 17);
            this.linkToVK.TabIndex = 19;
            this.linkToVK.Text = "Created by Provice Unity";
            this.linkToVK.Click += new System.EventHandler(this.linkToVK_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.формыToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(155, 23);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // формыToolStripMenuItem
            // 
            this.формыToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.формыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.runnerMenuToolStripMenuItem,
            this.aboutInformationToolStripMenuItem,
            this.autorizationToolStripMenuItem,
            this.coordMenuToolStripMenuItem,
            this.adminMenuToolStripMenuItem,
            this.regRunnerToolStripMenuItem,
            this.aboutMarathonToolStripMenuItem,
            this.BMIToolStripMenuItem,
            this.registrationToolStripMenuItem,});
            this.формыToolStripMenuItem.Name = "формыToolStripMenuItem";
            this.формыToolStripMenuItem.Size = new System.Drawing.Size(60, 19);
            this.формыToolStripMenuItem.Text = "Формы";
            // 
            // runnerMenuToolStripMenuItem
            // 
            this.runnerMenuToolStripMenuItem.Name = "runnerMenuToolStripMenuItem";
            this.runnerMenuToolStripMenuItem.ShowShortcutKeys = false;
            this.runnerMenuToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.runnerMenuToolStripMenuItem.Text = "Runner Menu";
            this.runnerMenuToolStripMenuItem.Click += new System.EventHandler(this.runnerMenuToolStripMenuItem_Click);
            // 
            // aboutInformationToolStripMenuItem
            // 
            this.aboutInformationToolStripMenuItem.Name = "aboutInformationToolStripMenuItem";
            this.aboutInformationToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.aboutInformationToolStripMenuItem.Text = "About Information";
            this.aboutInformationToolStripMenuItem.Click += new System.EventHandler(this.aboutInformationToolStripMenuItem_Click);
            // 
            // autorizationToolStripMenuItem
            // 
            this.autorizationToolStripMenuItem.Name = "autorizationToolStripMenuItem";
            this.autorizationToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.autorizationToolStripMenuItem.Text = "Autorization";
            this.autorizationToolStripMenuItem.Click += new System.EventHandler(this.autorizationToolStripMenuItem_Click);
            // 
            // coordMenuToolStripMenuItem
            // 
            this.coordMenuToolStripMenuItem.Name = "coordMenuToolStripMenuItem";
            this.coordMenuToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.coordMenuToolStripMenuItem.Text = "Coord Menu";
            this.coordMenuToolStripMenuItem.Click += new System.EventHandler(this.coordMenuToolStripMenuItem_Click);
            // 
            // adminMenuToolStripMenuItem
            // 
            this.adminMenuToolStripMenuItem.Name = "adminMenuToolStripMenuItem";
            this.adminMenuToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.adminMenuToolStripMenuItem.Text = "Admin Menu";
            this.adminMenuToolStripMenuItem.Click += new System.EventHandler(this.adminMenuToolStripMenuItem_Click);
            // 
            // regRunnerToolStripMenuItem
            // 
            this.regRunnerToolStripMenuItem.Name = "regRunnerToolStripMenuItem";
            this.regRunnerToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.regRunnerToolStripMenuItem.Text = "Reg As Runner";
            this.regRunnerToolStripMenuItem.Click += new System.EventHandler(this.regRunnerToolStripMenuItem_Click);
            // 
            // aboutMarathonToolStripMenuItem
            // 
            this.aboutMarathonToolStripMenuItem.Name = "aboutMarathonToolStripMenuItem";
            this.aboutMarathonToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.aboutMarathonToolStripMenuItem.Text = "About Marathon";
            this.aboutMarathonToolStripMenuItem.Click += new System.EventHandler(this.aboutMarathonToolStripMenuItem_Click);
            // 
            // BMIToolStripMenuItem
            // 
            this.BMIToolStripMenuItem.Name = "BMIToolStripMenuItem";
            this.BMIToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.BMIToolStripMenuItem.Text = "BMI";
            this.BMIToolStripMenuItem.Click += new System.EventHandler(this.BMIToolStripMenuItem_Click);
            // 
            // registrationToolStripMenuItem
            // 
            this.registrationToolStripMenuItem.Name = "registrationToolStripMenuItem";
            this.registrationToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.registrationToolStripMenuItem.Text = "Registration";
            this.registrationToolStripMenuItem.Click += new System.EventHandler(this.registrationToolStripMenuItem_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 661);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.linkToVK);
            this.Controls.Add(this.remainTime);
            this.Controls.Add(this.runnerRegButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.footerBlock);
            this.Controls.Add(this.aboutInfButton);
            this.Controls.Add(this.sponsorshipButton);
            this.Controls.Add(this.HeaderDescription);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.headerBlock);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WorldSkills Marathon";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainMenu_FormClosed);
            this.remainTime.ResumeLayout(false);
            this.remainTime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.footerBlock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.headerBlock)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox headerBlock;
        private System.Windows.Forms.Label Header;
        private System.Windows.Forms.Label HeaderDescription;
        private System.Windows.Forms.Button sponsorshipButton;
        private System.Windows.Forms.Button aboutInfButton;
        private System.Windows.Forms.PictureBox footerBlock;
        private System.Windows.Forms.Button runnerRegButton;
        private System.Windows.Forms.Label days;
        private System.Windows.Forms.Label hours;
        private System.Windows.Forms.Label minutes;
        private System.Windows.Forms.Label daysCount;
        private System.Windows.Forms.Timer remainTimer;
        private System.Windows.Forms.Label hoursCount;
        private System.Windows.Forms.Label minutesCount;
        private System.Windows.Forms.Panel remainTime;
        private System.Windows.Forms.Label and;
        private System.Windows.Forms.Label remainText;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem формыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runnerMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autorizationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coordMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regRunnerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutMarathonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BMIToolStripMenuItem;
        private System.Windows.Forms.Label linkToVK;
        private System.Windows.Forms.ToolStripMenuItem registrationToolStripMenuItem;
    }
}

