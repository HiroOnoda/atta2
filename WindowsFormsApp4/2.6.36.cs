using Bl1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = EquasionSolver.Equasion(textBox1.Text, textBox4.Text, textBox3.Text, out string str2, out string str3);
            label2.Text = str2;
            label3.Text = str3;
            label4.Text = EquasionSolver.Result(textBox1.Text);
        }
    }
}
