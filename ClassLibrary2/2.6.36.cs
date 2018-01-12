using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl1
{
    public class EquasionSolver
    {
        public string Str { get; set; }
        public static string Result(string Str)
        {
            double x = double.Parse(Str);
            return Convert.ToString(Math.Asin(x));
        }

        public static string Equasion(string X, string N, string E,out string SumE,out string SumE10)
        {
            
            double x = double.Parse(X);
            int n = int.Parse(N);
            double e = double.Parse(E);
            double element = 0;
            double sumN = 0;
            double sumE = 0;
            double sumE10 = 0;
            for (int i = 1; i <= n; i++)
            {
                if (i == 0) { element = x; }
                else { element = (2 * n - 3) * Math.Pow(x, 2 * n - 1) / (2 * n - 2) * (2 * n - 1); }
                sumN = sumN + element;
                if (Math.Abs(element) > Math.Abs(e)) { sumE = sumE + element; }
                if (Math.Abs(element) > Math.Abs(e/10)) { sumE10 = sumE10 + element; }
                
            }
            SumE = Convert.ToString(sumE);
            SumE10 = Convert.ToString(sumE10);
            return Convert.ToString(sumN);
        }
    }
}
