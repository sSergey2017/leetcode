using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPractice
{
    public class _09_Search
    {
        public static int SearchId(int[] arr, int target)
        {
            var start = 0;
            var end = arr.Length - 1;
            var midle = arr.Length / 2;
            if (target < arr[start] || target > arr[end])
            {
                return -1;
            }

            while (true)
            {
                if (target == arr[start])
                {
                    return start;
                }

                if (target == arr[end])
                {
                    return end;
                }

                if (end - start < 0)
                {
                    return -1;
                }

                midle = (start + end) / 2;

                if (target > arr[midle])
                {
                    start = midle++;
                } else if (target < arr[midle])
                {
                    end = midle--;
                } else
                {
                    return midle;
                }

                if (midle == end || midle == start)
                {
                    return -1;
                }
            }
        }

        //public static int SearchId(int[] arr, int target)
        //{
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        if (arr[i] == target)
        //        {
        //            return i;
        //        }
        //    }

        //    return -1;
        //}
    }
}
