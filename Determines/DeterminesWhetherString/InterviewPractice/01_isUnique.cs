using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPractice
{
    public class _01_isUnique
    {

        public static bool IsUnique(string str)
        {
            if (str == null) return false;

            List <char> ar = new List<char>();

            foreach(var item in str.ToArray())
            {
                if (ar.Contains(item))
                {
                    return false;
                }
                ar.Add(item);
            }

            return true;
        }

        public static bool IsUnique1(string str)
        {
            if (str == null) return false;

            HashSet<char> list = new HashSet<char>(str.ToArray());
            if (list.Count != str.Length)
            {
                return false;
            }
            return true;
        }
    }
}
