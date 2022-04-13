using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPractice
{
    public class _03_Dupes
    {
        public static string RemoveDupes(string str)
        {
            if (str == null) return "";

            List<char> ar = new List<char>();

            foreach (var item in str.ToArray())
            {
                if (!ar.Contains(item))
                {
                    ar.Add(item);
                }
            }
            return new string(ar.ToArray());
        }

        public static string RemoveDupes2(string str)
        {
            if (str == null) return "";

            HashSet<char> ar = new HashSet<char>(str);

            return new string(ar.ToArray());
        }
    }
}
