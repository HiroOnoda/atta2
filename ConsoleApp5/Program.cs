using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class MatrixSorter
    {
        static string[] ReadArray(string path,int m)
        {

            StreamReader str = new StreamReader(path);
            string[] bufferarr = new string[m];
            for (int i = 0;i < m;i++)
            {
                bufferarr[i] = str.ReadLine();
            }
            return bufferarr;
        }

        static int[] SumFinder(string[] input,int n,int m)
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

        static int[] SumSorter(int[] input, int n, int m)
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

        static string[] ArraySwapper(string[] Input,int[] Sums, int[] SortedSums, int n, int m)
        {
            //string[] bufferarr = new string[m];
            string buffer;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if(Sums[i] == SortedSums[j])
                    {
                        buffer = Input[i];
                        Input[i] = Input[j];
                        Input[j] = buffer;
                    }
                }
            }
            return Input;
        }

        static void Main(string[] args)
        {
            int m = 5;
            int n = 3;
            string path = @"C:\\Users\User\Desktop\matrix.txt";
            string[] result = new string[m];
            result = ReadArray(path,m);
            for (int i = 0; i < m; i++)
            {
                Console.WriteLine(result[i]);
            }
            result = ArraySwapper(ReadArray(path, m), SumFinder(ReadArray(path, m),n,m), SumSorter(SumFinder(ReadArray(path, m), n, m), n, m),n,m);
            Console.WriteLine();
            for (int i = 0; i < m; i++)
            {
                Console.WriteLine(result[i]);
            }
            Console.ReadKey();
        }
    }
}
