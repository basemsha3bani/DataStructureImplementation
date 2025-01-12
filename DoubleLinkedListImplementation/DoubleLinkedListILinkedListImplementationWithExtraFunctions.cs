using Microsoft.VisualBasic.FileIO;
using System;
using System.ComponentModel;
using System.Net;
using System.Runtime.Serialization;
using static System.Net.Mime.MediaTypeNames;

namespace LinkedList
{
    public class DoubleLinkedListILinkedListImplementationWithExtraFunctions: DoubleLinkedListImplementation
    {
        public Element find(int value)
        {
            Element element = head;
            while (element!=null)
            {
                if(element.value==value)
                {
                    break;
                }
                element = element.next;

            }
            return element;
        }
        public void Insertbefore(int nextValue, int value)
        {
            Element nextValueElement = this.find(nextValue);
            if (nextValueElement.previous==null)
            {
                this.Prepend(value);
                return;
            }
            Element newElement = new Element(value, null);
            
            newElement.next = nextValueElement;
           
            var temp = head;
            while(temp!= nextValueElement.previous)
            {
                temp = temp.next;
            }
            temp.next = newElement;
            newElement.previous = temp;
            nextValueElement.previous = newElement;
            







        }

        public void reverse()
        {
            Element element = head,prev = null, next;

            while (element!=null)
            {
                next = element.next;
                element.next = prev;
                prev = element; 
                element = next;
            }
            head = prev;
        }
     Element  swap(Element element,Element element2)
        {
            Element temp = element;
            element = element2;
            
            element2 = temp;
           
            return element;

        }
           

                

            
           

    }


}
