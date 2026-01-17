using Common;
using LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue.Interface
{
    public interface  IQuequeWithExtraFunctions

    {

        public Element find(int value);
        public  Element Max();
      public  void deQueueMax(Element max);

       
    }
}
