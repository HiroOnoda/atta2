using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassLibrary3
{
    public class ListSorter
    {
        static public List<int> StrToList(string str)
        {
            List<int> IntBuffer = null;
            string[] StrBuffer = str.Split(new char[] { ',', ' ' });
            foreach (string s in StrBuffer) IntBuffer.Add(Convert.ToInt32(s));
            return IntBuffer;
        }

        /*public int IndexOf(List<int> list, int value)
        {
            int r;
            for (int i = 0;i < list.Count;i++)
            {
                
            } 
        }*/

        static public List<int> InList1OrInList2(List<int> list1, List<int> list2)
        {
            List<int> bufferlist = null;
            foreach (int i in list1)
            {
                if ((list1.Contains(i) == true) && (bufferlist.Contains(i) == false))
                {
                    bufferlist.Add(i);
                };
            }
            foreach (int i in list2)
            {
                if ((list2.Contains(i) == true) && (bufferlist.Contains(i) == false))
                {
                    bufferlist.Add(i);
                };
            }
            return bufferlist;
        }
    }
}
