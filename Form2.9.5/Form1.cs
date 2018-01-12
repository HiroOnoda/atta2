using ClassLibrary3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Form2._9._5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static string path = @"C:\\Users\User\Desktop\words1.txt";
        static int width = 0;
        static int height = 0;
        int[,] ArrayBuffer = Class1.ReadArray(path, out height, out width);

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.RowHeadersWidth = 65;
            dataGridView1.ScrollBars = ScrollBars.Both;
            dataGridView1.ColumnHeadersHeight = 40;
            dataGridView1.ColumnCount = width;
            dataGridView1.RowCount = height;



            for (int j = 0; j <= height - 1; ++j)
            {
                for (int i = 0; i <= width - 1; ++i)
                {
                    dataGridView1[i, j].Value = ArrayBuffer[i, j];
                    //Console.WriteLine(ArrayBuffer[i, j]);Convert.ToString(ArrayBuffer[i,j]);
                }
            }
            int[,] SortedArray = Class1.RemoveEqualStings(ArrayBuffer, height, width, out int height1);

            
            dataGridView2.RowHeadersWidth = 65;
            dataGridView2.ScrollBars = ScrollBars.Both;
            dataGridView2.ColumnHeadersHeight = 40;
            dataGridView2.ColumnCount = width;
            dataGridView2.RowCount = height1;
            label1.Text = Convert.ToString(height1);
            //label2.Text = Convert.ToString(dataGridView1[0, 1].Value);
            for (int j = 0; j <= height1-1; ++j) 
            { 
                for (int i = 0; i <= width-1; ++i)
                {
                    dataGridView2[i, j].Value = ArrayBuffer[i, j];
                    //Console.WriteLine(ArrayBuffer[i, j]);Convert.ToString(ArrayBuffer[i,j]);
                }
            }
        }
    }
}

