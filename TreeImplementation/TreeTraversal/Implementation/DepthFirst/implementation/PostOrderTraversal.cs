using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeImplementation.TreeTraversal.Implementation.DepthFirst.Abstraction;

namespace TreeImplementation.TreeTraversal.Implementation.DepthFirst.implementation
{
    public class PostOrderTraversal<T> : DepthFirstImplementation<T> where T : class,IComparable<T>
    {
        public override List<T> Traverse(BinarySearchTreeImplementation<T> binarySearchTree)
        {
            if (binarySearchTree.isEmpty())
            {
                return new List<T>();
            }
            else
            {
                List<T> result = new List<T>();
                result.AddRange(Traverse((BinarySearchTreeImplementation<T>)binarySearchTree.getLeft()));
                result.AddRange(Traverse((BinarySearchTreeImplementation<T>)binarySearchTree.getRight()));
                result.Add(binarySearchTree.GetRoot());
                return result;
            }
        }
    }
}
