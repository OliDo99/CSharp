using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4A1SDListGUI01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Date.Text = DateTime.Now.ToString("D");
            


        }
        public void update()
        {
            while (true)
            {
                Time.Text = DateTime.Now.ToString("hh:mm:ss");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Time_Click(object sender, EventArgs e)
        {

        }

        private void Date_Click(object sender, EventArgs e)
        {

        }
    }
}
