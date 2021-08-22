using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int x = 0;
            Int32.TryParse(textBox1.Text, out x);
            for (int i = 1; i <= 10; i++)
            {
                listBox1.Items.Add(x + " * " + i + "\n = " + x * i);
                //textBox1.Text+= num + " * " + a + "\n = " + num * a;  
            }
        }
    }
}
