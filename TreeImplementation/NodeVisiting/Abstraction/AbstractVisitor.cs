using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeImplementation.NodeVisiting.Abstraction
{
    internal abstract class AbstractVisitor<T> where T : class, IComparable<T>  
    {
        public abstract void Visit(BinaryTreeImplementation<T> node);
    }
}
