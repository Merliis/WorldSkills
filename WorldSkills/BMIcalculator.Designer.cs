namespace WorldSkills
{
    partial class BMIcalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BMIcalculator));
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
            this.runnerMenuText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.height = new System.Windows.Forms.TextBox();
            this.weight = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.calc = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.BMIresult = new System.Windows.Forms.Label();
            this.arrowBox = new System.Windows.Forms.Panel();
            this.arrow = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.female = new System.Windows.Forms.Button();
            this.male = new System.Windows.Forms.Button();
            this.headerBlock = new System.Windows.Forms.PictureBox();
            this.footerBlock = new System.Windows.Forms.PictureBox();
            this.remainTime.SuspendLayout();
            this.arrowBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.arrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.headerBlock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.footerBlock)).BeginInit();
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
            this.Header.Location = new System.Drawing.Point(89, 8);
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
            // runnerMenuText
            // 
            this.runnerMenuText.AutoSize = true;
            this.runnerMenuText.Font = new System.Drawing.Font("Arial", 16F);
            this.runnerMenuText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.runnerMenuText.Location = new System.Drawing.Point(299, 74);
            this.runnerMenuText.Name = "runnerMenuText";
            this.runnerMenuText.Size = new System.Drawing.Size(186, 25);
            this.runnerMenuText.TabIndex = 31;
            this.runnerMenuText.Text = "BMI калькулятор";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Help;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Underline);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label1.Location = new System.Drawing.Point(35, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 36);
            this.label1.TabIndex = 32;
            this.label1.Text = "Информация о том, что такое BMI калькулятор и\r\nкак калькулятор работает";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label2.Location = new System.Drawing.Point(93, 327);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 18);
            this.label2.TabIndex = 35;
            this.label2.Text = "Рост:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label3.Location = new System.Drawing.Point(99, 358);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 18);
            this.label3.TabIndex = 36;
            this.label3.Text = "Вес:";
            // 
            // height
            // 
            this.height.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.height.Location = new System.Drawing.Point(140, 323);
            this.height.MaxLength = 3;
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(46, 26);
            this.height.TabIndex = 1;
            this.height.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.height.TextChanged += new System.EventHandler(this.height_TextChanged);
            this.height.KeyDown += new System.Windows.Forms.KeyEventHandler(this.height_KeyDown);
            this.height.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.height_KeyPress);
            // 
            // weight
            // 
            this.weight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.weight.Location = new System.Drawing.Point(140, 354);
            this.weight.MaxLength = 3;
            this.weight.Name = "weight";
            this.weight.Size = new System.Drawing.Size(46, 26);
            this.weight.TabIndex = 2;
            this.weight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.weight.KeyDown += new System.Windows.Forms.KeyEventHandler(this.weight_KeyDown);
            this.weight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.weight_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label4.Location = new System.Drawing.Point(192, 327);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 18);
            this.label4.TabIndex = 39;
            this.label4.Text = "см";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label5.Location = new System.Drawing.Point(192, 358);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 18);
            this.label5.TabIndex = 40;
            this.label5.Text = "кг";
            // 
            // calc
            // 
            this.calc.Location = new System.Drawing.Point(42, 407);
            this.calc.Name = "calc";
            this.calc.Size = new System.Drawing.Size(92, 31);
            this.calc.TabIndex = 3;
            this.calc.Text = "Рассчитать";
            this.calc.UseVisualStyleBackColor = true;
            this.calc.Click += new System.EventHandler(this.calc_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(192, 407);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(92, 31);
            this.cancel.TabIndex = 4;
            this.cancel.Text = "Отмена";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label6.Location = new System.Drawing.Point(359, 589);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 15);
            this.label6.TabIndex = 45;
            this.label6.Text = "Недостаточный";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label7.Location = new System.Drawing.Point(470, 589);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 15);
            this.label7.TabIndex = 46;
            this.label7.Text = "Здоровый";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label8.Location = new System.Drawing.Point(563, 589);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 15);
            this.label8.TabIndex = 47;
            this.label8.Text = "Избыточный";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label9.Location = new System.Drawing.Point(675, 589);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 15);
            this.label9.TabIndex = 48;
            this.label9.Text = "Ожирение";
            // 
            // BMIresult
            // 
            this.BMIresult.AutoSize = true;
            this.BMIresult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BMIresult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.BMIresult.Location = new System.Drawing.Point(7, 22);
            this.BMIresult.Name = "BMIresult";
            this.BMIresult.Size = new System.Drawing.Size(40, 20);
            this.BMIresult.TabIndex = 50;
            this.BMIresult.Text = "00,0";
            this.BMIresult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // arrowBox
            // 
            this.arrowBox.Controls.Add(this.BMIresult);
            this.arrowBox.Controls.Add(this.arrow);
            this.arrowBox.Location = new System.Drawing.Point(326, 489);
            this.arrowBox.Name = "arrowBox";
            this.arrowBox.Size = new System.Drawing.Size(54, 87);
            this.arrowBox.TabIndex = 51;
            // 
            // arrow
            // 
            this.arrow.Image = ((System.Drawing.Image)(resources.GetObject("arrow.Image")));
            this.arrow.Location = new System.Drawing.Point(14, 55);
            this.arrow.Name = "arrow";
            this.arrow.Size = new System.Drawing.Size(26, 26);
            this.arrow.TabIndex = 49;
            this.arrow.TabStop = false;
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 10000;
            this.toolTip1.BackColor = System.Drawing.Color.White;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 100;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(352, 576);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(400, 10);
            this.pictureBox2.TabIndex = 44;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(486, 148);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(209, 311);
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            // 
            // female
            // 
            this.female.BackColor = System.Drawing.Color.White;
            this.female.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.female.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.female.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.female.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.female.Image = ((System.Drawing.Image)(resources.GetObject("female.Image")));
            this.female.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.female.Location = new System.Drawing.Point(180, 205);
            this.female.Name = "female";
            this.female.Size = new System.Drawing.Size(108, 99);
            this.female.TabIndex = 34;
            this.female.Text = "Женский";
            this.female.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.female.UseVisualStyleBackColor = false;
            this.female.Click += new System.EventHandler(this.female_Click);
            // 
            // male
            // 
            this.male.BackColor = System.Drawing.Color.White;
            this.male.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.male.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.male.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.male.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.male.Image = ((System.Drawing.Image)(resources.GetObject("male.Image")));
            this.male.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.male.Location = new System.Drawing.Point(43, 205);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(108, 99);
            this.male.TabIndex = 33;
            this.male.Text = "Мужской";
            this.male.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.male.UseVisualStyleBackColor = false;
            this.male.Click += new System.EventHandler(this.male_Click);
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
            // BMIcalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(784, 661);
            this.Controls.Add(this.arrowBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.calc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.weight);
            this.Controls.Add(this.height);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.female);
            this.Controls.Add(this.male);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.runnerMenuText);
            this.Controls.Add(this.backToMainMenu);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.headerBlock);
            this.Controls.Add(this.remainTime);
            this.Controls.Add(this.footerBlock);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "BMIcalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WorldSkills Marathon ● BMI Calculator";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BMIcalculator_FormClosed);
            this.Load += new System.EventHandler(this.BMIcalculator_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BMIcalculator_KeyDown);
            this.remainTime.ResumeLayout(false);
            this.remainTime.PerformLayout();
            this.arrowBox.ResumeLayout(false);
            this.arrowBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.arrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.headerBlock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.footerBlock)).EndInit();
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
        private System.Windows.Forms.Label runnerMenuText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button male;
        private System.Windows.Forms.Button female;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox height;
        private System.Windows.Forms.TextBox weight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button calc;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox arrow;
        private System.Windows.Forms.Label BMIresult;
        private System.Windows.Forms.Panel arrowBox;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}