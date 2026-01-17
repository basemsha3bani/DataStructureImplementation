using Common;
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
        protected LinkedListImplementationWithExtraFunctions LinkedList;

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

        }
}
