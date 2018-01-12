using System;
using ClassLibrary3;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string path = @"C:\\Users\User\Desktop\matrix.txt";
            string path = textBox1.Text;
            int n = 3;
            int m = 5;
            dataGridView1.RowCount = m;
            dataGridView1.ColumnCount = n;


            string[,] GridArray = MatrixSorter.GridArrange(MatrixSorter.ArraySwap(MatrixSorter.ReadArray(path, m), MatrixSorter.FindSums(MatrixSorter.ReadArray(path, m), n, m), MatrixSorter.SortSums(MatrixSorter.FindSums(MatrixSorter.ReadArray(path, m), n, m), n, m), n, m), n, m);
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    dataGridView1[j, i].Value = GridArray[j, i];
                }
            }
        }
    }
}
