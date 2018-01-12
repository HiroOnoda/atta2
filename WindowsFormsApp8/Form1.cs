using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView1.Columns.Add("arr", "arr");
            dataGridView1.Columns["arr"].Width = 130;
            //нет новой строки
            dataGridView1.AllowUserToAddRows = false;
            int L = 10;
            //Random rnd = new Random();
            int[] arr = new int[L];
            for (int i = 0; i <= L - 1; i++)
                arr[i] = i + 1;
            dataGridView1.RowCount = L;
            for (int i = 0; i <= L - 1; i++)
                dataGridView1[0, i].Value = arr[i];
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}

