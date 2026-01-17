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
        

        public Element find(int value)
        {
            foreach (Element item in ArrayList)
            {
                if (item.value == value)
                {
                    return item;
                }
            }
            return null;


        }
        public Element Max()
        {
            if (ArrayList.Count == 0)
            {
                return null;
            }
            Element maxElement = (Element)ArrayList[0];
            foreach (Element item in ArrayList)
            {
                if (item.value > maxElement.value)
                {
                    maxElement = item;
                }
            }
            return maxElement;
        }

        public void deQueueMax(Element max)
        {
            Element temp;
            temp = (Element)ArrayList[0];
            Dequeue();

            ArrayList[0] = max;
            Dequeue();
            ArrayList.Add(temp);


        }
    }
}
