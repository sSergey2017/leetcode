using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPractice
{
    public class _10_QueueO
    {
        Hashtable storage = new Hashtable();
        private int Last { get; set; }
        private int First { get; set; }
        public int Count { get { return storage.Count; } }

        public void Enqueue(string data)
        {
            storage[Last] = data;
            Last++;
        }

        public string Dequeue()
        {
            var value = storage[First];
            storage.Remove(First);
            First++;
            return (string)value;
        }

        public int Size()
        {
            return Last - First;
        }
          
        
    }
}
