using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
    

        static public void StringSplitter(string str, out string[] words)
        {
            words = str.Split(' ');
        }

        static public void FirstLetterCut(string[] words)
        {
            string firstletter;
            string newword = null;
            string[] letters = null;
            foreach (string s in words)
            {
                string S1 = s;
                firstletter = S1.Substring(0,1);
                S1 = S1.Remove(0,1);
                newword = newword + firstletter;
                
                while (S1 != "") 
                {
                    if (S1.Substring(0, 1) != firstletter) { newword = newword + S1.Substring(0, 1); S1 = S1.Remove(0, 1);  }
                    else { S1 = S1.Remove(0, 1); }
                    Console.Write(S1 + " ");
                } 
                newword = newword + " ";
                Console.Write(newword);
                Console.WriteLine();
            }

        }
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            StringSplitter(a,out string[] words);
            foreach (string b in words){ Console.Write(b + " "); };
            Console.WriteLine();
            FirstLetterCut(words);
            Console.ReadLine();

        }
    }
}
