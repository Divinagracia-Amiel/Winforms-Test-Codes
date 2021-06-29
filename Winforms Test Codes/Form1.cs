using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winforms_Test_Codes 
{
    public partial class Form1 : Form
    {
        Button button2 = new Button();
        public Form1()
        {
            InitializeComponent();          
            button2.Text = "yay";
            button2.Location = new Point(3, 6);
            button2.Size = new Size(75, 41);
            EventHandler button2_method = new EventHandler(button2_Click);
            button2.Click += button2_method;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (tabPage1.Controls.Contains(button2))
            {
                tabPage1.Controls.Remove(button2);
            }
            else
            {
                tabPage1.Controls.Add(button2);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "fuck you";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
