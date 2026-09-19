using Common;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack.Interface
{
    public interface IStack
    {
         int count { get; set; }
         void push(int value);
         GenericDataTypeElement pop();
    }
}
