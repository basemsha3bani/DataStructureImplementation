using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeImplementation;
using TreeImplementation.TreeTraversal.Implementation.DepthFirst.implementation;

namespace TestProject
{
    [TestClass]
    public class TreeTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            BinarySearchTreeImplementation binarySearchTree = new BinarySearchTreeImplementation();
            binarySearchTree.insert(new Common.charElement('a', null));
            binarySearchTree.insert(new Common.charElement('b', null));
            binarySearchTree.insert(new Common.charElement('d', null));
            binarySearchTree.insert(new Common.charElement('c', null));
            binarySearchTree.insert(new Common.charElement('f', null));
            List<char> result = new List<char>();
            result= new InOrderTraversal().Traverse(binarySearchTree);
            Assert.AreEqual('a', result[0]);
            Assert.AreEqual('b', result[1]);
            result= new PostOrderTraversal().Traverse(binarySearchTree);
            Assert.AreEqual('f', result[1]);
        }
    }
}
