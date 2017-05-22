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
            this.headerBlock = new System.Windows.Forms.PictureBox();
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
            this.Name = "Map";
            this.Text = "WorldSkills Marathon ● Interacive Map";
            this.Load += new System.EventHandler(this.Map_Load);
            ((System.ComponentModel.ISupportInitialize)(this.headerBlock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backToMainMenu;
        private System.Windows.Forms.Label Header;
        private System.Windows.Forms.PictureBox headerBlock;
    }
}