using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeImplementation.TreeTraversal.Implementation.BreadthFirst
{
    internal class breadthFirstTraversal<T> : TreeTraversal.Abstraction.TreeTraversor<T> where T : class, IComparable<T>
    {
        internal override void traverse(BinarySearchTreeImplementation<T> binarySearchTree)
        {
            throw new NotImplementedException();
        }
    }
}
