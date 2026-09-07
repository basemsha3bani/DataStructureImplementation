
using Common;
using LinkedList;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Queue.Implementation;
using Queue.Interface;
using System;
using System.Linq;
using TestProject.QueuePracticeProblem.AirportServiceSimulation;

namespace TestProject
{
    [TestClass]
    public class QueueTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            LinkedListQueueImplemntation x = new LinkedListQueueImplemntation();
            x.Enqueue(1);
            x.Enqueue(2);
            x.Dequeue();


        }
        [TestMethod]
        public void RemoveMaxTest()
        {
            ArrayQueueImplemenationWithExtraFunctions x = new ArrayQueueImplemenationWithExtraFunctions();
            x.Enqueue(1);
            x.Enqueue(3);
            x.Enqueue(2);
            x.Enqueue(3);
            QueueMaxElementsOperations.removeMax(x);
            Assert.AreEqual(x.Max().value, 2);
            LinkedListQueueImplementationWithExtraFunctions y = new LinkedListQueueImplementationWithExtraFunctions();
            y.Enqueue(1);
            y.Enqueue(3);
            y.Enqueue(2);
            y.Enqueue(3);
            QueueMaxElementsOperations.removeMax(y);
            Assert.AreEqual(x.Max().value, 2);


        }
        ///Test for Airport Service Simulation
        [TestMethod]
        public void AirportServiceSimulationTest()
        {
            Airport airport = new Airport();
            airport.StartService();
            bool KeepCheck = true;
            while (KeepCheck)
            {

                if (airport.TimeInService > 2)
                {
                    KeepCheck = false;
                }
            }
            Assert.IsTrue(airport.PlanesInQueue > 0, "Planes should have landed during the simulation.");

            // Add assertions to verify the expected behavior of the airport service simulation
        }


    }
}
