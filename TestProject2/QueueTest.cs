
using LinkedList;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Queue.Implementation;
using Queue.Interface;
using System.Linq;

namespace TestProject2
{
    [TestClass]
    public class QueueTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            LinkedListQueueImplemntation x = new LinkedListQueueImplemntation();
            x.Enqueue(1);
            x.Enqueue(2);
            x.Dequeue();


        }
        [TestMethod]
        public void RemoveMaxTest()
        {
            IQueue x = new ArrayQueueImplementation();
            x.Enqueue(1);
            x.Enqueue(3);
            x.Enqueue(2);
            x.Enqueue(3);
            QueueApplication.removeMax(x);
            Assert.AreEqual(x.Max().value, 2);
            x = new LinkedListQueueImplemntation();
            x.Enqueue(1);
            x.Enqueue(3);
            x.Enqueue(2);
            x.Enqueue(3);
            QueueApplication.removeMax(x);
            Assert.AreEqual(x.Max().value, 2);


        }

    }

    public static class QueueApplication
    {

        /*write a static method named removeMax 
         * that takes an unbounded queue of integers as its parameter.
         * The method removes the maximum value from the queue keeping other elements in their original locations in the queue. 
         * If the maximum value appears more than once, all occurrences of the maximum should be removed from the queue
         * */

        public static void removeMax(IQueue arrayQueue)
        {

            var max = arrayQueue.Max();
            Element temp = arrayQueue.find(max.value);

            while (temp != null)
            {

                arrayQueue.deQueueMax(temp);

                temp = arrayQueue.find(max.value);
                var x = arrayQueue;
            }


        }
    }
}
