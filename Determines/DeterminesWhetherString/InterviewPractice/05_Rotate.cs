using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPractice
{
    public class _05_Rotate
    {
        public static bool Rotate(string str1, string str2)
        {
            if (str1 == null || str2 == null) return false;

            var fullArr = str1 + str1;
            var res = fullArr.IndexOf(str2);
            if (str1.Length== str2.Length && res != -1) return true;

            return false;
        }
    }
}
