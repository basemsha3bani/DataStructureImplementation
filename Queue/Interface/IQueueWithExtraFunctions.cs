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

        public GenericDataTypeElement find(int value);
        public  GenericDataTypeElement Max();
      public  void deQueueMax(GenericDataTypeElement max);

       
    }
}
