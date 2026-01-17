using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeImplementation.TreeTraversal.Implementation.DepthFirst.Abstraction
{
    public abstract class DepthFirstImplementation
    {
        abstract public List<char> Traverse(BinarySearchTreeImplementation binarySearchTree);
    }
}
