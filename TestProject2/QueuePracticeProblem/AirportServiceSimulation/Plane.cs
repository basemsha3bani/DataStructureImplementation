using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.QueuePracticeProblem.AirportServiceSimulation
{
    public class Plane:GenericDataTypeElement
    {
        public Plane(int Id) : base(Id,null)
        {
        }

       public int ArrivalTime { get; set; }
    }

}
