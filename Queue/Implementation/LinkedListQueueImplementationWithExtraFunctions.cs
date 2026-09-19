using Common;
using LinkedList;
using Queue.Interface;

namespace Queue.Implementation
{
    public class LinkedListQueueImplementationWithExtraFunctions : LinkedListQueueImplemntation, IQuequeWithExtraFunctions
    {       
        public GenericDataTypeElement find(int value)
        {
            if (LinkedList == null)

            {
                return null;
            }
           
            GenericDataTypeElement currentElement = (GenericDataTypeElement)LinkedList.head;
            GenericDataTypeElement target = null;
            int elementValue = value;
            int currentElementValue;
            while (currentElement.next != null)
            {
                currentElementValue =(int) currentElement.value;
                if (currentElementValue!=elementValue)
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
        public GenericDataTypeElement Max()
        {
             if (LinkedList == null)
               
                    {
                return null;
            }
            GenericDataTypeElement maxElement = (GenericDataTypeElement)LinkedList.head;
            GenericDataTypeElement currentElement = maxElement;
            int maxElementValue, nextElementValue;
            while (currentElement.next!=null)
            {
                maxElementValue = (int) maxElement.value;
                nextElementValue = (int)maxElement.next.value;
                if (maxElementValue>nextElementValue)
                {
                    maxElement = maxElement.next;
                }
                currentElement= currentElement.next;
            }
            return maxElement;
        }

        public void deQueueMax(GenericDataTypeElement max)
        {

            //1-3-2-3


            GenericDataTypeElement head = LinkedList.head;
            GenericDataTypeElement tmp = head;
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
