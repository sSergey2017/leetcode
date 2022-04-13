using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPractice
{
    public class _02_Flatten
    {
        public static int[] Flatten(Array arr)
        {
            var rows = arr.GetUpperBound(0)+1;
            var cols = arr.GetUpperBound (1)+1;
            // int [] res =   [rows * cols];
            // int [] res =  new int [rows * cols];
            List<int> termsList = new List<int>();
            foreach (int item in arr)
            {
               termsList.Add((int)item);
            }
            return termsList.ToArray();
        }

        public static int[] Flatten1(Array arr)
        {
            //var rows = arr.GetUpperBound(0)+1;
            //var cols = arr.GetUpperBound (1)+1;
            // int [] res =   [rows * cols];
            // int [] res =  new int [rows * cols];
            List<int> termsList = new List<int>();

            foreach (int[] row in arr)
            {
                foreach (int item in row)
                {
                    termsList.Add(item);
                }
                //Console.WriteLine();
            }
            return termsList.ToArray();
        }
    }
}
