using Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using System.Xml.Serialization;

namespace LinkedList
{
    public class DoubleLinkedListImplementation
    {
        public Element head { get; set; }
        public Element tail  { get; set; }

        public void Prepend(int value)
        {
            Element element = new Element(value, null);
            if (head == null)
            {
                head = new Element(value, null);
                head.previous = null;


            }
            else
            {
                element.next = head;
                head.previous = element;
                element.previous = null;
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
                element.previous = tail;
                tail = element;
            }



        }
        

        public void Delete(int value)
        {
            Element element = head,previous=null;
            while(element.value!=value) 
            
            {
               previous = element;
               element = element.next;  
                

            }
            previous.next = element.next;
            previous.next.previous = previous;





        }

        public List<string>  Print()
        {
            List<string> elements = new List<string>();
            Element element = head;
            while (element != null)
            {
                elements.Add(element.value.ToString());
                element = element.next;
            }
            return elements;


        }


    }


}
