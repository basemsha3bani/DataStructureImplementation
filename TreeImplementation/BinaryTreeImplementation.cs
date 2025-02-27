using LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TreeImplementation
{
    internal class BinaryTreeImplementation
    {
        public BinaryTreeImplementation? left, right;
        
        protected int depth;
        protected Element root;

        public BinaryTreeImplementation( )
        {


        }

        public BinaryTreeImplementation(BinaryTreeImplementation left, BinaryTreeImplementation right, Element element)
        {
            this.left = left;
            this.right = right;
            this.root = element;
           
        }

        public BinaryTreeImplementation(Element key)
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
        public Element GetElement() {
            if (!isEmpty()) {
                return this.root;   
            }
            return null;
        }

        public void insert(Element element)
        {
            if (isEmpty())
            {
                return;
            }
            {
                this.root = element;
                this.left = new BinaryTreeImplementation(); 
                this.right = new BinaryTreeImplementation();    
            }
            
        }
    }
}
