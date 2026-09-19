using Queue.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace TestProject.QueuePracticeProblem.AirportServiceSimulation
{
    public class PlanePathWay
    {
       
        public int PlanesInQueue { get
            {
                return PlaneQueue.count;
            }
        
        }
       
        private int averageArrivalTime = 2;
        int nextArrivalTime;
        int serviceTimeInMinutes = 2; // This is the time it takes to service a plane
        int timeToDequeue = 0; // This is the time it takes to dequeue a plane from the queue
        private Queue.Implementation.LinkedListQueueImplemntation PlaneQueue  = new LinkedListQueueImplemntation();
        
        // Add this field to the PlanePathWay class to provide a random number generator instance
        private static readonly Random random = new Random();

        public PlanePathWay()
        {
            nextArrivalTime = averageArrivalTime;
           
        }

        private void ServePlanes(object sender, ElapsedEventArgs e)
        {
           
            int tick = (int)DateTime.Now.Subtract(startTime).TotalMinutes;
            if (tick > max)
            {
                timer.Stop();
                return;
            }


            if (tick == nextArrivalTime)
            {
                // Simulate a new plane arrival
                Plane newPlane = new Plane(tick);
                newPlane.ArrivalTime = tick;
                LandPlane(newPlane);



                nextArrivalTime = tick + random.Next(1, 13);
                timeToDequeue = tick + serviceTimeInMinutes;
            }
            if (tick == timeToDequeue)
            {
                if (PlaneQueue.count > 0)
                {
                  
                   PlaneQueue.Dequeue();
                }
                  
             }
        }
        

        private Timer timer;
      
        
        public int max { get;  set; }
        public DateTime startTime { get; set; }

        public void LandPlane(Plane plane)
        {
           
            PlaneQueue.Enqueue(plane.ArrivalTime);
       }

        public void RunService()
        {




            timer = new Timer(60000); // 1 minute interval
            timer.Elapsed += ServePlanes;
            timer.Enabled = true;
            timer.Start();

        }


    }
    public class Airport
    {

        private int maxHours { get; set; } = 6;

        DateTime startTime;

      
        public int PlanesInQueue
        {
            get
            {
                return planePathway.PlanesInQueue;
            }
        }
        
        public int TimeInService
        {
            get
            {
                return elaspedTime;
            }
        }

       
        private int elaspedTime
        {
            get
            {
                return (int)DateTime.Now.Subtract(startTime).TotalMinutes;
            }
        }
       
       
        private PlanePathWay planePathway;
        public Airport()
        {
           
        }
       

        public void StartService()
        {
            
            ; // This is the average time between plane arrivals




                int max = maxHours * 60; // Convert hours to minutes


                startTime = DateTime.Now; // This is the start time of the service

            planePathway = new PlanePathWay();
            planePathway.max = max;
            planePathway.startTime = startTime;
           planePathway.RunService();
            


        }
       
        
    }
}

