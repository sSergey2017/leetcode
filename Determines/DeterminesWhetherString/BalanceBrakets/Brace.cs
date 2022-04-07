using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalanceBrakets
{
    public class Brace
    {
        public Dictionary<char, char> Pairs = new()
        {
            { '{', '}' },
            { '(', ')' },
            { '[', ']' }
        };
        public bool isBalsnced(string text)
        {

            if (string.IsNullOrEmpty(text))
            {
                return false;
            }

            var stack = new Stack<char>();

            foreach (char c in text)
            {
                if (Pairs.ContainsKey(c))
                {
                    stack.Push(c);
                }
                else if (!Pairs.ContainsValue(c)) continue;
                else if (stack.Count == 0) return false;
                else if (Pairs[stack.Pop()] != c) 
                {
                    return false;
                }

            }
            return stack.Count == 0;
        }
    }
}
