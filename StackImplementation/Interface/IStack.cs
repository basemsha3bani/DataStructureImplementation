using LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack.Interface
{
    internal interface IStack
    {
         int count { get; set; }
         void push(int value);
         Element pop();
    }
}
