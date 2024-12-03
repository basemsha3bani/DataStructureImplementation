using System;
using System.Configuration;
using System.Xml.Serialization;

namespace LinkedList
{
    public class LinkedListImplementation
    {
        public Element head { get; set; }
        public Element tail  { get; set; }

        public void Prepend(int value)
        {
            Element element = new Element(value, null);
            if (head == null)
            {
                head = new Element(value, null);
              
            }
            else
            {
                element.next = head;
                head = element;
            }

            

        }
        public void Append(int value)
        {
            Element element = new Element(value, null);
            if (head == null)
            {
                head = element;
                tail = element;

            }
            else
            {
              
                tail.next = element;
            }



        }
    }
     public class Element
    {
        
        public Element(int v, Element value1)
        {
            this.value = v;
            this.next = value1;
        }

        public int value {  get; set; }  
        public Element next { get; set; }

    }

}
