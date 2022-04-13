using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPractice
{
    public class _06_ArraySubset
    {
        public static bool ArraySubset(int[] ar1, int [] ar2)
        {
            if (ar1.Length < ar2.Length ) return false;
            var list1 = new List<int>(ar1);

            for ( int i = 0; i < ar2.Length; i++)
            {
                var index = list1.Contains(ar2[i]);
                if (!index) return false;
                //Array.Clear(ar1, i, i+1);
                list1.Remove(ar2[i]);
            }

            return true;
        }
    }
}
