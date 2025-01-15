
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Queue.Implementation;

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
    }
}
