using Common;
using LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TreeImplementation
{
    public class BinaryTreeImplementation<T> where T :class
    {
        public BinaryTreeImplementation<T>? left, right;
        
        protected int depth;
        protected T root;

        public BinaryTreeImplementation( )
        {

            this.left = null;
            this.right = null;
            this.root = null;
        }

        public BinaryTreeImplementation(BinaryTreeImplementation<T> left, BinaryTreeImplementation<T> right, T element)
        {
            this.left = left;
            this.right = right;
            this.root = element;
           
        }

        public BinaryTreeImplementation(T key)
        {
            this.left = new BinaryTreeImplementation<T>();
            this.right = new BinaryTreeImplementation<T>();
            this.root = key;
          

        }
        public bool isEmpty()
        {
            return this.root == null;   
        }
        public bool isLeaf()
        {
            return !this.isEmpty()&&this.left.isEmpty()&&this.right.isEmpty();  
        } 
        public T GetRoot() {
            if (!isEmpty()) {
                return this.root;   
            }
            return null;
        }
        public int getHeight()
        {
            if (isEmpty()) return -1;
            else return 1 + Math.Max(left.getHeight(), right.getHeight());
        }

        public BinaryTreeImplementation<T> getLeft()
        {
            if (isEmpty()) throw new InvalidOperationException();
            else return left;
        }

        public BinaryTreeImplementation<T>    getRight()
        {
            if (isEmpty()) throw new InvalidOperationException();
            else return right;
        }

        public T destroy()
        {
              T temp = this.root;
            this.root = null;
            this.left = null;
            this.right = null;
            return temp;

        }




    }
}
