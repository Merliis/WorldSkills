using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorldSkills
{
    public partial class Map : Form
    {
        public Map()
        {
            InitializeComponent();
        }

        private void Map_Load(object sender, EventArgs e)
        {

        }

        //Toilet
        public void pictureBox6_Click(object sender, EventArgs e)
        {

        }
        //Drinks
        public void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        //Energy Bar
        public void pictureBox3_Click(object sender, EventArgs e)
        {

        }
        //Information
        public void pictureBox4_Click(object sender, EventArgs e)
        {

        }
        //Medical
        public void pictureBox5_Click(object sender, EventArgs e)
        {

        }
        //Start
        public void pictureBox7_Click(object sender, EventArgs e)
        {

        }
        //Название точки
        public void PointName_Click(object sender, EventArgs e)
        {

        }
        //Точка 1
        private void button1_Click_1(object sender, EventArgs e)
        {
            PointName.Text = "Avenida Rudge";
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = true;
        }
        //Точка 2
        private void button2_Click(object sender, EventArgs e)
        {
            PointName.Text = "Theatro Municipal";
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            pictureBox5.Visible = true;
            pictureBox6.Visible = true;
            pictureBox7.Visible = true;
        }
        //Точка 3
        private void button3_Click(object sender, EventArgs e)
        {
            PointName.Text = "Parque do Ibirapuera";
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = true;
            pictureBox7.Visible = true;
        }
        //Точка 4
        private void button4_Click(object sender, EventArgs e)
        {
            PointName.Text = "Jardin Luzitania";
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = false;
            pictureBox5.Visible = true;
            pictureBox6.Visible = true;
            pictureBox7.Visible = true;
        }
        //Точка 5
        private void button5_Click(object sender, EventArgs e)
        {
            PointName.Text = "Iguatemi";
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            pictureBox5.Visible = false;
            pictureBox6.Visible = true;
            pictureBox7.Visible = true;
        }
        //Точка 6
        private void button6_Click(object sender, EventArgs e)
        {
            PointName.Text = "Rua Lisboa";
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = true;
            pictureBox7.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        //Точка 7
        private void button7_Click(object sender, EventArgs e)
        {
            PointName.Text = "Cemitério da Consolação";
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            pictureBox5.Visible = true;
            pictureBox6.Visible = true;
            pictureBox7.Visible = true;
        }
        //Точка 8
        private void button8_Click(object sender, EventArgs e)
        {
            PointName.Text = "Cemitério da Consolação";
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            pictureBox5.Visible = true;
            pictureBox6.Visible = true;
            pictureBox7.Visible = true;
        }

        private void Map_FormClosed(object sender, FormClosedEventArgs e)
        {
          
        }

        private void backToMainMenu_Click(object sender, EventArgs e)
        {
            MainMenu pg1 = new MainMenu();
            pg1.Show();
            this.Hide();
        }
    }
}
