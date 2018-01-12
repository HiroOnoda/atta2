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

namespace WindowsFormsApp5
{
    public partial class Back : Form
    {
        public Back()
        {
            InitializeComponent();
        }

        private void printer_Click(object sender, EventArgs e)
        {
            EquasionSolver EQS;

            EQS = new EquasionSolver(X1: inputX.Text, E1: inputE.Text, N1: inputN.Text);
            sum.Text = Convert.ToString(EQS.SolveEquasion(EQS.X, EQS.E, EQS.N));
            sumE.Text = Convert.ToString(EQS.Esum);
            sumE10.Text = Convert.ToString(EQS.Esum10);
            result.Text = Convert.ToString(EQS.Result(EQS.X));

        }

        private void Back_Load(object sender, EventArgs e)
        {

        }
    }
}
