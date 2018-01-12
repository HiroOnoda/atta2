using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class StringChanger
    {

        public string Str { get; set; }

        public StringChanger (string str)
        {
            Str = str;
        }

        public string[] StringSplitter(string Str)
        {
            return Str.Split(' ');
        }

        public string FirstLetterCut(string[] words)
        {
            string firstletter;
            string newword = null;          
            foreach (string s in words)
            {
                string S1 = s;
                firstletter = S1.Substring(0, 1);
                S1 = S1.Remove(0, 1);
                newword = newword + firstletter;
                while (S1 != "")
                {
                    if (S1.Substring(0, 1) != firstletter) { newword = newword + S1.Substring(0, 1); S1 = S1.Remove(0, 1); }
                    else { S1 = S1.Remove(0, 1); }
                    Console.Write(S1 + " ");
                }
                newword = newword + " ";
                
            }
            return newword;
        }

       
    }
}
