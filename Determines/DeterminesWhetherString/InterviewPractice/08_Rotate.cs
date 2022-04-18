using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPractice
{
    public class _08_Rotate
    {
        public static int[,] Rotate(int [,] arr)
        {
            int[,] result = new int[arr.GetLength(0), arr.GetLength(1)];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    result[j, arr.GetLength(0) - i - 1] = arr[i, j];
                }
            }
            return result;
        }
    }
}
