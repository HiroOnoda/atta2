using System;
using System.Windows.Forms;

namespace Form2._8._5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            label1.Text = Convert.ToString(ListSorter.InList1OrInList2(ListSorter.StrToList(textBox1.Text), ListSorter.StrToList(textBox2.Text)));
        }


    }
}
