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
        ElementLinkedListImplementation basicLinked;

        public DoubleEndedQueue()
        {
            basicLinked = new ElementLinkedListImplementation();
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
            int value=(int) basicLinked.head.value;
            basicLinked.delete(value);
        }
        internal void removeRear(Element e)
        {
            int value =(int) basicLinked.tail.value;
            basicLinked.delete(value);
           
        }

        public List<string> Print()
        {
            return basicLinked.Print();
        }

    }
}

            


