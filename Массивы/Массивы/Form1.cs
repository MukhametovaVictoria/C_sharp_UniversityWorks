using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Массивы
{
    public partial class Form1 : Form
    {
        int[] myArray2;
        
        public Form1()
        {
           InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            myArray2 = new int[]{0,1,2,3,4,5,6,7,8,9};
            for (int i = 0; i <= 9; i++)
            {
                myArray2[i] = i * i;
                richTextBox1.Text += Convert.ToString(myArray2[i]) + "\r\n";
            }
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = false;
            button9.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
                FileStream fs0 = new FileStream("MyFile", FileMode.Create, FileAccess.Write);
                BinaryWriter myOut = new BinaryWriter(fs0);
                for (int i = 0; i <= 9; i++)
                {
                    myOut.Write(myArray2[i]);
                }
                myOut.Close();
            
            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox2.Clear();
            try
                {
                    FileStream fsR = new FileStream("MyFile", FileMode.Open, FileAccess.Read);
                    BinaryReader myR = new BinaryReader(fsR);
                    for (int i = 0; i <= 9; i++)
                    {
                        myArray2[i] = myR.ReadInt32();
                        richTextBox2.Text += Convert.ToString(myArray2[i]) + "\r\n";
                    }
                    myR.Close();
                
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Файл не найден");
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter ft0 = new StreamWriter("MyTextFile.txt");
                for (int i = 0; i < myArray2.Length; i++)
                {
                    ft0.WriteLine(Convert.ToString(myArray2[i]));
                }
                ft0.Close();
            }
            catch (IOException)
            {
                MessageBox.Show("Что-то пошло не так. Перезапустите программу");
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader ftI = new StreamReader("MyTextFile.txt");
                for (int i = 0; i <= myArray2.Length - 1; i++)
                {
                    myArray2[i] = Convert.ToInt32(ftI.ReadLine());
                    richTextBox2.Text += Convert.ToString(myArray2[i]) + "\r\n";
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Файл не найден");
            }
            catch (FormatException)
            {
                MessageBox.Show("Ошибка преобразования");
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            richTextBox2.Clear();
                    Array.Reverse(myArray2);
                    for (int i = 0; i <= 9; i++)
                    {
                        richTextBox2.Text += Convert.ToString(myArray2[i]) + "\r\n";
                    }
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            richTextBox2.Clear();
            Array.Sort(myArray2);
            for (int i = 0; i <= 9; i++)
            {
                
                richTextBox2.Text += Convert.ToString(myArray2[i]) + "\r\n";
            } 
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
            FileStream fs0 = new FileStream("MyFile", FileMode.Create, FileAccess.Write);
            BinaryWriter myOut = new BinaryWriter(fs0);
            int n = Convert.ToInt32(richTextBox3.Lines[0]);
            myOut.Write(n);
            for (int i = 1; i <= n; i++)
            {
                myOut.Write(Convert.ToInt32(richTextBox3.Lines[i]));
                
            }

            myOut.Close();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            richTextBox2.Clear();
            int n;
            FileStream fsR = new FileStream("MyFile", FileMode.Open, FileAccess.Read);
            BinaryReader myR = new BinaryReader(fsR);
            n = myR.ReadInt32();
            for (int i = 1; i <= n; i++)
            {

                richTextBox2.Text += Convert.ToString(myR.ReadInt32()) + "\r\n";
            }
            myR.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void richTextBox3_MouseClick(object sender, MouseEventArgs e)
        {
            richTextBox3.Clear();
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = true;
            button9.Enabled = true;
        }

        private void richTextBox1_MouseClick(object sender, MouseEventArgs e)
        {
            richTextBox1.Clear();
            button1.Enabled = true;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
        }

        

        
    }
}
