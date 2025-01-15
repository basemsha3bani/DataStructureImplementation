using LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue.Interface
{
    internal interface IQueue
    {
         int count { get; set; }
         void Enqueue(int value);
         void Dequeue();
    }
}
