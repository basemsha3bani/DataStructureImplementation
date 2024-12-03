using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using System.Xml.Serialization;

namespace LinkedList
{
    public class BasicLinkedListImplementation
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

        public void delete(int value)
        {
            Element element = head,previous=null;
            while(element.value!=value) 
            
            {
               previous = element;
               element = element.next;  
                //0 1 

            }
            previous.next = element.next;





        }

        public List<string>  print()
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
