using Common;
using Microsoft.VisualBasic.FileIO;
using System;
using System.ComponentModel;
using System.Net;
using System.Runtime.Serialization;

namespace LinkedList
{
    public class LinkedListImplementationWithExtraFunctions: BasicLinkedListImplementation
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
     
           

                

            
           

    }


}
