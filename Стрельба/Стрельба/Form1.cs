using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Стрельба
{
    public partial class Form1 : Form
    {
        double v = 15, v_h, v_v, g = 0.5, angle;
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile("Безымянный.png");
            pictureBox2.Image = Image.FromFile("Безымянный1.png");
            pictureBox3.Image = Image.FromFile("Безымянный2.png");
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(20, 275);
            Random r = new Random();
            int value = r.Next(128,500);
            
            pictureBox3.Location = new Point(value, pictureBox3.Location.Y);
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Enabled = true;
            timer1.Enabled = true;
            angle = Convert.ToDouble(textBox1.Text) * Math.PI / 180;
            v_h = v * Math.Cos(angle);
            v_v = v * Math.Sin(angle);
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Left < 100 || pictureBox1.Top < 275)
            {
                pictureBox1.Left += (int)Math.Round(v_h, 0);
                pictureBox1.Top -= (int)Math.Round(v_v, 0);
                v_v -= g;
            }
            else
            { timer1.Enabled = false; }
            Rectangle a;
            Rectangle b;
            b = new Rectangle(pictureBox1.Location, pictureBox1.Size);
            a = new Rectangle(pictureBox3.Location, pictureBox3.Size);
            if (b.IntersectsWith(a))
            {
                pictureBox3.Image = Image.FromFile("Безымянный4.png"); 
                //pictureBox1.Location = new Point(pictureBox3.Location.X, pictureBox3.Location.Y-20);
            }
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {


        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            

        }
    }
}
