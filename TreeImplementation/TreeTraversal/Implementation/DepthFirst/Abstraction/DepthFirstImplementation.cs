using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeImplementation.TreeTraversal.Implementation.DepthFirst.Abstraction
{
    public abstract class DepthFirstImplementation<T> where T : class,IComparable<T>
    {
        abstract public List<T> Traverse(BinarySearchTreeImplementation<T> binarySearchTree);
    }
}
