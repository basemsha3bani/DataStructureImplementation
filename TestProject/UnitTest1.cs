using LinkedList;
using NUnit.Framework;
using System.Collections.Generic;

namespace TestProject
{

    

    
        public class Tests
        {
            [SetUp]
            public void Setup()
            {
            }

            [Test]
            public void Test1()
            {
                BasicLinkedListImplementation list = new BasicLinkedListImplementation();
                list.Append(1);
                list.Append(2);
                list.Prepend(0);

                var elements = list.print();
                list.delete(2);
                elements = list.print();
            }
        }
    
}