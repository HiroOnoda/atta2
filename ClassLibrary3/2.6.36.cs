using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary3
{
    public class EquasionSolver
    {
        public double X { get; set; }//ввод х
        public double E { get; set; }//ввод е
        public int N { get; set; }// ввод n
        public double coef = 1;
        public double Esum = 0;
        public double Esum10 = 0;

        public EquasionSolver(string X1, string E1, string N1)
        {
            //допилить потом проверку на +-R для х,для n>=1
            X = double.Parse(X1);           
            E = double.Parse(E1);
            N = int.Parse(N1);
        }

        public double Result(double x)
        {
            return Math.Asin(x);
        }

        public double ElementCalculator(int n)
        {
            coef = coef * (2 * n - 3) / (2 * n - 2);
            return coef * (Math.Pow(X, 2 * n - 1)) / (2 * n - 1);
        }

        public void EsumCalculator(double element,double E)
        {
            if (Math.Abs(element) > Math.Abs(E)) Esum = Esum + element;
            if (Math.Abs(element) > Math.Abs(E/10)) Esum10 = Esum10 + element;
        }


        public double SolveEquasion(double X, double E, int N)
        {
            double sum = 0;
            double element = 0;
            if (N == 1)
            {
                EsumCalculator(X,E);
                sum = X;
            }
            else
            {
                for (int i = 2; i <= N; i++)
                {
                    element = ElementCalculator(i);
                    sum = sum + element;
                    EsumCalculator(element,E);
                }
                sum = sum + X;
            }       
            return sum;
        }    

    }
}
