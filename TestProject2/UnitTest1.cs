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
            BasicLinkedListImplementation x = new BasicLinkedListImplementation();
            x.Append(1);
            x.Append(2);
            x.Prepend(0);
            var elemets = x.print();
            x.delete(2);
            elemets=x.print();

        }
    }
}
