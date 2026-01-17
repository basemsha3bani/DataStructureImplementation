using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeImplementation.TreeTraversal.Implementation.DepthFirst.Abstraction;

namespace TreeImplementation.TreeTraversal.Implementation.DepthFirst.implementation
{
    public class PostOrderTraversal : DepthFirstImplementation
    {
        public override List<char> Traverse(BinarySearchTreeImplementation binarySearchTree)
        {
            if (binarySearchTree.isEmpty())
            {
                return new List<char>();
            }
            else
            {
                List<char> result = new List<char>();
                result.AddRange(Traverse((BinarySearchTreeImplementation)binarySearchTree.getLeft()));
                result.AddRange(Traverse((BinarySearchTreeImplementation)binarySearchTree.getRight()));
                result.Add(binarySearchTree.GetRoot().value);
                return result;
            }
        }
    }
}
