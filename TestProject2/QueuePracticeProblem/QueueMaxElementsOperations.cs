using Common;
using LinkedList;
using Queue.Implementation;
using Queue.Interface;

public static class QueueMaxElementsOperations
{
    
   

    public static void  removeMax(IQuequeWithExtraFunctions arrayQueue)
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