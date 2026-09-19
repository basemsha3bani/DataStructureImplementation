using Common;
using LinkedList;
using Stack.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.StackPracticeProblem
{
    internal static class StackOverLapCounter
    {
internal static int countStackOverLap(IStack stack,IStack stack2)
        {
            GenericDataTypeElement element1 = stack.pop();
            GenericDataTypeElement element2 = stack2.pop();
            while (element1 != null && element2 != null)
            {
                if(element1.value == element2.value)
                {
                    return countStackOverLap(stack, stack2) + 1;
                    
                }
                else
                {
                    return 0;
                }
            }
            return 0;
        }
    }
}
