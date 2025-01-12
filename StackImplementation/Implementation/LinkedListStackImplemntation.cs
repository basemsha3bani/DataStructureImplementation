using LinkedList;
using Stack.Interface;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Stack.Implementation
{
    public class LinkedListStackImplemntation : IStack
    {
        public int count { get; set; }
        private LinkedListImplementationWithExtraFunctions LinkedList;

        public Element pop()
        {
            Element tail = LinkedList.tail;
            Element tmp = LinkedList.head;
            while (tmp!= null)
            {
                if(tmp.next== tail)
                {
                    tmp.next = null;
                    LinkedList.tail = tmp;
                }

                tmp = tmp.next;
            }
            

            return tail;
        }

        public void push(int value)
        {
            Element elemen = new Element(value, null);
            if (LinkedList==null)
            {
                LinkedList = new LinkedListImplementationWithExtraFunctions();
                LinkedList.head = elemen;
                LinkedList.tail = elemen;
                return;
            }
            Element tmp = LinkedList.head;
            while (tmp.next != LinkedList.tail && tmp.next != null)
            {
                tmp = tmp.next;

            }
            tmp.next = elemen;
            LinkedList.tail = elemen;
        }
    }
}
