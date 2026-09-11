using Graph;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    [TestClass]
    public class GraphTest
    {
        [TestMethod]
        public void TestGraph()
        {
            GraphImplementation graphImplementation;
            graphImplementation = new GraphImplementation();
            graphImplementation.AddEdge(new GraphNode
            {
                element = new Common.Element(1, null),
                connectedElements = new List<GraphNode>()
                {
                    new GraphNode
                    {
                        element= new Common.Element(2,null),
                        connectedElements = new List<GraphNode>()
                             {
                                        new GraphNode
                                        {
                                            element= new Common.Element(4,null)

                                        },
                             }
                    },
                    new GraphNode
                    {
                        element= new Common.Element(3,null),
                         connectedElements = new List<GraphNode>()
                             {
                                    new GraphNode
                                    {
                                        element= new Common.Element(5,null)

                                    }
                             }
                    }
                }
                    



                
            });
          

           ;

            List<int> x = graphImplementation.Traverse(graphImplementation.graphNodes[0]);

        }
    }
}
