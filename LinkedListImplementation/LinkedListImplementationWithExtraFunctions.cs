using Microsoft.VisualBasic.FileIO;
using System;
using System.ComponentModel;
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
            //1,2,3,4 head=1 
            //2,1,3,4 
            //2,3,1,4 head=4
            //2,3,4,1
            //3,2,4,1
            //3,4,2,1
            //4,3,2,1


            Element temp = head, next,prev=null;

            while (temp!= null)
            {
                next = temp.next;
                temp.next=prev;

                prev = temp;
                temp = next;



              

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
