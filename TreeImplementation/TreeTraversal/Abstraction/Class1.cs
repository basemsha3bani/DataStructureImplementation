using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeImplementation.TreeTraversal.Abstraction
{
    internal abstract class TreeTraversor
    {
        public TreeTraversor()
        {
        }
        internal abstract void traverse(BinarySearchTreeImplementation binarySearchTree);
    }
}
 