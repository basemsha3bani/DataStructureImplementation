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
    public class BinaryTreeImplementation
    {
        public BinaryTreeImplementation? left, right;
        
        protected int depth;
        protected charElement root;

        public BinaryTreeImplementation( )
        {

            this.left = null;
            this.right = null;
            this.root = null;
        }

        public BinaryTreeImplementation(BinaryTreeImplementation left, BinaryTreeImplementation right, charElement element)
        {
            this.left = left;
            this.right = right;
            this.root = element;
           
        }

        public BinaryTreeImplementation(charElement key)
        {
            this.left = new BinaryTreeImplementation();
            this.right = new BinaryTreeImplementation();
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
        public charElement GetRoot() {
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

        public BinaryTreeImplementation getLeft()
        {
            if (isEmpty()) throw new InvalidOperationException();
            else return left;
        }

        public BinaryTreeImplementation getRight()
        {
            if (isEmpty()) throw new InvalidOperationException();
            else return right;
        }

        public charElement destroy()
        {
              charElement temp = this.root;
            this.root = null;
            this.left = null;
            this.right = null;
            return temp;

        }




    }
}
