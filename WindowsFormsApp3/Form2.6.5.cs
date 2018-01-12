using BL;
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
    public partial class Form6n5 : Form
    {
        public Form6n5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringChanger Str = new StringChanger(textBox1.Text);
            label1.Text = Str.FirstLetterCut(Str.StringSplitter(textBox1.Text));
        }
    }
}
