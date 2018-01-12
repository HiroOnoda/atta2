using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary3
{
    public class MatrixSorter
    {
        public static string[] ReadArray(string path, int m)
        {

            StreamReader str = new StreamReader(path);
            string[] bufferarr = new string[m];
            for (int i = 0; i < m; i++)
            {
                bufferarr[i] = str.ReadLine();
            }
            return bufferarr;
        }

        public static int[] FindSums(string[] input, int n, int m)
        {
            int[] sumarr = new int[m];
            string[] bufferarr = new string[n];
            for (int i = 0; i < m; i++)
            {
                bufferarr = input[i].Split(' ');
                for (int j = 0; j < n; j++)
                {
                    sumarr[i] = sumarr[i] + Int32.Parse(bufferarr[j]);
                }
            }
            return sumarr;
        }

        public static int[] SortSums(int[] input, int n, int m)
        {
            int buffer = 0;
            int[] bufferarr = input;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (bufferarr[i] < bufferarr[j])
                    {
                        buffer = bufferarr[i];
                        bufferarr[i] = bufferarr[j];
                        bufferarr[j] = buffer;
                    }
                }
            }
            return bufferarr;
        }

        public static string[] ArraySwap(string[] Input, int[] Sums, int[] SortedSums, int n, int m)
        {
            //string[] bufferarr = new string[m];
            string buffer;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (Sums[i] == SortedSums[j])
                    {
                        buffer = Input[i];
                        Input[i] = Input[j];
                        Input[j] = buffer;
                    }
                }
            }
            return Input;
        }

        public static string[,] GridArrange(string[] Input, int n, int m)
        {
            string[] bufferarr = new string[n];
            string[,] OutputArr = new string[n,m];
            for (int i = 0; i < m; i++)
            {
                bufferarr = Input[i].Split(' ');
                for (int j = 0; j < n; j++)
                {
                    OutputArr[j, i] = bufferarr[j];
                }
            }
            return OutputArr;
        }
        
    }
}
