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

namespace _4A1SuboryGUI01
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            string text = Input.Text;
            Output.Items.Add(text); 
        }

        private void Input_TextChanged(object sender, EventArgs e)
        {

        }

        private void Output_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SaveChar_Click(object sender, EventArgs e)
        {
            using (FileStream fStream = new FileStream("textak.txt", FileMode.Create, FileAccess.Write))
            using (StreamWriter sWriter = new StreamWriter(fStream))
            {
                for (int i = 0; i < Output.Items.Count; i++)
                {
                    sWriter.WriteLine(Output.Items[i]);
                }
            }
               
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            using (FileStream fStream = new FileStream("textak.txt", FileMode.Open, FileAccess.Read))
            using (StreamReader sReader = new StreamReader(fStream))
            {
                string veta;
                string cislo1 = "",cislo2 = "";
                char opr ='x';
                Answers.Items.Clear();
                while (!sReader.EndOfStream)
                {
                   
                    veta = sReader.ReadLine();
                    cislo1 = "";
                    cislo2 = "";
                    opr = 'x';
                    foreach (char znak in veta)
                    {
                        if (Char.IsNumber(znak) && opr == 'x')
                        {
                            cislo1 += znak;
                        }
                        if (Char.IsNumber(znak) && opr != 'x')
                        {
                            cislo2 += znak;
                            Convert.ToInt32(Char.GetNumericValue(znak));
                        }
                        else if (!Char.IsNumber(znak) && znak != '=')
                        {
                            opr = znak;
                        }
                    }
                    switch (opr)
                    {
                        case '+':
                            Answers.Items.Add(Convert.ToInt32(cislo1) + Convert.ToInt32(cislo2));
                            break;
                        case '-':
                            Answers.Items.Add(Convert.ToInt32(cislo1) - Convert.ToInt32(cislo2));
                            break;
                        case '*':
                            Answers.Items.Add(Convert.ToInt32(cislo1) * Convert.ToInt32(cislo2));
                            break;
                        case '/':
                            Answers.Items.Add(Convert.ToDouble(cislo1) / Convert.ToDouble(cislo2));
                            break;

                    }
                }
                
            }
            using (FileStream fStream = new FileStream("textak.dta", FileMode.Create, FileAccess.Write))
            using (BinaryWriter bWriter = new BinaryWriter(fStream))
            {
                for (int i = 0; i < Answers.Items.Count; i++)
                {
                    bWriter.Write(Convert.ToDouble(Answers.Items[i]));
                }
            }
        }

        private void Answers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
