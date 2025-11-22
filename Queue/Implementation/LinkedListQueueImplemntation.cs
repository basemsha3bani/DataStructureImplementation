using LinkedList;
using Queue.Interface;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Queue.Implementation
{
    public class LinkedListQueueImplemntation : IQueue
    {
        public int count { get; set; }
        private LinkedListImplementationWithExtraFunctions LinkedList;

        public void Dequeue()
        {
           
            Element headelement = LinkedList.head;
            LinkedList.head = headelement.next;



          
        }

        public void Enqueue(int value)
        {
            Element element = new Element(value, null);
            if (LinkedList==null)
            {
                LinkedList = new LinkedListImplementationWithExtraFunctions();
                LinkedList.head = element;
                LinkedList.tail = element;
                return;
            }
            Element tmp = LinkedList.head;
            while(tmp.next!=null)
            {
                tmp = tmp.next;
            }
            tmp.next = element;
            LinkedList.tail = element;
            
        }
        public Element find(int value)
        {
            if (LinkedList == null)

            {
                return null;
            }
           
            Element currentElement = (Element)LinkedList.head;
            Element target = null;
            while (currentElement.next != null)
            {
                if (currentElement.value!=value)
                {
                    currentElement = currentElement.next;
                }
                else
                {
                    target = currentElement;
                    break;
                }

            }
            return target;
          
        }
        public Element Max()
        {
             if (LinkedList == null)
               
                    {
                return null;
            }
            Element maxElement = (Element)LinkedList.head;
            Element currentElement = maxElement;
            while (currentElement.next!=null)
            {
                if (maxElement.next.value>maxElement.value)
                {
                    maxElement = maxElement.next;
                }
                currentElement= currentElement.next;
            }
            return maxElement;
        }

        public void deQueueMax(Element max)
        {

            //1-3-2-3


            Element head = LinkedList.head;
            Element tmp = head;
            while (tmp != null)
            {
                if (tmp.next != null)
                {

                    if (tmp.next.value == max.value)
                    {
                        tmp.next = tmp.next.next;


                    }
                }
                tmp = tmp.next;



            }
        }
    }
}
