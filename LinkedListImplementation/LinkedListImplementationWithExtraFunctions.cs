using Common;
using Microsoft.VisualBasic.FileIO;
using System;
using System.ComponentModel;
using System.Net;
using System.Runtime.Serialization;

namespace LinkedList
{
    public class LinkedListImplementationWithExtraFunctions: ElementLinkedListImplementation 
    {
      
        public GenericDataTypeElement find(object value)
        {
            GenericDataTypeElement element = head;
            int ElementValue;
            int searchValue = (int)value;
            while (element!=null)
            {
                 ElementValue = (int)element.value;
                if (ElementValue ==searchValue)
                {
                    break;
                }
                element = element.next;

            }
            return element;
        }

        public override void Prepend(object value)
        {
            throw new NotImplementedException();
        }

        public void reverse()
        {
            GenericDataTypeElement element = head,prev = null, next;

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
