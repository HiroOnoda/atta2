using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary3
{
    public class Class1
    {
        static public int[,] ReadArray(string path, out int height, out int width)
        {
            
            StreamReader str = new StreamReader(path);
            string buffer;
            string[] bufferarr;
            Char delimiter = ' ';
            width = 0;
            height = 0;
            while ((buffer = str.ReadLine()) != null)
            {
                bufferarr = buffer.Split(delimiter);
                if (bufferarr.Length >= width) { width = bufferarr.Length; };
                height++;
            }
            Console.WriteLine(Convert.ToString(width));
            Console.WriteLine(Convert.ToString(height));
            str = new StreamReader(path);
            int[,] result = new int[width, height];
            for (int y = 0; y < height; y++)
            {
                buffer = str.ReadLine();
                bufferarr = buffer.Split(delimiter);
                for (int x = 0; x < width; x++)
                {
                    result[x, y] = int.Parse(bufferarr[x]);
                    Console.Write(Convert.ToString(result[x, y]) + " ");
                }
                bufferarr = null;
                Console.WriteLine();
            }
            return result;
        }

        public static int[,] RemoveEqualStings(int[,] result, int height, int width, out int height1)
        {
            height1 = 0;
            int[,] result1 = result;
            bool equality = false;
            for (int y = 0; y < height - 1; y++)
            {
                equality = true;
                for (int x = 0; x < width; x++)
                {
                    if (result1[x, y] != result1[x, y + 1]) { equality = false; }

                }
                if (equality == true)
                {

                    for (int y1 = y; y1 < height - 1; y1++)
                    {
                        for (int x1 = 0; x1 < width; x1++)
                        {
                            result1[x1, y1] = result1[x1, y1 + 1];
                        }
                    }
                }
                if (equality == true) { height1++; }

            }
            int[,] ResultArray = new int[width, height1];
            for (int y = 0; y < height1; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    ResultArray[x, y] = result1[x, y];
                }
            }
            return ResultArray;
            //return result1; 
        }

    }
}
