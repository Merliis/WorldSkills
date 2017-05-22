namespace WorldSkills
{
    partial class BMRcalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BMRcalculator));
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
            this.cancel = new System.Windows.Forms.Button();
            this.calc = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.weight = new System.Windows.Forms.TextBox();
            this.height = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.female = new System.Windows.Forms.Button();
            this.male = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.runnerMenuText = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.Minimum = new System.Windows.Forms.Label();
            this.Low = new System.Windows.Forms.Label();
            this.Average = new System.Windows.Forms.Label();
            this.Tall = new System.Windows.Forms.Label();
            this.VeryTall = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.headerBlock)).BeginInit();
            this.remainTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.footerBlock)).BeginInit();
            this.SuspendLayout();
            // 
            // backToMainMenu
            // 
            this.backToMainMenu.Location = new System.Drawing.Point(11, 9);
            this.backToMainMenu.Name = "backToMainMenu";
            this.backToMainMenu.Size = new System.Drawing.Size(72, 26);
            this.backToMainMenu.TabIndex = 29;
            this.backToMainMenu.Text = "Назад";
            this.backToMainMenu.UseVisualStyleBackColor = true;
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
            this.Header.TabIndex = 31;
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
            this.headerBlock.TabIndex = 30;
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
            this.remainTime.Location = new System.Drawing.Point(151, 627);
            this.remainTime.Name = "remainTime";
            this.remainTime.Size = new System.Drawing.Size(483, 31);
            this.remainTime.TabIndex = 33;
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
            this.footerBlock.Location = new System.Drawing.Point(-1, 622);
            this.footerBlock.Name = "footerBlock";
            this.footerBlock.Size = new System.Drawing.Size(786, 39);
            this.footerBlock.TabIndex = 32;
            this.footerBlock.TabStop = false;
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(192, 446);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(92, 31);
            this.cancel.TabIndex = 44;
            this.cancel.Text = "Отмена";
            this.cancel.UseVisualStyleBackColor = true;
            // 
            // calc
            // 
            this.calc.Location = new System.Drawing.Point(42, 446);
            this.calc.Name = "calc";
            this.calc.Size = new System.Drawing.Size(92, 31);
            this.calc.TabIndex = 43;
            this.calc.Text = "Рассчитать";
            this.calc.UseVisualStyleBackColor = true;
            this.calc.Click += new System.EventHandler(this.calc_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label5.Location = new System.Drawing.Point(192, 358);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 18);
            this.label5.TabIndex = 50;
            this.label5.Text = "кг";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label4.Location = new System.Drawing.Point(192, 327);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 18);
            this.label4.TabIndex = 49;
            this.label4.Text = "см";
            // 
            // weight
            // 
            this.weight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.weight.Location = new System.Drawing.Point(140, 354);
            this.weight.MaxLength = 3;
            this.weight.Name = "weight";
            this.weight.Size = new System.Drawing.Size(46, 26);
            this.weight.TabIndex = 42;
            this.weight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.weight.TextChanged += new System.EventHandler(this.weight_TextChanged);
            // 
            // height
            // 
            this.height.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.height.Location = new System.Drawing.Point(140, 323);
            this.height.MaxLength = 3;
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(46, 26);
            this.height.TabIndex = 41;
            this.height.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.height.TextChanged += new System.EventHandler(this.height_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label3.Location = new System.Drawing.Point(99, 358);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 18);
            this.label3.TabIndex = 48;
            this.label3.Text = "Вес:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label2.Location = new System.Drawing.Point(93, 327);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 18);
            this.label2.TabIndex = 47;
            this.label2.Text = "Рост:";
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
            this.female.TabIndex = 46;
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
            this.male.TabIndex = 45;
            this.male.Text = "Мужской";
            this.male.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.male.UseVisualStyleBackColor = false;
            this.male.Click += new System.EventHandler(this.male_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label1.Location = new System.Drawing.Point(192, 390);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 18);
            this.label1.TabIndex = 53;
            this.label1.Text = "лет";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox1.Location = new System.Drawing.Point(140, 386);
            this.textBox1.MaxLength = 3;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(46, 26);
            this.textBox1.TabIndex = 51;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label6.Location = new System.Drawing.Point(67, 390);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 18);
            this.label6.TabIndex = 52;
            this.label6.Text = "Возраст:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Cursor = System.Windows.Forms.Cursors.Help;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Underline);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label7.Location = new System.Drawing.Point(35, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(342, 36);
            this.label7.TabIndex = 55;
            this.label7.Text = "Информация о том, что такое BMR\r\nкалькулятор и как расчитываются результаты";
            // 
            // runnerMenuText
            // 
            this.runnerMenuText.AutoSize = true;
            this.runnerMenuText.Font = new System.Drawing.Font("Arial", 16F);
            this.runnerMenuText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.runnerMenuText.Location = new System.Drawing.Point(299, 74);
            this.runnerMenuText.Name = "runnerMenuText";
            this.runnerMenuText.Size = new System.Drawing.Size(186, 25);
            this.runnerMenuText.TabIndex = 54;
            this.runnerMenuText.Text = "BMI калькулятор";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Cursor = System.Windows.Forms.Cursors.Help;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Underline);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label8.Location = new System.Drawing.Point(458, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(272, 36);
            this.label8.TabIndex = 56;
            this.label8.Text = "Информация о показателях калорий\r\nпоказывается здесь";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 16F);
            this.label9.ForeColor = System.Drawing.Color.Gray;
            this.label9.Location = new System.Drawing.Point(533, 185);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 25);
            this.label9.TabIndex = 57;
            this.label9.Text = "Ваш BMR";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 16F);
            this.label10.ForeColor = System.Drawing.Color.Gray;
            this.label10.Location = new System.Drawing.Point(476, 269);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(228, 50);
            this.label10.TabIndex = 58;
            this.label10.Text = "Ежедневно тратится \r\n          калорий";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 25F);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label11.Location = new System.Drawing.Point(531, 222);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 39);
            this.label11.TabIndex = 59;
            this.label11.Text = "1.670";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 16F);
            this.label12.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label12.Location = new System.Drawing.Point(539, 346);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 25);
            this.label12.TabIndex = 60;
            this.label12.Text = "Сидячий:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 16F);
            this.label13.ForeColor = System.Drawing.Color.Lime;
            this.label13.Location = new System.Drawing.Point(394, 381);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(251, 25);
            this.label13.TabIndex = 61;
            this.label13.Text = "Маленькая активность:\r\n";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 16F);
            this.label14.ForeColor = System.Drawing.Color.Goldenrod;
            this.label14.Location = new System.Drawing.Point(419, 422);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(226, 25);
            this.label14.TabIndex = 62;
            this.label14.Text = "Средняя активность:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 16F);
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(419, 459);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(226, 25);
            this.label15.TabIndex = 63;
            this.label15.Text = "Сильная активность:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 16F);
            this.label16.ForeColor = System.Drawing.Color.DarkRed;
            this.label16.Location = new System.Drawing.Point(356, 496);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(289, 25);
            this.label16.TabIndex = 64;
            this.label16.Text = "Максимальная активность:\r\n";
            // 
            // Minimum
            // 
            this.Minimum.AutoSize = true;
            this.Minimum.Font = new System.Drawing.Font("Arial", 18F);
            this.Minimum.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Minimum.Location = new System.Drawing.Point(651, 346);
            this.Minimum.Name = "Minimum";
            this.Minimum.Size = new System.Drawing.Size(71, 27);
            this.Minimum.TabIndex = 65;
            this.Minimum.Text = "2.000";
            this.Minimum.Click += new System.EventHandler(this.Minimum_Click);
            // 
            // Low
            // 
            this.Low.AutoSize = true;
            this.Low.Font = new System.Drawing.Font("Arial", 18F);
            this.Low.ForeColor = System.Drawing.Color.Lime;
            this.Low.Location = new System.Drawing.Point(651, 381);
            this.Low.Name = "Low";
            this.Low.Size = new System.Drawing.Size(71, 27);
            this.Low.TabIndex = 66;
            this.Low.Text = "2.000";
            this.Low.Click += new System.EventHandler(this.Low_Click);
            // 
            // Average
            // 
            this.Average.AutoSize = true;
            this.Average.Font = new System.Drawing.Font("Arial", 18F);
            this.Average.ForeColor = System.Drawing.Color.Goldenrod;
            this.Average.Location = new System.Drawing.Point(651, 422);
            this.Average.Name = "Average";
            this.Average.Size = new System.Drawing.Size(71, 27);
            this.Average.TabIndex = 67;
            this.Average.Text = "2.000";
            this.Average.Click += new System.EventHandler(this.Average_Click);
            // 
            // Tall
            // 
            this.Tall.AutoSize = true;
            this.Tall.Font = new System.Drawing.Font("Arial", 18F);
            this.Tall.ForeColor = System.Drawing.Color.Red;
            this.Tall.Location = new System.Drawing.Point(651, 459);
            this.Tall.Name = "Tall";
            this.Tall.Size = new System.Drawing.Size(71, 27);
            this.Tall.TabIndex = 68;
            this.Tall.Text = "2.000";
            this.Tall.Click += new System.EventHandler(this.Tall_Click);
            // 
            // VeryTall
            // 
            this.VeryTall.AutoSize = true;
            this.VeryTall.Font = new System.Drawing.Font("Arial", 18F);
            this.VeryTall.ForeColor = System.Drawing.Color.DarkRed;
            this.VeryTall.Location = new System.Drawing.Point(651, 496);
            this.VeryTall.Name = "VeryTall";
            this.VeryTall.Size = new System.Drawing.Size(71, 27);
            this.VeryTall.TabIndex = 69;
            this.VeryTall.Text = "2.000";
            this.VeryTall.Click += new System.EventHandler(this.VeryTall_Click);
            // 
            // BMRcalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(784, 661);
            this.Controls.Add(this.VeryTall);
            this.Controls.Add(this.Tall);
            this.Controls.Add(this.Average);
            this.Controls.Add(this.Low);
            this.Controls.Add(this.Minimum);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.runnerMenuText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
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
            this.Controls.Add(this.remainTime);
            this.Controls.Add(this.footerBlock);
            this.Controls.Add(this.backToMainMenu);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.headerBlock);
            this.MaximizeBox = false;
            this.Name = "BMRcalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WorldSkills Marathon ● BMI Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.headerBlock)).EndInit();
            this.remainTime.ResumeLayout(false);
            this.remainTime.PerformLayout();
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
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button calc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox weight;
        private System.Windows.Forms.TextBox height;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button female;
        private System.Windows.Forms.Button male;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label runnerMenuText;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label Minimum;
        private System.Windows.Forms.Label Low;
        private System.Windows.Forms.Label Average;
        private System.Windows.Forms.Label Tall;
        private System.Windows.Forms.Label VeryTall;
    }
}