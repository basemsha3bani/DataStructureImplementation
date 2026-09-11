using Common;

namespace Graph
{
    public class GraphImplementation
    {

       public List<GraphNode> graphNodes { get; set; } = new List<GraphNode>();


        public GraphImplementation() { }

        public void AddEdge(GraphNode node)
        {
            graphNodes.Add(node);
        }
        public List<int> Traverse(GraphNode start)
        {
            List<int> visitedNodes= new List<int>();
            visitedNodes.Add(start.element.value);
            if (start.connectedElements == null)
            {
                return visitedNodes;
            }
            foreach (GraphNode node in start.connectedElements)
            {
                visitedNodes.Add(node.element.value);
                {
                    GraphNode childNode;
                    if (node.connectedElements == null) continue;
                    foreach (GraphNode connectedNode in node.connectedElements)
                    {
                        childNode = connectedNode;
                        if(!visitedNodes.Contains(connectedNode.element.value))
                        {
                            visitedNodes.Add(connectedNode.element.value);
                            visitedNodes = visitedNodes.Union(Traverse(connectedNode)).ToList();
                            //instead of this line add
                            //visitedNodes = visitedNodes.Union(TraverseChildren(node.connectedElements)).ToList();
                        }






                    }


                }

            }
            return visitedNodes;
        }
    }
        public class GraphNode
        {
            public Element element { get; set; }
            public List<GraphNode> connectedElements { get;  set; }
        }
}
