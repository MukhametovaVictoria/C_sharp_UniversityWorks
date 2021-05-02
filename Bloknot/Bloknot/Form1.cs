using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bloknot
{
    public partial class Form1 : Form
    {
        string Bz = "";//перемнная "имя файла" для запоминания пути к файлу
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();//очистка поля
            Bz = "";
            this.Text = "Безымянный";//переименование окна в "Безымянный"
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.PlainText);//открытие
            }
            Bz = openFileDialog1.FileName;
            this.Text = Bz;//переименование окна в имя файла
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Bz == "")
            {
                if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);//сохраненить как...
                }
                Bz = saveFileDialog1.FileName;
                this.Text = Bz;
            }
            else
            { richTextBox1.SaveFile(Bz, RichTextBoxStreamType.PlainText); }//сохранение файла без открытия диалога
        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);//сохранить как...
               
            }
            Bz = saveFileDialog1.FileName;
            this.Text = Bz;
        }

        private void цветФонаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                richTextBox1.BackColor = colorDialog1.Color;//открытие диалогового окна для смены цвета фона
            }
        }

        private void шрифтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            { 
                richTextBox1.Font = fontDialog1.Font; }//откртыие диалогового окна для смены шрифта
        }
    }
}
