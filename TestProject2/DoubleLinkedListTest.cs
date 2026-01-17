using BasicLinkedList.CustomTypes;
using Common;
using LinkedList;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject
{
    [TestClass]
    public class DoubleLinkedListTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DoubleLinkedListILinkedListImplementationWithExtraFunctions x = new DoubleLinkedListILinkedListImplementationWithExtraFunctions();
            x.Append(1);

            x.Append(3);
            x.Insertbefore(3, 2);
            x.Prepend(0);
            var elemets = x.Print();
            x.Delete(2);
            x.Insertbefore(3, 2);
            Element element1 = x.find(10);
            Element element2 = x.find(0);
        }
       



    }
}
