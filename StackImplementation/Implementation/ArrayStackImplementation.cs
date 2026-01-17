
using Common;
using LinkedList;
using Stack.Interface;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack.Implementation
{
    public class ArrayStackImplementation : IStack
    {
        public int count { get ; set ; }
        protected ArrayList ArrayList = new ArrayList();

        public Element pop()
        {
            if(ArrayList.Count==0)
            {
                return null;
            }   
            Element temp = (Element) ArrayList[ArrayList.Count - 1];
             ArrayList.Remove(temp);
            return temp;

        }

        public void push(int v)
        {
           ArrayList.Add( new Element(v,null)); 
        }
    }
}
