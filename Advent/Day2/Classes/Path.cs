using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2.Classes
{
    public class Path
    {
        public Point Point { get; private set; }
        public Node Node { get; private set; }
        public List<Node> VisitedNodes { get; }
        public Graph Graph { get; }

        public Path(string path, Graph graph)
        {
            Graph = graph;
            Point = new Point(0,0);
            Node = Graph.GetNodeFrom(Point);
            VisitedNodes = new List<Node> {Node};

            ProcessPath(path);
        }

        private void ProcessPath(string path)
        {
            var inputs = path.ToCharArray();

            foreach (var next in inputs.Select(input => new Direction(input)).Select(dir => Point + dir.Translation).Where(next => Graph.Map.ContainsKey(next)))
            {
                Node = Graph.GetNodeFrom(next);
                Point = next;
                VisitedNodes.Add(Node);
            }
        }
    }
}
