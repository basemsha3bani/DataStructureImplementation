using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeImplementation.NodeVisiting.Implementation
{
    internal class DictionaryEntryTreeVisitor<T> : Abstraction.AbstractVisitor<T> where T : class, IComparable<T>
    {
        public override void Visit(BinaryTreeImplementation<T> node)
        {
            throw new NotImplementedException();
        }
    }
}
