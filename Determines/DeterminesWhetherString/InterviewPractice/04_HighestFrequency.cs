using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPractice
{
    public class _04_HighestFrequency
    {
        public static string HighestFrequency(Array str) 
        { 
            Dictionary<string, int> counts = new Dictionary<string, int>();
            int max = 0;
            string res = "";
            foreach (string item in str)
            {
                if (counts.ContainsKey(item))
                {
                    counts[item]++;
                } else
                {
                    counts[item] = 1;
                }
            }

            foreach (var item in counts)
            {
                if(item.Value > max)
                {
                    max = item.Value;
                    res = item.Key;
                }
            }

            return res; 
        }
    }
}
