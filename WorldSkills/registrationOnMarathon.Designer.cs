namespace WorldSkills
{
    partial class registrationOnMarathon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(registrationOnMarathon));
            this.backToMainMenu = new System.Windows.Forms.Button();
            this.remainTime = new System.Windows.Forms.Panel();
            this.hoursCount = new System.Windows.Forms.Label();
            this.remainText = new System.Windows.Forms.Label();
            this.and = new System.Windows.Forms.Label();
            this.minutesCount = new System.Windows.Forms.Label();
            this.daysCount = new System.Windows.Forms.Label();
            this.minutes = new System.Windows.Forms.Label();
            this.hours = new System.Windows.Forms.Label();
            this.days = new System.Windows.Forms.Label();
            this.Header = new System.Windows.Forms.Label();
            this.remainTimer = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.registerHeadText = new System.Windows.Forms.Label();
            this.registrationInfo = new System.Windows.Forms.Label();
            this.viewMarathonText = new System.Windows.Forms.Label();
            this.varSetsText = new System.Windows.Forms.Label();
            this.fullMarathonCB = new System.Windows.Forms.CheckBox();
            this.detailSponsorText = new System.Windows.Forms.Label();
            this.regContributionText = new System.Windows.Forms.Label();
            this.halfMarathonCB = new System.Windows.Forms.CheckBox();
            this.smallMarathonCB = new System.Windows.Forms.CheckBox();
            this.varA = new System.Windows.Forms.RadioButton();
            this.varB = new System.Windows.Forms.RadioButton();
            this.varC = new System.Windows.Forms.RadioButton();
            this.contribution = new System.Windows.Forms.Label();
            this.sumContribution = new System.Windows.Forms.Label();
            this.contributionComboBox = new System.Windows.Forms.ComboBox();
            this.sumContributionTextBox = new System.Windows.Forms.TextBox();
            this.dollar = new System.Windows.Forms.Label();
            this.finSumContribution = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.infoPic = new System.Windows.Forms.PictureBox();
            this.footerBlock = new System.Windows.Forms.PictureBox();
            this.headerBlock = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.remainTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.footerBlock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.headerBlock)).BeginInit();
            this.SuspendLayout();
            // 
            // backToMainMenu
            // 
            this.backToMainMenu.Location = new System.Drawing.Point(11, 9);
            this.backToMainMenu.Name = "backToMainMenu";
            this.backToMainMenu.Size = new System.Drawing.Size(72, 26);
            this.backToMainMenu.TabIndex = 21;
            this.backToMainMenu.Text = "Назад";
            this.backToMainMenu.UseVisualStyleBackColor = true;
            this.backToMainMenu.Click += new System.EventHandler(this.backToMainMenu_Click);
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
            this.remainTime.Location = new System.Drawing.Point(151, 628);
            this.remainTime.Name = "remainTime";
            this.remainTime.Size = new System.Drawing.Size(483, 31);
            this.remainTime.TabIndex = 25;
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
            // Header
            // 
            this.Header.AutoSize = true;
            this.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Header.Font = new System.Drawing.Font("Arial", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Header.ForeColor = System.Drawing.Color.White;
            this.Header.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Header.Location = new System.Drawing.Point(89, 8);
            this.Header.Name = "Header";
            this.Header.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Header.Size = new System.Drawing.Size(298, 28);
            this.Header.TabIndex = 23;
            this.Header.Text = "MARATHON SKILLS 2016";
            this.Header.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Header.UseMnemonic = false;
            // 
            // remainTimer
            // 
            this.remainTimer.Enabled = true;
            this.remainTimer.Interval = 1;
            this.remainTimer.Tick += new System.EventHandler(this.remainTimer_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(700, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 26);
            this.button1.TabIndex = 26;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // registerHeadText
            // 
            this.registerHeadText.AutoSize = true;
            this.registerHeadText.Font = new System.Drawing.Font("Arial", 16F);
            this.registerHeadText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.registerHeadText.Location = new System.Drawing.Point(258, 74);
            this.registerHeadText.Name = "registerHeadText";
            this.registerHeadText.Size = new System.Drawing.Size(269, 25);
            this.registerHeadText.TabIndex = 32;
            this.registerHeadText.Text = "Регистрация на марафон";
            // 
            // registrationInfo
            // 
            this.registrationInfo.AutoSize = true;
            this.registrationInfo.Font = new System.Drawing.Font("Arial", 12F);
            this.registrationInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.registrationInfo.Location = new System.Drawing.Point(106, 121);
            this.registrationInfo.Name = "registrationInfo";
            this.registrationInfo.Size = new System.Drawing.Size(572, 54);
            this.registrationInfo.TabIndex = 33;
            this.registrationInfo.Text = "Пожалуйста заполните всю информацию, чтобы зарегистрироваться на Skills\r\nMarathon" +
    " 2016 проводимом в Москве. Russia. С вами свяжутся после\r\nрегистрация для уточне" +
    "ния оплаты и другой информации.";
            this.registrationInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // viewMarathonText
            // 
            this.viewMarathonText.AutoSize = true;
            this.viewMarathonText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.viewMarathonText.ForeColor = System.Drawing.Color.Gray;
            this.viewMarathonText.Location = new System.Drawing.Point(105, 236);
            this.viewMarathonText.Name = "viewMarathonText";
            this.viewMarathonText.Size = new System.Drawing.Size(136, 20);
            this.viewMarathonText.TabIndex = 34;
            this.viewMarathonText.Text = "Вид марафона";
            // 
            // varSetsText
            // 
            this.varSetsText.AutoSize = true;
            this.varSetsText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.varSetsText.ForeColor = System.Drawing.Color.Gray;
            this.varSetsText.Location = new System.Drawing.Point(491, 236);
            this.varSetsText.Name = "varSetsText";
            this.varSetsText.Size = new System.Drawing.Size(199, 20);
            this.varSetsText.TabIndex = 35;
            this.varSetsText.Text = "Варианты комплектов";
            // 
            // fullMarathonCB
            // 
            this.fullMarathonCB.AutoSize = true;
            this.fullMarathonCB.Checked = true;
            this.fullMarathonCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.fullMarathonCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fullMarathonCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.fullMarathonCB.Location = new System.Drawing.Point(59, 282);
            this.fullMarathonCB.Name = "fullMarathonCB";
            this.fullMarathonCB.Size = new System.Drawing.Size(258, 24);
            this.fullMarathonCB.TabIndex = 36;
            this.fullMarathonCB.Text = "42km Полный Марафон ($145)";
            this.fullMarathonCB.UseVisualStyleBackColor = true;
            this.fullMarathonCB.Click += new System.EventHandler(this.fullMarathonCB_Click);
            // 
            // detailSponsorText
            // 
            this.detailSponsorText.AutoSize = true;
            this.detailSponsorText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.detailSponsorText.ForeColor = System.Drawing.Color.Gray;
            this.detailSponsorText.Location = new System.Drawing.Point(81, 402);
            this.detailSponsorText.Name = "detailSponsorText";
            this.detailSponsorText.Size = new System.Drawing.Size(185, 20);
            this.detailSponsorText.TabIndex = 37;
            this.detailSponsorText.Text = "Детали спонсорства";
            // 
            // regContributionText
            // 
            this.regContributionText.AutoSize = true;
            this.regContributionText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regContributionText.ForeColor = System.Drawing.Color.Gray;
            this.regContributionText.Location = new System.Drawing.Point(478, 469);
            this.regContributionText.Name = "regContributionText";
            this.regContributionText.Size = new System.Drawing.Size(212, 20);
            this.regContributionText.TabIndex = 38;
            this.regContributionText.Text = "Регистрационный взнос";
            // 
            // halfMarathonCB
            // 
            this.halfMarathonCB.AutoSize = true;
            this.halfMarathonCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.halfMarathonCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.halfMarathonCB.Location = new System.Drawing.Point(59, 315);
            this.halfMarathonCB.Name = "halfMarathonCB";
            this.halfMarathonCB.Size = new System.Drawing.Size(221, 24);
            this.halfMarathonCB.TabIndex = 39;
            this.halfMarathonCB.Text = "21km Полумарафон ($75)";
            this.halfMarathonCB.UseVisualStyleBackColor = true;
            this.halfMarathonCB.Click += new System.EventHandler(this.halfMarathonCB_Click);
            // 
            // smallMarathonCB
            // 
            this.smallMarathonCB.AutoSize = true;
            this.smallMarathonCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.smallMarathonCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.smallMarathonCB.Location = new System.Drawing.Point(59, 348);
            this.smallMarathonCB.Name = "smallMarathonCB";
            this.smallMarathonCB.Size = new System.Drawing.Size(240, 24);
            this.smallMarathonCB.TabIndex = 40;
            this.smallMarathonCB.Text = "5km Малая Дистанция ($20)";
            this.smallMarathonCB.UseVisualStyleBackColor = true;
            this.smallMarathonCB.Click += new System.EventHandler(this.smallMarathonCB_Click);
            // 
            // varA
            // 
            this.varA.AutoSize = true;
            this.varA.Checked = true;
            this.varA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.varA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.varA.Location = new System.Drawing.Point(469, 282);
            this.varA.Name = "varA";
            this.varA.Size = new System.Drawing.Size(264, 44);
            this.varA.TabIndex = 41;
            this.varA.TabStop = true;
            this.varA.Text = "Вариант А ($0): Номер бегуна +\r\nRFID браслет";
            this.varA.UseVisualStyleBackColor = true;
            this.varA.Click += new System.EventHandler(this.varA_Click);
            // 
            // varB
            // 
            this.varB.AutoSize = true;
            this.varB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.varB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.varB.Location = new System.Drawing.Point(469, 332);
            this.varB.Name = "varB";
            this.varB.Size = new System.Drawing.Size(247, 44);
            this.varB.TabIndex = 42;
            this.varB.Text = "Вариант B ($20): вариант A +\r\nбейсболка + бутылка воды.";
            this.varB.UseVisualStyleBackColor = true;
            this.varB.Click += new System.EventHandler(this.varB_Click);
            // 
            // varC
            // 
            this.varC.AutoSize = true;
            this.varC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.varC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.varC.Location = new System.Drawing.Point(469, 382);
            this.varC.Name = "varC";
            this.varC.Size = new System.Drawing.Size(269, 44);
            this.varC.TabIndex = 43;
            this.varC.Text = "Вариант C ($45): вариант B +\r\nфутболка + сувенирный буклет.";
            this.varC.UseVisualStyleBackColor = true;
            this.varC.Click += new System.EventHandler(this.varC_Click);
            // 
            // contribution
            // 
            this.contribution.AutoSize = true;
            this.contribution.Font = new System.Drawing.Font("Arial", 14F);
            this.contribution.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.contribution.Location = new System.Drawing.Point(81, 467);
            this.contribution.Name = "contribution";
            this.contribution.Size = new System.Drawing.Size(68, 22);
            this.contribution.TabIndex = 44;
            this.contribution.Text = "Взнос:";
            // 
            // sumContribution
            // 
            this.sumContribution.AutoSize = true;
            this.sumContribution.Font = new System.Drawing.Font("Arial", 14F);
            this.sumContribution.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.sumContribution.Location = new System.Drawing.Point(10, 515);
            this.sumContribution.Name = "sumContribution";
            this.sumContribution.Size = new System.Drawing.Size(139, 22);
            this.sumContribution.TabIndex = 45;
            this.sumContribution.Text = "Сумма взноса:";
            // 
            // contributionComboBox
            // 
            this.contributionComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Фонд кошек"});
            this.contributionComboBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.contributionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.contributionComboBox.Enabled = false;
            this.contributionComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.contributionComboBox.FormattingEnabled = true;
            this.contributionComboBox.Items.AddRange(new object[] {
            "Фонд кошек"});
            this.contributionComboBox.Location = new System.Drawing.Point(149, 466);
            this.contributionComboBox.Name = "contributionComboBox";
            this.contributionComboBox.Size = new System.Drawing.Size(150, 28);
            this.contributionComboBox.TabIndex = 46;
            this.contributionComboBox.SelectedIndexChanged += new System.EventHandler(this.contributionComboBox_SelectedIndexChanged);
            // 
            // sumContributionTextBox
            // 
            this.sumContributionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.sumContributionTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.sumContributionTextBox.Location = new System.Drawing.Point(149, 514);
            this.sumContributionTextBox.Name = "sumContributionTextBox";
            this.sumContributionTextBox.Size = new System.Drawing.Size(150, 26);
            this.sumContributionTextBox.TabIndex = 47;
            this.sumContributionTextBox.Text = "$500";
            this.sumContributionTextBox.Enter += new System.EventHandler(this.sumContributionTextBox_Enter);
            this.sumContributionTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sumContributionTextBox_KeyPress);
            this.sumContributionTextBox.Leave += new System.EventHandler(this.sumContributionTextBox_Leave);
            // 
            // dollar
            // 
            this.dollar.AutoSize = true;
            this.dollar.Font = new System.Drawing.Font("Microsoft Sans Serif", 56F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dollar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.dollar.Location = new System.Drawing.Point(480, 507);
            this.dollar.Name = "dollar";
            this.dollar.Size = new System.Drawing.Size(79, 85);
            this.dollar.TabIndex = 48;
            this.dollar.Text = "$";
            // 
            // finSumContribution
            // 
            this.finSumContribution.AutoSize = true;
            this.finSumContribution.Font = new System.Drawing.Font("Microsoft Sans Serif", 56F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.finSumContribution.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.finSumContribution.Location = new System.Drawing.Point(537, 507);
            this.finSumContribution.Name = "finSumContribution";
            this.finSumContribution.Size = new System.Drawing.Size(163, 85);
            this.finSumContribution.TabIndex = 49;
            this.finSumContribution.Text = "145";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.button2.Location = new System.Drawing.Point(24, 564);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 28);
            this.button2.TabIndex = 50;
            this.button2.Text = "Регистрация";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.button3.Location = new System.Drawing.Point(173, 564);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(93, 28);
            this.button3.TabIndex = 51;
            this.button3.Text = "Отмена";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // infoPic
            // 
            this.infoPic.Image = global::WorldSkills.Properties.Resources.info_icon1;
            this.infoPic.Location = new System.Drawing.Point(307, 466);
            this.infoPic.Name = "infoPic";
            this.infoPic.Size = new System.Drawing.Size(28, 28);
            this.infoPic.TabIndex = 52;
            this.infoPic.TabStop = false;
            // 
            // footerBlock
            // 
            this.footerBlock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.footerBlock.Location = new System.Drawing.Point(-1, 623);
            this.footerBlock.Name = "footerBlock";
            this.footerBlock.Size = new System.Drawing.Size(786, 39);
            this.footerBlock.TabIndex = 24;
            this.footerBlock.TabStop = false;
            // 
            // headerBlock
            // 
            this.headerBlock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.headerBlock.Location = new System.Drawing.Point(0, 0);
            this.headerBlock.Name = "headerBlock";
            this.headerBlock.Size = new System.Drawing.Size(784, 46);
            this.headerBlock.TabIndex = 22;
            this.headerBlock.TabStop = false;
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // registrationOnMarathon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(784, 661);
            this.Controls.Add(this.infoPic);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.finSumContribution);
            this.Controls.Add(this.dollar);
            this.Controls.Add(this.sumContributionTextBox);
            this.Controls.Add(this.contributionComboBox);
            this.Controls.Add(this.sumContribution);
            this.Controls.Add(this.contribution);
            this.Controls.Add(this.varC);
            this.Controls.Add(this.varB);
            this.Controls.Add(this.varA);
            this.Controls.Add(this.smallMarathonCB);
            this.Controls.Add(this.halfMarathonCB);
            this.Controls.Add(this.regContributionText);
            this.Controls.Add(this.detailSponsorText);
            this.Controls.Add(this.fullMarathonCB);
            this.Controls.Add(this.varSetsText);
            this.Controls.Add(this.viewMarathonText);
            this.Controls.Add(this.registrationInfo);
            this.Controls.Add(this.registerHeadText);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.backToMainMenu);
            this.Controls.Add(this.remainTime);
            this.Controls.Add(this.footerBlock);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.headerBlock);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "registrationOnMarathon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WorldSkills Marathon ● Registration For An Event";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.registrationOnMarathon_FormClosed);
            this.Load += new System.EventHandler(this.registrationOnMarathon_Load);
            this.remainTime.ResumeLayout(false);
            this.remainTime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.footerBlock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.headerBlock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backToMainMenu;
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
        private System.Windows.Forms.Label Header;
        private System.Windows.Forms.PictureBox headerBlock;
        private System.Windows.Forms.Timer remainTimer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label registerHeadText;
        private System.Windows.Forms.Label registrationInfo;
        private System.Windows.Forms.Label viewMarathonText;
        private System.Windows.Forms.Label varSetsText;
        private System.Windows.Forms.CheckBox fullMarathonCB;
        private System.Windows.Forms.Label detailSponsorText;
        private System.Windows.Forms.Label regContributionText;
        private System.Windows.Forms.CheckBox halfMarathonCB;
        private System.Windows.Forms.CheckBox smallMarathonCB;
        private System.Windows.Forms.RadioButton varA;
        private System.Windows.Forms.RadioButton varB;
        private System.Windows.Forms.RadioButton varC;
        private System.Windows.Forms.Label contribution;
        private System.Windows.Forms.Label sumContribution;
        private System.Windows.Forms.ComboBox contributionComboBox;
        private System.Windows.Forms.TextBox sumContributionTextBox;
        private System.Windows.Forms.Label dollar;
        private System.Windows.Forms.Label finSumContribution;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox infoPic;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}