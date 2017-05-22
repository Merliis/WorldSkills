namespace WorldSkills
{
    partial class Map
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
            this.backToMainMenu = new System.Windows.Forms.Button();
            this.Header = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PointName = new System.Windows.Forms.Label();
            this.pictureBoxStart = new System.Windows.Forms.PictureBox();
            this.pictureBoxToilet = new System.Windows.Forms.PictureBox();
            this.pictureBoxMedical = new System.Windows.Forms.PictureBox();
            this.pictureBoxInformation = new System.Windows.Forms.PictureBox();
            this.pictureBoxEnegryBars = new System.Windows.Forms.PictureBox();
            this.pictureBoxDrinks = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.headerBlock = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxToilet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMedical)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInformation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEnegryBars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDrinks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.headerBlock)).BeginInit();
            this.SuspendLayout();
            // 
            // backToMainMenu
            // 
            this.backToMainMenu.Location = new System.Drawing.Point(11, 11);
            this.backToMainMenu.Name = "backToMainMenu";
            this.backToMainMenu.Size = new System.Drawing.Size(72, 26);
            this.backToMainMenu.TabIndex = 3;
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
            this.Header.Location = new System.Drawing.Point(108, 11);
            this.Header.Name = "Header";
            this.Header.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Header.Size = new System.Drawing.Size(584, 28);
            this.Header.TabIndex = 5;
            this.Header.Text = "Интерактивная карта MARATHON SKILLS 2016";
            this.Header.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Header.UseMnemonic = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.PointName);
            this.panel1.Controls.Add(this.pictureBoxStart);
            this.panel1.Controls.Add(this.pictureBoxToilet);
            this.panel1.Controls.Add(this.pictureBoxMedical);
            this.panel1.Controls.Add(this.pictureBoxInformation);
            this.panel1.Controls.Add(this.pictureBoxEnegryBars);
            this.panel1.Controls.Add(this.pictureBoxDrinks);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-1, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(790, 612);
            this.panel1.TabIndex = 7;
            // 
            // PointName
            // 
            this.PointName.AutoSize = true;
            this.PointName.Location = new System.Drawing.Point(601, 80);
            this.PointName.Name = "PointName";
            this.PointName.Size = new System.Drawing.Size(29, 13);
            this.PointName.TabIndex = 14;
            this.PointName.Text = "label";
            this.PointName.Visible = false;
            this.PointName.Click += new System.EventHandler(this.PointName_Click);
            // 
            // pictureBoxStart
            // 
            this.pictureBoxStart.Image = global::WorldSkills.Properties.Resources.map_icon_start;
            this.pictureBoxStart.Location = new System.Drawing.Point(643, 325);
            this.pictureBoxStart.Name = "pictureBoxStart";
            this.pictureBoxStart.Size = new System.Drawing.Size(79, 70);
            this.pictureBoxStart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxStart.TabIndex = 13;
            this.pictureBoxStart.TabStop = false;
            this.pictureBoxStart.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // pictureBoxToilet
            // 
            this.pictureBoxToilet.Image = global::WorldSkills.Properties.Resources.map_icon_toilets;
            this.pictureBoxToilet.Location = new System.Drawing.Point(643, 230);
            this.pictureBoxToilet.Name = "pictureBoxToilet";
            this.pictureBoxToilet.Size = new System.Drawing.Size(79, 70);
            this.pictureBoxToilet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxToilet.TabIndex = 12;
            this.pictureBoxToilet.TabStop = false;
            this.pictureBoxToilet.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // pictureBoxMedical
            // 
            this.pictureBoxMedical.Image = global::WorldSkills.Properties.Resources.map_icon_medical;
            this.pictureBoxMedical.Location = new System.Drawing.Point(643, 132);
            this.pictureBoxMedical.Name = "pictureBoxMedical";
            this.pictureBoxMedical.Size = new System.Drawing.Size(79, 70);
            this.pictureBoxMedical.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMedical.TabIndex = 11;
            this.pictureBoxMedical.TabStop = false;
            this.pictureBoxMedical.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBoxInformation
            // 
            this.pictureBoxInformation.Image = global::WorldSkills.Properties.Resources.map_icon_information;
            this.pictureBoxInformation.Location = new System.Drawing.Point(506, 317);
            this.pictureBoxInformation.Name = "pictureBoxInformation";
            this.pictureBoxInformation.Size = new System.Drawing.Size(79, 70);
            this.pictureBoxInformation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxInformation.TabIndex = 10;
            this.pictureBoxInformation.TabStop = false;
            this.pictureBoxInformation.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBoxEnegryBars
            // 
            this.pictureBoxEnegryBars.Image = global::WorldSkills.Properties.Resources.map_icon_energy_bars;
            this.pictureBoxEnegryBars.Location = new System.Drawing.Point(506, 222);
            this.pictureBoxEnegryBars.Name = "pictureBoxEnegryBars";
            this.pictureBoxEnegryBars.Size = new System.Drawing.Size(79, 70);
            this.pictureBoxEnegryBars.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxEnegryBars.TabIndex = 9;
            this.pictureBoxEnegryBars.TabStop = false;
            this.pictureBoxEnegryBars.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBoxDrinks
            // 
            this.pictureBoxDrinks.Image = global::WorldSkills.Properties.Resources.map_icon_drinks;
            this.pictureBoxDrinks.Location = new System.Drawing.Point(506, 132);
            this.pictureBoxDrinks.Name = "pictureBoxDrinks";
            this.pictureBoxDrinks.Size = new System.Drawing.Size(79, 70);
            this.pictureBoxDrinks.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxDrinks.TabIndex = 8;
            this.pictureBoxDrinks.TabStop = false;
            this.pictureBoxDrinks.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(256, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 48);
            this.button1.TabIndex = 7;
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WorldSkills.Properties.Resources.Map;
            this.pictureBox1.Location = new System.Drawing.Point(0, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(467, 495);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // headerBlock
            // 
            this.headerBlock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.headerBlock.Location = new System.Drawing.Point(-1, 2);
            this.headerBlock.Name = "headerBlock";
            this.headerBlock.Size = new System.Drawing.Size(784, 54);
            this.headerBlock.TabIndex = 4;
            this.headerBlock.TabStop = false;
            // 
            // Map
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 661);
            this.Controls.Add(this.backToMainMenu);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.headerBlock);
            this.Controls.Add(this.panel1);
            this.Name = "Map";
            this.Text = "WorldSkills Marathon ● Interacive Map";
            this.Load += new System.EventHandler(this.Map_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxToilet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMedical)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInformation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEnegryBars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDrinks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.headerBlock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backToMainMenu;
        private System.Windows.Forms.Label Header;
        private System.Windows.Forms.PictureBox headerBlock;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxDrinks;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBoxToilet;
        private System.Windows.Forms.PictureBox pictureBoxMedical;
        private System.Windows.Forms.PictureBox pictureBoxInformation;
        private System.Windows.Forms.PictureBox pictureBoxEnegryBars;
        private System.Windows.Forms.PictureBox pictureBoxStart;
        private System.Windows.Forms.Label PointName;
    }
}