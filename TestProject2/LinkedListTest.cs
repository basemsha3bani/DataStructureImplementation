using BasicLinkedList.CustomTypes;
using Common;
using LinkedList;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject
{
    [TestClass]
    public class LinkedListTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            LinkedListImplementationWithExtraFunctions x = new LinkedListImplementationWithExtraFunctions();
            x.Append(1);
            x.Append(2);
            x.Prepend(0);
            var elemets = x.Print();
            x.delete(2);
            GenericDataTypeElement element1=x.find(10);
            GenericDataTypeElement element2 = x.find(0);
            x.reverse();
            elemets = x.Print();
        }

        [TestMethod]
        public void TestMethod2()
        {
            DoubleEndedQueue doubleEndedQueue = new DoubleEndedQueue();
            doubleEndedQueue.AddFront(2);
            doubleEndedQueue.AddFront(1);
            doubleEndedQueue.AddRear(3);

            var elemets = doubleEndedQueue.Print();
            Assert.AreEqual("2", elemets[1]);
            Assert.AreEqual("3", elemets[2]);
        }


    }
}
