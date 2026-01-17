using Common;
using LinkedList;
using Queue.Interface;

namespace Queue.Implementation
{
    public class LinkedListQueueImplementationWithExtraFunctions : LinkedListQueueImplemntation, IQuequeWithExtraFunctions
    {       
        public Element find(int value)
        {
            if (LinkedList == null)

            {
                return null;
            }
           
            Element currentElement = (Element)LinkedList.head;
            Element target = null;
            while (currentElement.next != null)
            {
                if (currentElement.value!=value)
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
        public Element Max()
        {
             if (LinkedList == null)
               
                    {
                return null;
            }
            Element maxElement = (Element)LinkedList.head;
            Element currentElement = maxElement;
            while (currentElement.next!=null)
            {
                if (maxElement.next.value>maxElement.value)
                {
                    maxElement = maxElement.next;
                }
                currentElement= currentElement.next;
            }
            return maxElement;
        }

        public void deQueueMax(Element max)
        {

            //1-3-2-3


            Element head = LinkedList.head;
            Element tmp = head;
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
