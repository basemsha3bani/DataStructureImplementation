using Common;
using LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeImplementation
{
    public class BinarySearchTreeImplementation<T> : BinaryTreeImplementation<T> where T :class,IComparable<T>

    {
        public BinarySearchTreeImplementation()
        {

        }
        public bool Search(T value)
        {
            if (isEmpty()) return false;

            T rootVal = GetRoot();
            if (rootVal.CompareTo(value) == 0) return true;
            else if (value.CompareTo(rootVal) < 0)
                return ((BinarySearchTreeImplementation<T>)getLeft()).Search(value);
            else
                return ((BinarySearchTreeImplementation<T>)getRight()).Search(value);
        }

        public void Delete(T value) { /* we can do this later */ }
    
        private void addNode(T e)
        {
            this.root = e;
            this.left = new BinarySearchTreeImplementation<T>();
            this.right = new BinarySearchTreeImplementation<T>();
        }
        public void delete()
        {

        }

        public void insert(T e)
        {
            if (isEmpty())
                addNode(e);
            else
            {
               T root= GetRoot();
                if (root.CompareTo(e) == 0)
                    throw new IllegalArgumentException("duplicate key");
                else if (e.CompareTo(root) < 0)
                  ((BinarySearchTreeImplementation<T>) getLeft()).insert(e);
                else
                    ((BinarySearchTreeImplementation<T>)getRight()).insert(e);
            }
        }





    }
}
