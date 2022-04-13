using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPractice
{
    public class _07_AllAnagrams
    {
        public static bool AllAnagrams(string [] str) 
        {
            string[] anagramm = new string[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                var ss = str[i].ToCharArray();
                Array.Sort(ss);
                anagramm[i] = new string(ss);
            }

            for (int i = 1; i < anagramm.Length; i++)
            {
                if (!anagramm[0].Equals(anagramm[i]))
                {
                    return false;
                }
            }
            return true; 
        }
    }
}
