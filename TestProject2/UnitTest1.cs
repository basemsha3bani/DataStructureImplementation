using LinkedList;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            LinkedListImplementationWithExtraFunctions x = new LinkedListImplementationWithExtraFunctions();
            x.Append(1);
            x.Append(2);
            x.Prepend(0);
            var elemets = x.Print();
            x.Delete(2);
            Element element1=x.find(10);
            Element element2 = x.find(0);
            x.reverse();
            elemets = x.Print();
        }
    }
}
