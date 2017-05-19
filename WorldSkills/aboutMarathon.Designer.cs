namespace WorldSkills
{
    partial class aboutMarathon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(aboutMarathon));
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.picZoomBox = new System.Windows.Forms.PictureBox();
            this.marathonImg = new System.Windows.Forms.Button();
            this.teatroMunicipal = new System.Windows.Forms.Button();
            this.bancoBanespa = new System.Windows.Forms.Button();
            this.parkLake = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.footerBlock = new System.Windows.Forms.PictureBox();
            this.headerBlock = new System.Windows.Forms.PictureBox();
            this.remainTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picZoomBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.footerBlock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.headerBlock)).BeginInit();
            this.SuspendLayout();
            // 
            // backToMainMenu
            // 
            this.backToMainMenu.Location = new System.Drawing.Point(11, 8);
            this.backToMainMenu.Name = "backToMainMenu";
            this.backToMainMenu.Size = new System.Drawing.Size(72, 26);
            this.backToMainMenu.TabIndex = 21;
            this.backToMainMenu.Text = "Назад";
            this.backToMainMenu.UseVisualStyleBackColor = true;
            this.backToMainMenu.Click += new System.EventHandler(this.backToMainMenu_Click);
            // 
            // remainTime
            // 
            this.remainTime.BackColor = System.Drawing.Color.FromArgb(80, 80, 80);
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
            this.hoursCount.BackColor = System.Drawing.Color.FromArgb(80, 80, 80);
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
            this.and.BackColor = System.Drawing.Color.FromArgb(80, 80, 80);
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
            this.minutesCount.BackColor = System.Drawing.Color.FromArgb(80, 80, 80);
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
            this.minutes.BackColor = System.Drawing.Color.FromArgb(80, 80, 80);
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
            this.hours.BackColor = System.Drawing.Color.FromArgb(80, 80, 80);
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
            this.days.BackColor = System.Drawing.Color.FromArgb(80, 80, 80);
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
            this.Header.BackColor = System.Drawing.Color.FromArgb(80, 80, 80);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14F);
            this.label1.Location = new System.Drawing.Point(231, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 22);
            this.label1.TabIndex = 26;
            this.label1.Text = "Информация о Marathon Skills 2016";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.Location = new System.Drawing.Point(284, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(484, 420);
            this.label2.TabIndex = 32;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // picZoomBox
            // 
            this.picZoomBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picZoomBox.ImageLocation = "";
            this.picZoomBox.Location = new System.Drawing.Point(123, 81);
            this.picZoomBox.Name = "picZoomBox";
            this.picZoomBox.Size = new System.Drawing.Size(539, 477);
            this.picZoomBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picZoomBox.TabIndex = 33;
            this.picZoomBox.TabStop = false;
            this.picZoomBox.Visible = false;
            this.picZoomBox.Click += new System.EventHandler(this.picZoomBox_Click);
            // 
            // marathonImg
            // 
            this.marathonImg.BackgroundImage = global::WorldSkills.Properties.Resources.marathon_image;
            this.marathonImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.marathonImg.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.marathonImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.marathonImg.ForeColor = System.Drawing.Color.FromArgb(80, 80, 80);
            this.marathonImg.Location = new System.Drawing.Point(54, 474);
            this.marathonImg.Name = "marathonImg";
            this.marathonImg.Size = new System.Drawing.Size(101, 64);
            this.marathonImg.TabIndex = 31;
            this.marathonImg.Text = " ";
            this.marathonImg.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.marathonImg.UseVisualStyleBackColor = true;
            this.marathonImg.Click += new System.EventHandler(this.marathonImg_Click);
            // 
            // teatroMunicipal
            // 
            this.teatroMunicipal.BackgroundImage = global::WorldSkills.Properties.Resources.teatro_municipal;
            this.teatroMunicipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.teatroMunicipal.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.teatroMunicipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.teatroMunicipal.ForeColor = System.Drawing.Color.FromArgb(80, 80, 80);
            this.teatroMunicipal.Location = new System.Drawing.Point(167, 474);
            this.teatroMunicipal.Name = "teatroMunicipal";
            this.teatroMunicipal.Size = new System.Drawing.Size(101, 64);
            this.teatroMunicipal.TabIndex = 30;
            this.teatroMunicipal.Text = " ";
            this.teatroMunicipal.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.teatroMunicipal.UseVisualStyleBackColor = true;
            this.teatroMunicipal.Click += new System.EventHandler(this.teatroMunicipal_Click);
            // 
            // bancoBanespa
            // 
            this.bancoBanespa.BackgroundImage = global::WorldSkills.Properties.Resources.banco_banespa;
            this.bancoBanespa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bancoBanespa.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.bancoBanespa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bancoBanespa.ForeColor = System.Drawing.Color.FromArgb(80, 80, 80);
            this.bancoBanespa.Location = new System.Drawing.Point(54, 382);
            this.bancoBanespa.Name = "bancoBanespa";
            this.bancoBanespa.Size = new System.Drawing.Size(101, 64);
            this.bancoBanespa.TabIndex = 29;
            this.bancoBanespa.Text = " ";
            this.bancoBanespa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bancoBanespa.UseVisualStyleBackColor = true;
            this.bancoBanespa.Click += new System.EventHandler(this.bancoBanespa_Click);
            // 
            // parkLake
            // 
            this.parkLake.BackgroundImage = global::WorldSkills.Properties.Resources.ibirapuera_park_lake;
            this.parkLake.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.parkLake.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.parkLake.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.parkLake.ForeColor = System.Drawing.Color.FromArgb(80, 80, 80);
            this.parkLake.Location = new System.Drawing.Point(167, 382);
            this.parkLake.Name = "parkLake";
            this.parkLake.Size = new System.Drawing.Size(101, 64);
            this.parkLake.TabIndex = 28;
            this.parkLake.Text = " ";
            this.parkLake.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.parkLake.UseVisualStyleBackColor = true;
            this.parkLake.Click += new System.EventHandler(this.parkLake_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(80, 80, 80);
            this.button1.Location = new System.Drawing.Point(54, 137);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(214, 216);
            this.button1.TabIndex = 27;
            this.button1.Text = "Нажмите, чтобы открыть карту";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // footerBlock
            // 
            this.footerBlock.BackColor = System.Drawing.Color.FromArgb(80, 80, 80);
            this.footerBlock.Location = new System.Drawing.Point(-1, 623);
            this.footerBlock.Name = "footerBlock";
            this.footerBlock.Size = new System.Drawing.Size(786, 39);
            this.footerBlock.TabIndex = 24;
            this.footerBlock.TabStop = false;
            // 
            // headerBlock
            // 
            this.headerBlock.BackColor = System.Drawing.Color.FromArgb(80, 80, 80);
            this.headerBlock.Location = new System.Drawing.Point(0, 0);
            this.headerBlock.Name = "headerBlock";
            this.headerBlock.Size = new System.Drawing.Size(784, 46);
            this.headerBlock.TabIndex = 22;
            this.headerBlock.TabStop = false;
            // 
            // aboutMarathon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(784, 661);
            this.Controls.Add(this.picZoomBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.marathonImg);
            this.Controls.Add(this.teatroMunicipal);
            this.Controls.Add(this.bancoBanespa);
            this.Controls.Add(this.parkLake);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backToMainMenu);
            this.Controls.Add(this.remainTime);
            this.Controls.Add(this.footerBlock);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.headerBlock);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "aboutMarathon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WorldSkills Marathon ● About Marathon Skills 2016";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.aboutMarathon_FormClosed);
            this.remainTime.ResumeLayout(false);
            this.remainTime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picZoomBox)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button parkLake;
        private System.Windows.Forms.Button bancoBanespa;
        private System.Windows.Forms.Button marathonImg;
        private System.Windows.Forms.Button teatroMunicipal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picZoomBox;
    }
}