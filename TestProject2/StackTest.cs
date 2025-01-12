
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Stack.Implementation;

namespace TestProject2
{
    [TestClass]
    public class StackTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            LinkedListStackImplemntation x = new LinkedListStackImplemntation();
            x.push(1);
            x.push(2);
            x.pop();


        }
    }
}
