using Common;
using LinkedList;
using Queue.Interface;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue.Implementation
{
    public class ArrayQueueImplementation
    {
        public int count { get; set; }
      
       protected ArrayList ArrayList = new ArrayList();

        public void Dequeue()
        {

            ArrayList.RemoveAt(0);
            count = ArrayList.Count;
        }

        public void Enqueue(int v)
        {
            Element element = new Element(v, null);
            ArrayList.Add(element); 
        }
       

       
    }
}
