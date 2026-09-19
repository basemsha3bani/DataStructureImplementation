using Common;
using LinkedList;
using Queue.Interface;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue.Implementation
{
    public class ArrayQueueImplemenationWithExtraFunctions:ArrayQueueImplementation, IQuequeWithExtraFunctions
    {
        

        public GenericDataTypeElement find(int value)
        {
            int itemValue;
            foreach (GenericDataTypeElement item in ArrayList)
            {
                itemValue = (int)item.value;
                if (itemValue == value)
                {
                    return item;
                }
            }
            return null;


        }
        public GenericDataTypeElement Max()
        {
            if (ArrayList.Count == 0)
            {
                return null;
            }
            GenericDataTypeElement maxElement = (GenericDataTypeElement)ArrayList[0];
            int maxElementValue, ElementValue;
            maxElementValue = (int)maxElement.value;

            foreach (GenericDataTypeElement item in ArrayList)
            {
                ElementValue=(int)item.value;
                if (ElementValue > maxElementValue)
                {
                    maxElement = item;
                    maxElementValue = ElementValue;
                }
            }
            return maxElement;
        }

        public void deQueueMax(GenericDataTypeElement max)
        {
            GenericDataTypeElement temp;
            temp = (GenericDataTypeElement)ArrayList[0];
            Dequeue();

            ArrayList[0] = max;
            Dequeue();
            ArrayList.Add(temp);


        }
    }
}
