using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2.Classes
{
    public class Graph
    {
        public Dictionary<Point, Node> Map { get; } 

        public Graph(List<Tuple<int, int, string>> map) 
        {
            Map = new Dictionary<Point, Node>();
            FillMap(map);
        }

        private void FillMap(List<Tuple<int, int, string>> map)
        {
            foreach (var tuple in map)
            {
                var point = new Point(tuple.Item1, tuple.Item2);
                var node = new Node(tuple.Item3);
                Map.Add(point, node);
            }
        }

        public Node GetNodeFrom(Point point)
        {
            return Map[point];
        }
    }
}
