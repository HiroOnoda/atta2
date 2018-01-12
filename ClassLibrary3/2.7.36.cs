using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary3
{
    public class MaxLineFinder
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
        static public int MaxFinder(double[] arr)
        {

            int s = 0;
            int count = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] < arr[i + 1]) count++;
                else
                {
                    if (count > s)
                    {
                        s = count;
                        count = 0;
                    }
                }

            }
            if (count > s) s = count; 
            return s;
        }



    }
}

