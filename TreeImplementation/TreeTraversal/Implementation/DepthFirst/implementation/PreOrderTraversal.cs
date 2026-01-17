using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeImplementation.TreeTraversal.Implementation.DepthFirst.Abstraction;

namespace TreeImplementation.TreeTraversal.Implementation.DepthFirst.implementation
{
    internal class PreOrderTraversal : DepthFirstImplementation
    {
        public override List<char> Traverse(BinarySearchTreeImplementation binarySearchTree)
        {
            if (binarySearchTree.isEmpty())
            {
                return new List<char>();
            }
            List<char> result = new List<char>();
            result.Add(binarySearchTree.GetRoot().value);
            result.AddRange(Traverse((BinarySearchTreeImplementation)binarySearchTree.getLeft()));
            result.AddRange(Traverse((BinarySearchTreeImplementation)binarySearchTree.getRight()));
            return result;

        }
    }
        
    
}
