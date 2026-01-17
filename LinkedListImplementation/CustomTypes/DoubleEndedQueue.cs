using Common;
using LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLinkedList.CustomTypes
{
    public class DoubleEndedQueue
    {
        BasicLinkedListImplementation basicLinked;

        public DoubleEndedQueue()
        {
            basicLinked = new BasicLinkedListImplementation();
        }


       public void AddFront(int value)
        {
            Element e= new Element(value,null);

            basicLinked.Prepend(e.value);
        }
        public void AddRear(int value)
        {
            Element e = new Element(value, null);
            basicLinked.Append(e.value);
        }

        internal void removeFront()
        {
            int value= basicLinked.head.value;
            basicLinked.Delete(value);
        }
        internal void removeRear(Element e)
        {
            int value = basicLinked.tail.value;
            basicLinked.Delete(value);
           
        }

        public List<string> Print()
        {
            return basicLinked.Print();
        }

    }
}

            


