using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4A1ZnakoveSubory03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (FileStream fStream = new FileStream("textak.txt", FileMode.Append, FileAccess.Write))
            using (StreamWriter sWriter = new StreamWriter(fStream))
            {
                    sWriter.WriteLine(textBox1.Text);
            }
            using (FileStream fStream = new FileStream("textak.txt", FileMode.Open, FileAccess.Read))
            using (StreamReader sReader = new StreamReader(fStream))
            {
                label1.Text = sReader.ReadToEnd();

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (FileStream fStream = new FileStream("textak.txt", FileMode.Open, FileAccess.Read))
            using (StreamReader sReader = new StreamReader(fStream))
            {
                string veta, numbers = "";
                while (!sReader.EndOfStream)
                {
                    veta = sReader.ReadLine();
                    foreach (char znak in veta)
                    {
                        if (Char.IsNumber(znak))
                        {
                            numbers += znak;
                        }
                        else if (numbers != "")
                        {
                            label1.Text += (numbers);
                            numbers = "";
                        }
                    }
                    if (numbers != "")
                    {
                        label1.Text += (numbers);
                        numbers = "";
                    }
                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            using (FileStream fStream = new FileStream("textak.txt", FileMode.Create, FileAccess.Write))
            using (StreamWriter sWriter = new StreamWriter(fStream))
            {
            }
        }
    }
}
