using Common;
using LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeImplementation
{
    public class BinarySearchTreeImplementation : BinaryTreeImplementation

    {
        public BinarySearchTreeImplementation()
        {

        }
        
        private void addNode(charElement e)
        {
            this.root = new charElement(e.value, null);
            this.left = new BinarySearchTreeImplementation();
            this.right = new BinarySearchTreeImplementation();
        }
        public void delete()
        {

        }

        public void insert(charElement e)
        {
            if (isEmpty())
                addNode(e);
            else
            {
               charElement root= GetRoot();
                if (root.CompareTo(e) == 0)
                    throw new IllegalArgumentException("duplicate key");
                else if (e.CompareTo(root) < 0)
                  ((BinarySearchTreeImplementation) getLeft()).insert(e);
                else
                    ((BinarySearchTreeImplementation)getRight()).insert(e);
            }
        }





    }
}
