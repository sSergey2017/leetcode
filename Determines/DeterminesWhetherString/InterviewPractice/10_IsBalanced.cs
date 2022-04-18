using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPractice
{
    public class _10_IsBalanced
    {
        public bool isBalsnced(string strl)
        {
            var str = strl.ToCharArray();

            Dictionary<char, char> map = new Dictionary<char, char>()
            {
                {'{', '}'},
                {'(', ')'},
                {'[', ']'}
            };
            Stack<char> stack = new Stack<char>();

            foreach(char item in str)
            {

                if (map.ContainsKey(item))
                {
                    stack.Push(item);
                }
                else if (!map.ContainsValue(item)) continue;
                else if (stack.Count == 0) return false;
                else if (map[stack.Pop()] != item)
                {
                        return false;
                }
            }
            return stack.Count == 0;
        }
    }
}
