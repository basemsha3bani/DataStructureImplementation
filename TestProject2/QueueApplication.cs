using LinkedList;
using Queue.Implementation;
using Queue.Interface;

public static class ArrayQueueApplication
{
    
   

    public static void  removeMax(IQueue arrayQueue)
    {
       
        var max=arrayQueue.Max();
        Element temp = arrayQueue.find(max.value);
        
        while (temp!=null)
        {

            arrayQueue.deQueueMax(temp);
            
            temp= arrayQueue.find(max.value);
            var x = arrayQueue;
        }

        
    }
}