using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary3
{
    public class StringSorter
    {
        static public double StrToValue(string str)
        {
            return Convert.ToDouble(str);
        }


        static public double[] StrToArray(string str)
        {
            return Array.ConvertAll
            (
                str.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries),
                (s) => StrToValue(s)
            );
        }
        static public double MonoCounter(double[] arr)
        {
            double s = 0;
            int count = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] < arr[i + 1]) count++;
                else
                {
                    if (count != 0)
                    {
                        s++;
                        count = 0;
                    }
                }

            }
            if (count != 0) s++;
            return s;
        }



    }
}
