using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ЛР7_Стрельба
{
    public partial class Form1 : Form
    {
        double angle;
        double v_h, v_v, v=15, g=0.5;
        
        public Form1()
        {
           
            InitializeComponent();
            pictureBox1.Image = Properties.Resources.тело;
            pictureBox2.Image = Properties.Resources.мишень;
            pictureBox3.Image = Properties.Resources.земля;
            this.pictureBox1.BringToFront();
            this.pictureBox2.BringToFront();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Left = 1;
            pictureBox1.Top = 229;
            pictureBox2.Visible = true;
            Random R = new Random();
            pictureBox2.Left = R.Next(100, 500);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left += (int)Math.Round(v_h, 0);
            pictureBox1.Top -= (int)Math.Round(v_h, 0);
            v_v -= g;
            if (pictureBox1.Bottom > pictureBox3.Top)
            {
                timer1.Enabled = false;
                if (pictureBox1.Right >= pictureBox2.Left && pictureBox1.Left <= pictureBox2.Right)
                {
                    pictureBox2.Visible = false;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            angle = Convert.ToDouble(textBox1.Text) * Math.PI / 180;
            v_h = v * Math.Cos(angle);
            v_v = v * Math.Sin(angle);
            timer1.Enabled = true;
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
