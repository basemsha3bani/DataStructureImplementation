using Common;
using LinkedList;
using Queue.Implementation;
using Queue.Interface;

public static class QueueMaxElementsOperations
{
    
   

    public static void  removeMax(IQuequeWithExtraFunctions arrayQueue)
    {
       
        var max=arrayQueue.Max();
        GenericDataTypeElement temp = arrayQueue.find((int)max.value);
        
        while (temp!=null)
        {

            arrayQueue.deQueueMax(temp);
            
            temp= arrayQueue.find((int) max.value);
            var x = arrayQueue;
        }

        
    }
}